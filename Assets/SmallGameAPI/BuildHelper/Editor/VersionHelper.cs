using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using UnityEditor;
using UnityEditor.Callbacks;
using UnityEngine;
#if UNITY_ANDROID
[InitializeOnLoad]
public static class VersionHelper
{
    const string AutoChangeVersionCodePath = "VersionHelper/AutoChangeVersionCode";
    const string UseSuffix = "VersionHelper/Use Version Suffix";
    static bool _isAutoChangeVersionCode
    {
        get
        {
            return Menu.GetChecked(AutoChangeVersionCodePath);
        }
        set
        {
            Menu.SetChecked(AutoChangeVersionCodePath, value);
        }
    }
    static bool _isUseSuffix
    {
        get
        {
            return Menu.GetChecked(UseSuffix);
        }
        set
        {
            Menu.SetChecked(UseSuffix, value);
        }
    }
    static VersionHelper()
    {
        Wait();
    }
    static async void Wait()
    {
        await Task.Delay(100);
        _isAutoChangeVersionCode = EditorPrefs.GetBool("VersionHelper.isAutoChangeVersionCode", true);
        _isUseSuffix = EditorPrefs.GetBool("VersionHelper.isUseSuffix", true);
    }
    [MenuItem(AutoChangeVersionCodePath)]
    static void IsAutoChangeVersionCode()
    {
        _isAutoChangeVersionCode = !_isAutoChangeVersionCode;
        EditorPrefs.SetBool("VersionHelper.isAutoChangeVersionCode", _isAutoChangeVersionCode);
    }
    [MenuItem(UseSuffix)]
    static void isUseSuffix()
    {
        _isUseSuffix = !_isUseSuffix;
        EditorPrefs.SetBool("VersionHelper.isUseSuffix", _isUseSuffix);
        //ChangeCode(BuildTarget.Android, "Assets/1.txt");
        //AssetDatabase.Refresh();
    }
    [PostProcessBuild(1)]
    static void ChangeCode(BuildTarget build, string path)
    {
        if (build == BuildTarget.Android)
        {
            if (_isUseSuffix)
            {
                string name = Path.GetFileNameWithoutExtension(path);
                string sfxName = $"{name}-v{PlayerSettings.bundleVersion}-c{PlayerSettings.Android.bundleVersionCode}{Path.GetExtension(path)}";
                string movePath = Path.Combine(Path.GetDirectoryName(path), sfxName);
                File.Move(path, movePath);
            }
            if (_isAutoChangeVersionCode)
            {
                PlayerSettings.Android.bundleVersionCode++;
            }
        }
    }
}
#endif
