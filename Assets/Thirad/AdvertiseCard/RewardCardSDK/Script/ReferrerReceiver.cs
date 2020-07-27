using System;
using UnityEngine;

public static class ReferrerReceiver
{
    private class AndroidCallbackHandler<T> : AndroidJavaProxy
    {
        private readonly Action<T> _resultHandler;

        public AndroidCallbackHandler(Action<T> resultHandler) : base("com.reward.card.sdk.unityrewardlibrary.StringObjectCallback")
        {
            _resultHandler = resultHandler;
        }

        public void onResult(T result)
        {
            if (_resultHandler != null)
            {
                _resultHandler.Invoke(result);
            }
        }
    }

    public static AndroidJavaProxy ActionToJavaObject<T>(Action<T> action)
    {
        return new AndroidCallbackHandler<T>(action);
    }

    public static void getInstallReferrer(Action<String> callback, bool isTest = false)
    {
#if UNITY_ANDROID && !UNITY_EDITOR
        AndroidJavaObject androidObject;
        AndroidJavaObject unityObject;

        AndroidJavaClass unityClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        unityObject = unityClass.GetStatic<AndroidJavaObject>("currentActivity");

        AndroidJavaClass androidClass = new AndroidJavaClass("com.reward.card.sdk.unityrewardlibrary.InstallReferrer");
        androidObject = androidClass.GetStatic<AndroidJavaObject>("self");

        androidObject.Call("getInstallReferrer", unityObject, isTest, ReferrerReceiver.ActionToJavaObject<String>(callback));
        return;
#elif UNITY_IOS || UNITY_IPHONE
        callback("default non natural");//ios默认为非自然量，返回非空则表示为非自然量
        return;
#endif
        callback("");
    }
}
