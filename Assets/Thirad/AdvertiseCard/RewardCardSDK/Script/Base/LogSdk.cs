using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

namespace MobiiGame.Sdk.Base
{
    public static class LogSdk
    {
        private static bool showLog;
        public static InputField logIf = null;

        public static bool IsLogOn
        {
            get
            {
                return showLog;
            }
            set
            {
                showLog = value;
            }
        }

        public static void Log(object msg)
        {
            if (showLog)
            {
                Debug.Log(msg);
            }
        }

        public static void Log(object msg, UnityEngine.Object context)
        {
            if (showLog)
            {
                Debug.Log(msg, context);
            }
        }

        public static void LogError(object msg)
        {
            if (showLog)
            {
                Debug.LogError(msg);
                if (logIf)
                {
                    if (msg.ToString().Length>500)
                    {
                        msg = msg.ToString().Substring(0, 100) + "......";
                    }
                    logIf.text += msg + "\r\n";
                }
            }
        }

        public static void LogError(object msg, UnityEngine.Object context)
        {
            if (showLog)
            {
                Debug.LogError(msg, context);
            }
        }

        public static void LogWarning(object msg)
        {
            if (showLog)
            {
                Debug.LogWarning(msg);
            }
        }

        public static void LogException(Exception msg)
        {
            if (showLog)
            {
                Debug.LogException(msg);
            }
        }
    }
}