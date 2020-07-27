using Excel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using UnityEditor;
using UnityEngine;


public class ExcelHelper
{
    public static string GetSuffix(string path)
    {
        int x = path.LastIndexOf(".") + 1;
        return path.Substring(x, path.Length - x);
    }
    public static string GetFimeName(string path)
    {
        int x = path.LastIndexOf("/") + 1;
        return path.Substring(x, path.Length - x);
    }
    public static DataSet OpenExcel(string path)
    {
        string suffix = GetSuffix(path);
        FileStream stream = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.Read);
        IExcelDataReader excelReader = null;
        if (suffix.Equals("xlsx"))
        {
            excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
        }
        else if (suffix.Equals("xls"))
        {
            excelReader = ExcelReaderFactory.CreateBinaryReader(stream);
        }
        if (excelReader != null)
        {
           return excelReader.AsDataSet();
        }
        return null;
    }
    public static void DealExcel(Action<DataSet> reader)
    {
        var selects = Selection.GetFiltered<UnityEngine.Object>(SelectionMode.Assets);
        foreach (var item in selects)
        {
            string path = AssetDatabase.GetAssetPath(item);
            string suffix = GetSuffix(path);
            FileStream stream = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.Read);
            IExcelDataReader excelReader = null;
            if (suffix.Equals("xlsx"))
            {
                excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
            }
            else if (suffix.Equals("xls"))
            {
                excelReader = ExcelReaderFactory.CreateBinaryReader(stream);
            }
            if (excelReader != null)
            {
                var set = excelReader.AsDataSet();
                reader?.Invoke(set);
            }
        }
    }
    public static void DealExcel(params IDealExcel[] deal)
    {
        var selects = Selection.GetFiltered<UnityEngine.Object>(SelectionMode.Assets);
        foreach (var item in selects)
        {
            string path = AssetDatabase.GetAssetPath(item);
            string suffix = GetSuffix(path);
            FileStream stream = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.Read);
            IExcelDataReader excelReader = null;
            //Debug.Log(suffix);
            if (suffix.Equals("xlsx"))
            {
                excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
            }
            else if (suffix.Equals("xls"))
            {
                excelReader = ExcelReaderFactory.CreateBinaryReader(stream);
            }
            if (excelReader != null)
            {
                var set = excelReader.AsDataSet();
                for (int i = 0; i < deal.Length; i++)
                {
                    var dealer = deal[i];
                    var savePath = $"{Application.dataPath} /{dealer.floader}";
                    if (!Directory.Exists(savePath))
                    {
                        Directory.CreateDirectory(savePath);
                    }
                    File.WriteAllText($"{savePath}/{dealer.fileName}", dealer.Run(set.Tables[i]));
                }
                AssetDatabase.Refresh();
            }
        }
    }
}
