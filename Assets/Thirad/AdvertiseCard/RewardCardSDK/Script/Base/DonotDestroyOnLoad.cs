using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MobiiGame.Sdk.Base
{
    public class DonotDestroyOnLoad : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            DontDestroyOnLoad(gameObject);
        }
    }
}