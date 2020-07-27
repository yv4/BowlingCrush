using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public static class LocalDataHelper  {

    /// <summary>
    /// 读取本地文件到byte数组
    /// </summary>
    /// <param name="path"></param>
    /// <returns></returns>
    public static byte[] GetBuffer(string path)
    {
        byte[] buffer = null;

#if UNITY_ANDROID

        try
        {
            WWW www = new WWW(path);     //格式必须是"ANSI"，不能是"UTF-8"

            if (www.error != null)
            {
                Debug.LogError("error : " + path);
                return null;         //读取文件出错
            }

            while (!www.isDone)
            {

            }

            buffer = www.bytes;
        }
        catch (System.Exception)
        {
            Debug.Log("错误");
            throw;
        }
      

#endif

#if UNITY_IPHONE


        try
        {
            WWW www = new WWW(path);     //格式必须是"ANSI"，不能是"UTF-8"

            if (www.error != null)
            {
                Debug.LogError("error : " + path);
                return null;         //读取文件出错
            }

            while (!www.isDone)
            {

            }

            buffer = www.bytes;
        }
        catch (System.Exception)
        {
            Debug.Log("错误");
            throw;
        }

#endif

#if UNITY_STANDALONE_WIN
        using (FileStream fs = new FileStream(path, FileMode.Open))
        {
            buffer = new byte[fs.Length];
            fs.Read(buffer, 0, buffer.Length);
        }
#endif



        return buffer;
    }
}
