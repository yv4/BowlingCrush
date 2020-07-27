using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

namespace MobiiGame.Sdk.Event
{
    public class Singleton<T> where T : class
    {
        private static T _instance;

        static Singleton()
        {
            return;
        }

        public static void Create()
        {
            if (_instance == null)
            {
                _instance = (T)Activator.CreateInstance(typeof(T), true);

            }
        }

        public static T Instance
        {
            get
            {
                if (_instance == null)
                {
                    Create();
                }
                return _instance;
            }
        }

        public static void Destroy()
        {

            _instance = null;

            return;
        }

    }
}