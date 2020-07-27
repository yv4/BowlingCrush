using LitJson;
//using MiniGameSDK;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using MobiiGame.Sdk.Gift;
using MiniGameSDK;
using System.Net;
using UnityEngine.Networking;

public struct BaseOptionRayRet
{
    public bool isSuccess { get; set; }
    public GameObject ColliderObj { get; set; }
    public Vector3 ColliderPos { get; set; }
}

public static class BaseOption
{
    //本地数据路径
    private static string GetLocalDataPath { get { return Application.persistentDataPath; } }

    /// <summary>
    /// 展示激励卡
    /// </summary>
    public static void ShowCardDialog()
    {
        GiftCardDialog.ShowCardDialog();
    }

    /// <summary>
    /// 获取本地文件路径
    /// </summary>
    /// <param name="fileName"></param>
    /// <returns></returns>
    public static string GetLocalFilePath(string fileName)
    {
        StringBuilder sb = new StringBuilder(GetLocalDataPath);
        sb.Append("//");
        sb.Append(fileName);
        return sb.ToString();
    }

    /// <summary>
    /// 获取当前日期时分秒
    /// </summary>
    /// <returns></returns>
    public static string GetCurrentDate()
    {
        return DateTime.Now.ToString("hh:mm:ss");        // 2008-09-04
    }

    /// <summary>
    /// 根据名称返回子对象GameObject
    /// </summary>
    /// <param name="parent"></param>
    /// <param name="childName"></param>
    /// <returns></returns>
    public static GameObject FindChild(GameObject parent, string childName)
    {
        if (parent==null)
        {
            Debug.Log("找不到" + childName + "的父对象");
        }
        Transform[] children = parent.GetComponentsInChildren<Transform>(true);
        bool isFinded = false;
        Transform child = null;
        foreach (Transform t in children)
        {
            if (t.name == childName)
            {
                if (isFinded)
                {
                    Debug.Log("在游戏物体下存在不止一个:" + childName);
                }
                isFinded = true;
                child = t;
            }
        }

        if (child!=null)
        {
            return child.gameObject;
        }
        else
        {
            return null;
        }
       
    }

    /// <summary>
    /// 返回UGUI画布
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    public static GameObject GetCanvas(string name = "Canvas")
    {
        return GameObject.Find(name);
    }


    /// <summary>
    /// 根据名称返回子对象上的相应控件
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="parent"></param>
    /// <param name="childName"></param>
    /// <returns></returns>
    public static T FindChild<T>(GameObject parent, string childName)
    {
        GameObject uiGO = BaseOption.FindChild(parent, childName);
        if (uiGO == null)
        {
            Debug.Log("在游戏物体" + parent + "下面差找不到" + childName);
            return default(T);
        }
        return uiGO.GetComponent<T>();
    }

    /// <summary>
    /// 从参数相机发送射线到相应位置 返回V3坐标
    /// </summary>
    /// <param name="camera"></param>
    /// <param name="pos"></param>
    /// <returns></returns>
    public static BaseOptionRayRet GetRay(Camera camera, Vector3 pos, int enableLayer)
    {
        BaseOptionRayRet ret = new BaseOptionRayRet();

        Ray ray = camera.ScreenPointToRay(pos);
        RaycastHit hitInfo;
        if (!EventSystem.current.IsPointerOverGameObject())
        {
           
            bool isCollider = Physics.Raycast(ray,out hitInfo, Mathf.Infinity,enableLayer);
            if (isCollider)
            {
                ret.isSuccess = isCollider;
                ret.ColliderPos = hitInfo.point;
                ret.ColliderObj = hitInfo.collider.gameObject;
            }
            
        }

        return ret;
    }

    /// <summary>
    /// 添加按钮点击委托
    /// </summary>
    /// <param name="but"></param>
    /// <param name="butClickDel"></param>
    public static void AddButClickMethod(Button but,Action butClickDel)
    {
        but.onClick.AddListener(() => {
            butClickDel();
        });
    }

    /// <summary>
    /// 获取到一个位置加上距离的点
    /// </summary>
    /// <param name="pos"></param>
    /// <param name="ori"></param>
    /// <param name="distance"></param>
    /// <returns></returns>
    public static Vector3 GetPointAddDistance(Vector3 currPos,Vector3 toPos, float distance)
    {
        float twoPointDistance = Vector3.Distance(currPos, toPos);
        Vector3 dir = toPos - currPos;
        dir.Normalize();

        Vector3 retPos = currPos + dir*(twoPointDistance-distance);

        return retPos;
    }

