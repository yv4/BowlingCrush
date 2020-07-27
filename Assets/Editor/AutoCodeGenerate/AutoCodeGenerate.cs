using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using AutoCode;

public class AutoCodeGenerate
{
    private AutoCodeCommon m_Common = new AutoCodeCommon();

    // <summary>
    /// 生成Behaviour代码String
    /// </summary>
    /// <returns></returns>
    public string GenerateUIViewBaseCode(string fileName)
    {
        StringBuilder sb = new StringBuilder();

        m_Common.GenerateHeadFile(sb);//生成头文件

        string generateClassName = fileName;

        if (generateClassName != null && !generateClassName.Equals(""))
        {
            sb.Append("public class ");
            sb.Append(generateClassName);
            sb.Append(" : UIBase\n");

        }
        else
        {
            sb.Append("public class GenerateCodeMgrTest : AbstractRoleAction\n");
        }

        sb.Append("{\n");

        m_Common.GenerateMemberElement(sb);//生成成员变量
        m_Common.GenerateLifeCode(sb);//生成生命周期
        m_Common.GenerateMemberMethod(sb);//生成成员方法
        m_Common.GenerateDelegateMethod(sb);//生成委托方法

        sb.Append("}");

        return sb.ToString();
    }
    
    /// <summary>
    /// 获取所有需要生成的子项
    /// </summary>
    /// <param name="obj"></param>
    public void GetNeedCreateChild(GameObject obj)
    {
        m_Common.GetChildPrefab(obj);
    }

    /// <summary>
    /// 创建文件
    /// </summary>
    /// <param name="sb"></param>
    public void CreateFile(string fileName, string sb)
    {
        if (fileName.Contains("txt"))
        {
            m_Common.CreateTextFile(fileName, sb);
        }
        else
        {
            m_Common.CreateClassFile(fileName, sb);
        }
       
    }

}
