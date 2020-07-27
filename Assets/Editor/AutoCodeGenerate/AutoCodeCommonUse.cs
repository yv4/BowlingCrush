using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEditor;
using UnityEngine;

namespace AutoCode
{
    public class AutoCodeCommon
    {
        public string GenerateCodeStr;


        private List<GenerateCodeItem> m_ImgsItems = new List<GenerateCodeItem>();//图片相关数组
        private List<GenerateCodeItem> m_ButsItems = new List<GenerateCodeItem>();//按钮相关数组
        private List<GenerateCodeItem> m_DropItems = new List<GenerateCodeItem>();//下拉列表相关数组
        private List<GenerateCodeItem> m_InputItems = new List<GenerateCodeItem>();//输入InputField相关数组
        private List<GenerateCodeItem> m_Slides = new List<GenerateCodeItem>();//滑动Slide相关数据
        private List<GenerateCodeItem> m_TextItems = new List<GenerateCodeItem>();//输入文本相关数据

        #region 生成代码方法

        // <summary>
        /// 生成头文件
        /// </summary>
        /// <param name="sb"></param>
        public void GenerateHeadFile(StringBuilder sb)
        {

            sb.Append("using System.Collections;\n");
            sb.Append("using System.Collections.Generic;\n");
            sb.Append("using UnityEngine;\n");
            sb.Append("using UnityEngine.UI;\n\n");
        }

        /// <summary>
        /// 生成成员变量引用代码
        /// </summary>
        /// <param name="sb"></param>
        public void GenerateAwakeMemberRefrence(StringBuilder sb)
        {
            sb.Append("\n        #region 获取成员引用\n");

            #region 按钮相关

            sb.Append("\n        #region 按钮相关\n\n");
            foreach (GenerateCodeItem item in m_ButsItems)
            {
                sb.Append("        " + item.EditName);
                sb.Append("=BaseOption.FindChild<Button>(this.gameObject,\"");
                sb.Append(item.OriginName + "\");");
                sb.Append("\n");
            }
            sb.Append("\n        #endregion\n");

            #endregion

            #region 文本相关

            sb.Append("\n        #region 文本相关\n\n");
            foreach (GenerateCodeItem item in m_TextItems)
            {
                sb.Append("        " + item.EditName);
                sb.Append("=BaseOption.FindChild<Text>(this.gameObject,\"");
                sb.Append(item.OriginName + "\");");
                sb.Append("\n");
            }
            sb.Append("\n        #endregion\n");

            #endregion


            sb.Append("\n        #endregion\n");
        }

        /// <summary>
        /// 生成成员变量委托方法监听代码
        /// </summary>
        public void GenerateMemberDelegateMethodListen(StringBuilder sb)
        {
            sb.Append("\n        #region 添加成员委托方法监听\n");

            #region 按钮委托

            sb.Append("\n        #region 按钮相关\n\n");
            foreach (GenerateCodeItem item in m_ButsItems)
            {
                sb.Append("        BaseOption.AddButClickMethod(");
                sb.Append(item.EditName + "," + item.MethodName + ");");
                sb.Append("\n");

            }
            sb.Append("\n        #endregion\n");

            #endregion


            sb.Append("\n        #endregion\n");
        }