    /// <summary>
    /// 获取一个圆上的随机点
    /// </summary>
    /// <param name="pos"></param>
    /// <param name="distance"></param>
    /// <returns></returns>
    public static Vector3 CircleRandomPos(Vector3 pos, float distance)
    {
        //1.定义一个向量
        Vector3 v = new Vector3(0, 0, 1); //z轴朝前的

        //2.让向量旋转
        v = Quaternion.Euler(0, UnityEngine.Random.Range(0, 360f), 0) * v;

        //3.向量 * 距离(半径) = 坐标点
        Vector3 target = v * distance * UnityEngine.Random.Range(0.8f, 1f);

        //4.计算出来的 围绕主角的 随机坐标点
        return pos + target;

        /* 上下两个方法结果一样 上边为教程的 底下为自己写的
        Vector3 ori = new Vector3(1, 0, 1f);
        //向量旋转
        float rotateDegree = Random.Range(0, 360f);

        if (rotateDegree < 15)
        {
            rotateDegree = 15;
        }

        ori = Quaternion.Euler(0, rotateDegree, 0) * ori;
        ori.Normalize();

        //向量*距离获取坐标点
        Vector3 target = ori * distance;

        target += pos;

        return target;
        */
    }

    /// <summary>
    /// 获取一个圆上固定角度的多个随机点
    /// </summary>
    public static Vector3[] CircleRandomPos(Vector3 pos, float distance, int count)
    {
        Vector3 ori = new Vector3(1, 0, 1);
        Vector3[] retPos = new Vector3[count];
        float rotateDegree = 0;
        float addConstandDegree = 360 / count;

        for (int i = 0; i < count; i++)
        {
            rotateDegree = rotateDegree + i * addConstandDegree;
            ori = Quaternion.Euler(0, rotateDegree, 0) * ori;

            //向量*距离获取坐标点
            Vector3 target = ori * distance;

            target += pos;

            retPos[i] = target;
        }

        return retPos;
    }

    /// <summary>
    /// 清楚参数Transform下的子对象
    /// </summary>
    /// <param name="parent"></param>
    public static void ClearChildObject(Transform parent)
    {
        foreach (Transform child in parent)
        {
            GameObject.Destroy(child.gameObject);
        }
    }

    /// <summary>
    /// 分割字符串
    /// </summary>
    /// <param name="val"></param>
    /// <param name="str"></param>
    /// <returns></returns>
    public static string[] SpliteStr(char val,string str)
    {
       return str.Split(val);
    }

    /// <summary>
    /// 通过射线获取地面y坐标
    /// </summary>
    /// <returns></returns>
    public static float GetGroundYWithRay(Vector3 pos,string layerName="")
    {
        RaycastHit hitInfo;
        if (layerName.Equals(""))
        {
            if (Physics.Raycast(pos, Vector3.down, out hitInfo, Mathf.Infinity))
            {
                return hitInfo.point.y;
            }
            else
            {
                return -1;
            }
        }
        else
        {
            if (Physics.Raycast(pos, Vector3.down, out hitInfo, Mathf.Infinity, LayerMask.NameToLayer(layerName)))
            {
                return hitInfo.point.y;
            }
            else
            {
                return -1;
            }
        }
    }

    /// <summary>
    /// 读取本地文本文件内容
    /// </summary>
    public static string ReadLocalTxtContent(string path)
    {
        //本地路径
        var fileAddress = path;
        FileInfo fInfo0 = new FileInfo(fileAddress);
        string s = "";
        if (fInfo0.Exists)
        {
            using (StreamReader r = new StreamReader(fileAddress))
            {
                //StreamReader默认的是UTF8的不需要转格式了，因为有些中文字符的需要有些是要转的，下面是转成String代码
                //byte[] data = new byte[1024];
                // data = Encoding.UTF8.GetBytes(r.ReadToEnd());
                // s = Encoding.UTF8.GetString(data, 0, data.Length);
                s = r.ReadToEnd();
                r.Close();
            }
            
        }

        return s;
    }

    /// <summary>
    /// 将Json字串转为相应类型
    /// </summary>
    /// <returns></returns>
    public static T JsonToObj<T>(string json)
    {
        T data = JsonMapper.ToObject<T>(json);

        return data;
    }

    /// <summary>
    /// 将相应类型转为Json字符串
    /// </summary>
    /// <returns></returns>
    public static string ObjToJson<T>(T jsonobj)
    {
        string jsonStr = JsonMapper.ToJson(jsonobj);

        return jsonStr;
    }

