using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MobiiGame.Sdk.Base
{
    public class MonoSingleton<T> : MonoBehaviour where T : MonoBehaviour
    {
        protected static bool isQuit = false;
        private static T instance;


        public static T Instance
        {
            get
            {
                if (instance == null)
                {
                    if (isQuit)
                    {
                        return null;
                    }
                    instance = FindObjectOfType<T>();
                    if (instance == null)
                    {
                        GameObject obj = new GameObject();
                        obj.name = typeof(T).Name;
                        instance = obj.AddComponent<T>();
                    }
                }
                return instance;
            }
        }



        public static T GetInstance()
        {
            return Instance;
        }

        protected virtual void Awake()
        {
            if (isQuit)
            {
                return;
            }
            if (instance == null)
            {
                gameObject.GetOrAddComponent<DonotDestroyOnLoad>();
                //DontDestroyOnLoad(gameObject);
                instance = this as T;
            }
            else if (instance != this)
            {
#if UNITY_EDITOR
                DestroyImmediate(gameObject);
#else
            Destroy(gameObject);
#endif
            }
        }

        private void OnApplicationQuit()
        {
            isQuit = true;
        }
    }
}