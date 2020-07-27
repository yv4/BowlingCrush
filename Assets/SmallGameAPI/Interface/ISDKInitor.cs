using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace MiniGameSDK
{
    public interface ISDKInitor 
    {
        string paramName { get; }
        void SetParam(params string[] param);
    }
}