    /// <summary>
    /// 从本地读取Json文件
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    public static string LoadJsonTxtFromLocal(string name)
    {
        string filePath = BaseOption.GetLocalFilePath(name);
        Debug.Log(filePath);
        string jsonTxt;
        FileInfo fInfo = new FileInfo(filePath);
        if (fInfo.Exists)
        {
            using (FileStream fsSource = new FileStream(filePath,
             FileMode.Open, FileAccess.Read))
            {
                // Read the source file into a byte array.  
                byte[] bytes = new byte[fsSource.Length];
                int numBytesToRead = (int)fsSource.Length;
                int numBytesRead = 0;
                while (numBytesToRead > 0)
                {
                    int n = fsSource.Read(bytes, numBytesRead, numBytesToRead);


                    if (n == 0)
                        break;
                    numBytesRead += n;
                    numBytesToRead -= n;
                }
                numBytesToRead = bytes.Length;

                jsonTxt = UTF8Encoding.UTF8.GetString(bytes);
            }
        }
        else
        {
            return null;
        }
       

        return jsonTxt;
    }

    /// <summary>
    /// 存储Json文件到本地
    /// </summary>
    /// <param name="name"></param>
    /// <param name="json"></param>
    public static void SaveJsonTxtToLocal(string name,string json)
    {
        string filePath = BaseOption.GetLocalFilePath(name);
        StreamWriter sw;
        FileInfo t = new FileInfo(filePath);
        if (!t.Exists)
        {
            //如果文件不存在则创建
            sw = t.CreateText();
        }
        else
        {
           
            sw =new StreamWriter(filePath);
        }

        //以行的形式写入信息
        sw.WriteLine(json);

        //关闭流
        sw.Close();
        //销毁流
        sw.Dispose();
    }

