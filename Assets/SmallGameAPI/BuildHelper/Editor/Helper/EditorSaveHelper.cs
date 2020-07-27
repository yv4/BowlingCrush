using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MiniGameSDK
{
    public static class EditorSaveHelper
    {
        public static void SaveSceneObject(UnityEngine.Object obj)
        {
            EditorUtility.SetDirty(obj);
            EditorSceneManager.SaveScene(SceneManager.GetActiveScene(), "", false);

        }
        public static void SaveAssets(UnityEngine.Object obj)
        {
            EditorUtility.SetDirty(obj);
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
        }
    }
}
