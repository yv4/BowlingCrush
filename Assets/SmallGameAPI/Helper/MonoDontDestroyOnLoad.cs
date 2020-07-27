using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace MiniGameSDK.Helper
{
    public class MonoDontDestroyOnLoad : MonoBehaviour
    {
        private void Awake()
        {
            DontDestroyOnLoad(gameObject);
        }
    }
}