    public static string Md5(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            return null;
        }
        System.Security.Cryptography.MD5 md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
        byte[] bytResult = md5.ComputeHash(System.Text.Encoding.Default.GetBytes(value));
        string strResult = BitConverter.ToString(bytResult);
        strResult = strResult.Replace("-", "");
        return strResult;
    }

    /// <summary>
    /// 获取文件的MD5
    /// </summary>
    /// <param name="filePath"></param>
    /// <returns></returns>
    public static string GetFileMD5(string filePath)
    {
        if (string.IsNullOrEmpty(filePath) || !File.Exists(filePath))
        {
            return null;
        }
        try
        {
            FileStream file = new FileStream(filePath, FileMode.Open);
            System.Security.Cryptography.MD5 md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] bytResult = md5.ComputeHash(file);
            string strResult = BitConverter.ToString(bytResult);
            strResult = strResult.Replace("-", "");
            return strResult;
        }
        catch
        {
            return null;
        }
    }

    /// <summary>
    /// 删除文件
    /// </summary>
    /// <param name="filePath"></param>
    public static void DeleteFile(string filePath)
    {
        if (File.Exists(filePath))
        {
            File.Delete(filePath);
        }
    }

    /// <summary>
    /// 创建文本文件
    /// </summary>
    /// <param name="filePath"></param>
    /// <param name="content"></param>
    public static void CreateTextFile(string filePath, string content)
    {

        DeleteFile(filePath);

        try
        {
            using (FileStream fs = File.Open(filePath, FileMode.OpenOrCreate))
            {

                using (StreamWriter sw = new StreamWriter(fs))
                {

                    sw.Write(content.ToString());

                    sw.Close();

                }


                fs.Close();

            }
        }
        catch (Exception e)
        {
            Debug.Log("打开错误");
        }

    }

    /// <summary>
    /// 拷贝文件夹
    /// </summary>
    /// <param name="sourceDirName"></param>
    /// <param name="destDirName"></param>
    public static void CopyDirectory(string sourceDirName, string destDirName)
    {
        try
        {
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
                File.SetAttributes(destDirName, File.GetAttributes(sourceDirName));

            }

            if (destDirName[destDirName.Length - 1] != Path.DirectorySeparatorChar)
                destDirName = destDirName + Path.DirectorySeparatorChar;

            string[] files = Directory.GetFiles(sourceDirName);
            foreach (string file in files)
            {
                if (File.Exists(destDirName + Path.GetFileName(file)))
                    continue;
                FileInfo fileInfo = new FileInfo(file);
                if (fileInfo.Extension.Equals(".meta", StringComparison.CurrentCultureIgnoreCase))
                    continue;

                File.Copy(file, destDirName + Path.GetFileName(file), true);
                File.SetAttributes(destDirName + Path.GetFileName(file), FileAttributes.Normal);
            }

            string[] dirs = Directory.GetDirectories(sourceDirName);
            foreach (string dir in dirs)
            {
                CopyDirectory(dir, destDirName + Path.GetFileName(dir));
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    /// <summary>
    /// 清除所有子物体下的元素
    /// </summary>
    /// <param name="parentTran"></param>
    public static void RemoveAllChildElemet(Transform parentTran)
    {
        for (int i = 0; i < parentTran.childCount; i++)
        {
            GameObject.Destroy(parentTran.GetChild(i).gameObject);
        }

    }

    /// <summary>
    /// 遍历计算所有顶点间距离最小的值与最大的值
    /// </summary>
    /// <param name="min"></param>
    /// <param name="max"></param>
    /// <param name="direction">方向 0为x 其他值为y</param>
    public static void CalculateMinMax(out float min, out float max, Transform obj,int direction)
    {
        Vector3[] verticles = obj.GetComponent<MeshFilter>().mesh.vertices;
        if (direction==0)
        {
            min = max = verticles[0].x;
        }
        else
        {
            min = max = verticles[0].y;
        }
       
        for (int i = 1; i < verticles.Length; i++)
        {
            float value = 0;
            if (direction==0)
            {
               value=verticles[i].x;
            }
            else
            {
                value = verticles[i].y;
            }

            if (value < min)
            {
                min = value;
            }

            if (value > max)
            {
                max = value;
            }
        }
    }

    /// <summary>
    /// 检测是否UI穿透
    /// </summary>
    /// <param name="eventSystem"></param>
    /// <param name="graphicRaycaster"></param>
    /// <returns></returns>
    public static bool CheckGuiRaycastObjects(string canvasPath,string eventSystemPath,string UIIgnoreTag)
    {
        GraphicRaycaster graphicRaycaster = GameObject.Find(canvasPath).GetComponent<GraphicRaycaster>();
        EventSystem eventSystem = GameObject.Find(eventSystemPath).GetComponent<EventSystem>();

        PointerEventData eventData = new PointerEventData(eventSystem);
        eventData.pressPosition = Input.mousePosition;
        eventData.position = Input.mousePosition;

        List<RaycastResult> list = new List<RaycastResult>();
        graphicRaycaster.GetComponent<GraphicRaycaster>().Raycast(eventData, list);
        if (list.Count==1)
        {
            RaycastResult result = list[0];
            if (result.gameObject.tag.Equals(UIIgnoreTag))
            {
                return false;
            }
        }
        return list.Count > 0;
    }

    /// <summary>
    /// 检测输入
    /// </summary>
    /// <param name="userName"></param>
    /// <param name="password"></param>
    /// <returns></returns>
    public static bool CheckAccountInput(string userName, string password,out string message)
    {
       
        if (userName.Equals("") && password.Equals(""))
        {
            string msg = "用户名与密码不可为空";
            message = msg;
            return false;
        }

        if (userName.Equals(""))
        {
            string msg = "用户名不可为空";
            message = msg;
            return false;
        }

        if (password.Equals(""))
        {
            string msg = "密码不可为空";
            message = msg;
            return false;
        }

        message = "成功";
        return true;
    }

    /// <summary>
    /// 展示激励广告
    /// </summary>
    /// <param name="retDelegate"></param>
    public static void ShowAdvertiseBounce(Action<bool>retDelegate)
    {
        retDelegate(true);
        //IRewardAdAPI reward = APIProvider.GetAPI<IRewardAdAPI>();
        //reward.AutoShow((isEnd) =>
        //{

        //    if (isEnd)
        //    {
        //        retDelegate(isEnd);
        //    }
        //});
    }

    /// <summary>
    /// 展示插屏广告
    /// </summary>
    public static void ShowInsertAdvertise()
    {
        IInterstitialAdAPI reward = APIProvider.GetAPI<IInterstitialAdAPI>();
        reward.Show();

    }

    /// <summary>
    /// 友盟打点记录
    /// </summary>
    public static void SetRecord(string key,Dictionary<string,string>value=null)
    {
        IAnalyzeEvent analy = APIProvider.GetAPI<IAnalyzeEvent>();

        if (value == null)
        {
            analy.SetEvent(key);
        }
        else
        {
            analy.SetEvent(key, value);
        }

    }
       

    /// <summary>
    /// 转换模型坐标为UI坐标
    /// </summary>
    public static Vector2 ChangeModelPosToUIPos(Vector3 modelPos,string canvasName)
    {
        Vector3 screenPos = Camera.main.WorldToScreenPoint(modelPos);
        Canvas gameCanvas = BaseOption.GetCanvas(canvasName).GetComponent<Canvas>();
        Vector2 uiPos = Vector2.zero;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(gameCanvas.transform as RectTransform, screenPos, gameCanvas.worldCamera, out uiPos);
        return uiPos;
    }


}