        /// <summary>
        /// 生成成员变量代码
        /// </summary>
        public void GenerateMemberElement(StringBuilder sb)
        {
            sb.Append("\n    #region 成员变量\n");

            #region 按钮相关

            if (m_ButsItems.Count > 0)
            {
                sb.Append("\n    #region 按钮相关\n\n");
                foreach (GenerateCodeItem item in m_ButsItems)
                {
                    sb.Append("    private ");
                    sb.Append("Button ");
                    sb.Append(item.EditName);
                    sb.Append(";\n");
                }
                sb.Append("\n    #endregion\n");
            }

            #endregion

            #region 文本相关

            if (m_TextItems.Count > 0)
            {
                sb.Append("\n    #region 文本相关\n\n");
                foreach (GenerateCodeItem item in m_TextItems)
                {
                    sb.Append("    private ");
                    sb.Append("Text ");
                    sb.Append(item.EditName);
                    sb.Append(";\n");
                }
                sb.Append("\n    #endregion\n");
            }

            #endregion

            #region 滑动相关

            if (m_Slides.Count > 0)
            {
                sb.Append("\n    #region 滑动相关\n\n");
                foreach (GenerateCodeItem item in m_Slides)
                {
                    sb.Append("    private ");
                    sb.Append("Slider ");
                    sb.Append(item.EditName);
                    sb.Append(";\n");
                }
                sb.Append("\n    #endregion\n\n");
            }

            #endregion

            #region 图片相关

            if (m_ImgsItems.Count>0)
            {
                sb.Append("\n    #region 图片相关\n\n");
                foreach (GenerateCodeItem item in m_ImgsItems)
                {
                    sb.Append("    private ");
                    sb.Append("Image ");
                    sb.Append(item.EditName);
                    sb.Append(";\n");
                }
                sb.Append("\n    #endregion\n\n");
            }

            #endregion

            sb.Append("    #endregion\n\n");
        }

        /// <summary>
        /// 生成成员方法代码
        /// </summary>
        public void GenerateMemberMethod(StringBuilder sb)
        {
            sb.Append("    #region 成员方法\n");



            sb.Append("\n    #endregion\n\n");
        }

        /// <summary>
        /// 生成生命周期相关代码
        /// </summary>
        /// <param name="sb"></param>
        public void GenerateLifeCode(StringBuilder sb)
        {
            sb.Append("    #region 生命周期\n");

            #region 生成Awake

            sb.Append("\n    protected override void GetMemberReference()\n");
            sb.Append("    {\n");

            this.GenerateAwakeMemberRefrence(sb);//生成获取成员变量引用代码
            this.GenerateMemberDelegateMethodListen(sb);//生成成员变量委托方法监听代码

            sb.Append("\n    }\n");

            #endregion

            #region 生成Start

            sb.Append("\n    protected override void OnInit()\n");
            sb.Append("{\n");
            sb.Append("}\n");

            #endregion

            #region 生成Update

            sb.Append("\n    private void Update()\n");
            sb.Append("{\n");
            sb.Append("}\n");

            #endregion

            #region 生成Destroy

            sb.Append("\n    protected override void DestroySelf()\n");
            sb.Append("{\n");
            sb.Append("}\n");

            #endregion

            sb.Append("\n    #endregion\n\n");
        }

        /// <summary>
        /// 生成委托方法代码
        /// </summary>
        /// <param name="sb"></param>
        public void GenerateDelegateMethod(StringBuilder sb)
        {
            sb.Append("    #region 委托方法\n");

            #region 按钮委托

            sb.Append("\n    #region 按钮相关\n");
            sb.Append("\n");
            foreach (GenerateCodeItem item in m_ButsItems)
            {
                if (item.EditName.Contains("m_"))
                {
                    sb.Append("    private ");
                }

                sb.Append("void ");
                sb.Append(item.MethodName);
                sb.Append("()");
                sb.Append("\n");
                sb.Append("    {\n\n");
                sb.Append("        Debug.Log(\"" + item.EditName + "\");\n\n");
                sb.Append("    }\n\n");

            }
            sb.Append("   #endregion\n\n");

            #endregion

            sb.Append("    #endregion\n\n");
        }

        #endregion

