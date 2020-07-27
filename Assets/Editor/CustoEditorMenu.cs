using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using AutoCode;

public class CustoEditorMenu 
{
    private AutoCodeGenerate m_AutoCodeGenerate;

    [MenuItem("Assets/右键生成代码/生成UIBase")]
    public static void CreateCoading()
    {
        var selects = Selection.GetFiltered<UnityEngine.Object>(SelectionMode.Assets);
        foreach (var item in selects)
        {
            string path = AssetDatabase.GetAssetPath(item);
            GameObject createCodePrefab = AssetDatabase.LoadAssetAtPath(path, typeof(GameObject)) as GameObject;
            AutoCodeGenerate generate = new AutoCodeGenerate();
            generate.GetNeedCreateChild(createCodePrefab);
            string code = generate.GenerateUIViewBaseCode(item.name);
            generate.CreateFile(item.name, code);
        }
    }

    [MenuItem("Assets/生成障碍物json文件")]
    public static void CreateObstaclesJson()
    {
        var selects = Selection.GetFiltered<UnityEngine.Object>(SelectionMode.Assets);
        foreach (var item in selects)
        {
            string path = AssetDatabase.GetAssetPath(item);
            GameObject parentPrefab = AssetDatabase.LoadAssetAtPath(path, typeof(GameObject)) as GameObject;
            GetBottles(parentPrefab);
        }
    }

    /// <summary>
    /// 获取所有需要生产的子项
    /// </summary>
    /// <param name="prefab"></param>
    private static void GetBottles(GameObject prefab)
    {
        List<string[]> bottlePos = new List<string[]>();
        for (int i = 0; i < prefab.transform.childCount; i++)
        {
            Transform childTran = prefab.transform.GetChild(i);
            for (int j=0;j<childTran.childCount;j++)
            {
                if (childTran.name.Contains(ChunkType.BottleChunk.ToString()))
                {
                    Transform bottle = childTran.transform.GetChild(j);
                    string[] pos = new string[] { bottle.transform.localPosition.x.ToString(), bottle.localPosition.y.ToString(), bottle.position.z.ToString(), ChunkType.BottleChunk.ToString() };
                    bottlePos.Add(pos);
                }

                if (childTran.name.Contains(ChunkType.StaticObstacleChunk.ToString()))
                {
                    Transform obstacle = childTran.transform.GetChild(j);
                    string[] pos = new string[] { obstacle.transform.localPosition.x.ToString(), obstacle.localPosition.y.ToString(), obstacle.position.z.ToString(), ChunkType.StaticObstacleChunk.ToString() };
                    bottlePos.Add(pos);
                }

                if (childTran.name.Contains(ChunkType.MoveObstacleChunk.ToString()))
                {
                    Transform obstacle = childTran.transform.GetChild(j);
                    string[] pos = new string[] { obstacle.transform.localPosition.x.ToString(), obstacle.localPosition.y.ToString(), childTran.localPosition.z.ToString(), ChunkType.MoveObstacleChunk.ToString() };
                    bottlePos.Add(pos);
                }

                if (childTran.name.Contains(ChunkType.RotateObstacleChunk.ToString()))
                {
                    Transform obstacle = childTran.transform.GetChild(j);
                    string[] pos = new string[] { obstacle.transform.localPosition.x.ToString(), obstacle.localPosition.y.ToString(), obstacle.position.z.ToString(), ChunkType.RotateObstacleChunk.ToString() };
                    bottlePos.Add(pos);
                }

                if (childTran.name.Contains(ChunkType.DollorChunk.ToString()))
                {
                    Transform obstacle = childTran.transform.GetChild(j);
                    string[] pos = new string[] { obstacle.transform.localPosition.x.ToString(), obstacle.localPosition.y.ToString(), childTran.localPosition.z.ToString(), ChunkType.DollorChunk.ToString() };
                    bottlePos.Add(pos);
                }

                if (childTran.name.Contains(ChunkType.FourChunk.ToString()))
                {
                    Transform obstacle = childTran.transform.GetChild(j);
                    string[] pos = new string[] { obstacle.transform.localPosition.x.ToString(), obstacle.localPosition.y.ToString(), childTran.localPosition.z.ToString(), ChunkType.FourChunk.ToString() };
                    bottlePos.Add(pos);
                }

                if (childTran.name.Contains(ChunkType.TenChunk.ToString()))
                {
                    Transform obstacle = childTran.transform.GetChild(j);
                    string[] pos = new string[] { obstacle.transform.localPosition.x.ToString(), obstacle.localPosition.y.ToString(), childTran.localPosition.z.ToString(), ChunkType.TenChunk.ToString() };
                    bottlePos.Add(pos);
                }

                if (childTran.name.Contains(ChunkType.DozenChunk.ToString()))
                {
                    Transform obstacle = childTran.transform.GetChild(j);
                    string[] pos = new string[] { obstacle.transform.localPosition.x.ToString(), obstacle.localPosition.y.ToString(), childTran.localPosition.z.ToString(), ChunkType.DozenChunk.ToString() };
                    bottlePos.Add(pos);
                }

                if (childTran.name.Contains(ChunkType.DownObstacleChunk.ToString()))
                {
                    Transform obstacle = childTran.transform.GetChild(j);
                    string[] pos = new string[] { obstacle.transform.localPosition.x.ToString(), obstacle.localPosition.y.ToString(), childTran.localPosition.z.ToString(), ChunkType.DownObstacleChunk.ToString() };
                    bottlePos.Add(pos);
                }
            }
        }

        string jsonStr = LitJson.JsonMapper.ToJson(bottlePos);
        string path = Application.dataPath + "/Resources/GameRun/JsonData";
        if (prefab.name.Contains("Level"))
        {
            path += "/Level";
        }
        else if (prefab.name.Contains("Dollor"))
        {
            path += "/Dollor";
        }

        string finalPath = path + "/" + prefab.name + ".txt";

        BaseOption.CreateTextFile(finalPath, jsonStr);
        AssetDatabase.Refresh();

    }
}
