using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
namespace MiniGameSDK
{
    class AdmboIdAsset : ScriptableObject
    {
        public static string assetName = "MiniGameSDK_AdmboIdAsset";
        public static string assetPath = $"Assets/Editor";
        public string _id;
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
                Save();
            }
        }
        static AdmboIdAsset _inst;
        static void tryInit()
        {
            if (_inst == null)
            {
                string[] guids = AssetDatabase.FindAssets(assetName);
                if (guids.Length > 0)
                {
                    _inst = AssetDatabase.LoadAssetAtPath<AdmboIdAsset>(AssetDatabase.GUIDToAssetPath(guids[0]));
                }
                else
                {
                    _inst = CreateInstance<AdmboIdAsset>();
                    AssetDatabase.CreateAsset(_inst, $"{assetPath}/{assetName}.asset");
                }
            }
        }
        public static AdmboIdAsset Inst
        {
            get
            {
                tryInit();
                return _inst;
            }
        }
        public void Save()
        {
            EditorUtility.SetDirty(this);
            AssetDatabase.SaveAssets();
        }
    }
}