        /// <summary>
        /// 获取产生的项
        /// </summary>
        /// <param name="name"></param>
        private GenerateCodeItem GetGenerateItem(string name)
        {
            GenerateCodeItem itemData = new GenerateCodeItem();
            itemData.OriginName = name;

            if (!name.Contains("_"))
            {
                itemData.UIType = GenerateUIType.Error;
                return itemData;
            }

            string[] strs = BaseOption.SpliteStr('_', name);
            string updateName = "m_" + strs[0] + strs[1];
            itemData.EditName = updateName;


            string uiType = strs[1];

            switch (uiType)
            {
                //添加文本
                case "Text":
                    {
                        itemData.UIType = GenerateUIType.Text;
                    }
                    break;
                //添加按钮
                case "But":
                    {
                        itemData.UIType = GenerateUIType.Button;
                        string methodName = strs[0] + "ClickMethod";
                        itemData.MethodName = methodName;
                    }
                    break;
                //添加下拉
                case "Drop":
                    {
                        itemData.UIType = GenerateUIType.Dropdown;
                        string methodName = strs[0] + "DropValChangeMethod";
                        itemData.MethodName = methodName;
                    }
                    break;
                //添加输入
                case "InputField":
                    {
                        itemData.UIType = GenerateUIType.InputField;

                    }
                    break;
                //添加滑动
                case "Slider":
                    {
                        itemData.UIType = GenerateUIType.Slide;
                        string methodName = strs[0] + "SliderValChangeMethod";
                        itemData.MethodName = methodName;
                    }
                    break;
                //添加图片
                case "Img":
                    {
                        itemData.UIType = GenerateUIType.Img;
                    }
                    break;
                default:
                    break;
            }

            return itemData;
        }

        /// <summary>
        /// 获取所有需要生产的子项
        /// </summary>
        /// <param name="prefab"></param>
        public void GetChildPrefab(GameObject prefab)
        {
            for (int i = 0; i < prefab.transform.childCount; i++)
            {
                Transform childTran = prefab.transform.GetChild(i);
                string childTranName = childTran.name;

                GenerateCodeItem itemData = GetGenerateItem(childTranName);

                switch (itemData.UIType)
                {
                    case GenerateUIType.Error:
                        break;
                    case GenerateUIType.Button:
                        m_ButsItems.Add(itemData);
                        break;
                    case GenerateUIType.Text:
                        m_TextItems.Add(itemData);
                        break;
                    case GenerateUIType.InputField:
                        m_InputItems.Add(itemData);
                        break;
                    case GenerateUIType.Dropdown:
                        m_DropItems.Add(itemData);
                        break;
                    case GenerateUIType.Slide:
                        m_Slides.Add(itemData);
                        break;
                    case GenerateUIType.Img:
                        m_ImgsItems.Add(itemData);
                        break;
                    default:
                        break;
                }



                GetChildPrefab(childTran.gameObject);
            }

        }

        /// <summary>
        /// 生成类文件
        /// </summary>
        /// <param name="sb"></param>
        public void CreateClassFile(string fileName , string sb)
        {
            string path = Application.dataPath + "/Script/GenerateCode";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            string strVersionFilePath = path + "/" + fileName + ".cs";

            //如果版本文件存在 则删除
            BaseOption.CreateTextFile(strVersionFilePath, sb.ToString());
            AssetDatabase.Refresh();
        }

        /// <summary>
        /// 生成文本文件
        /// </summary>
        /// <param name="sb"></param>
        public void CreateTextFile(string fileName, string sb)
        {
            string path = Application.dataPath + "/Script/GenerateCode";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            string strVersionFilePath = path + "/" + fileName + ".txt";

            //如果版本文件存在 则删除
            BaseOption.CreateTextFile(strVersionFilePath, sb.ToString());
            AssetDatabase.Refresh();
        }
    }

    public struct GenerateCodeItem
    {
        public string OriginName;//原始名称
        public string EditName;//修改名称
        public string MethodName;//方法名称
        public GenerateUIType UIType;//挂载的组件类型
    }

    public enum GenerateUIType
    {
        Error,
        Button,
        Text,
        InputField,
        Dropdown,
        Slide,
        Img
    }
}

