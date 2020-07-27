using System.Collections.Generic;
using System.Data;
using System.IO;
using UnityEditor;
using UnityEditor.Build;
using UnityEngine;
using System;
namespace MiniGameSDK
{
    [InitializeOnLoad]
    class SwitchCallBack : IActiveBuildTargetChanged
    {
        static string path = "Assets/Editor/PlatformValues";
        static SwitchCallBack()
        {

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                LogTip();
            }
        }
        static void LogTip()
        {
            Debug.Log("请将参数表以‘ios’或‘android’开头命名，放入Assets->Editor->PlatformValues文件夹内"
            + ",手动应用平台参数(excel 文件上右键->作为广告平台参数)"
            + ",之后切换平台将自动应用对应平台参数。");
        }
        public int callbackOrder => 100;

        public void OnActiveBuildTargetChanged(BuildTarget previousTarget, BuildTarget newTarget)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                LogTip();
                return;
            }
            foreach (var item in Directory.GetFiles(path))
            {
                string suffx = Path.GetExtension(item);
                if (suffx.Equals(".xlsx") || suffx.Equals(".xls"))
                {
                    var fname = Path.GetFileName(item);
                    if (fname.StartsWith(newTarget.ToString(), System.StringComparison.CurrentCultureIgnoreCase))
                    {
                        SwitchPlatformValue.Load();
                        SwitchPlatformValue.Read(ExcelHelper.OpenExcel(item));
                        break;
                    }
                }
            }
        }
    }

    public class SwitchPlatformValue
    {
        static Dictionary<Type, IBuildValueSetter> setters = new Dictionary<Type, IBuildValueSetter>();
        internal static void Load()
        {
            foreach (var item in typeof(SwitchPlatformValue).Assembly.GetTypes())
            {
                if (item.IsAbstract) continue;
                if (typeof(IBuildValueSetter).IsAssignableFrom(item))
                {
                    if (!setters.ContainsKey(item))
                    {
                        Debug.Log(item);
                        setters.Add(item, Activator.CreateInstance(item) as IBuildValueSetter);
                    }
                }
            }
        }
        [MenuItem("Assets/作为广告平台参数")]
        static void Switch()
        {
            Load();
            ExcelHelper.DealExcel(Read);
        }

        public static void Read(DataSet set)
        {
            if (set.Tables.Count > 0)
            {
                Dictionary<string, string> datas = new Dictionary<string, string>();
                var rows = set.Tables[0].Rows;
                var line = rows[0].ItemArray;
                for (int i = 0; i < line.Length; i++)
                {
                    string key = rows[0].ItemArray[i].ToString();
                    string value = rows[1].ItemArray[i].ToString();
                    if (string.IsNullOrEmpty(key)) break;
                    datas.Add(key, value);
                }
                foreach (var item in setters.Values)
                {
                    item.SetData(datas);
                }
            }
        }
    }
}
