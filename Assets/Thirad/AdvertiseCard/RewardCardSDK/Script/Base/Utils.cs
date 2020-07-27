using UnityEngine;

namespace MobiiGame.Sdk.Base
{
    public static class Utils
    {
        public static T GetOrAddComponent<T>(this GameObject gameObject) where T : Component
        {
            T t = gameObject.GetComponent<T>();
            if (t == null)
            {
                t = gameObject.AddComponent<T>();
            }
            return t;
        }

        public static T GetOrAddComponent<T>(this Transform transform) where T : Component
        {
            return transform.gameObject.GetOrAddComponent<T>();
        }

        public static void SetSelfActive(this GameObject go, bool active)
        {
            if (go.activeSelf != active)
            {
                go.SetActive(active);
            }
        }
    }
}