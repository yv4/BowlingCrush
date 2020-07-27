using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace MiniGameSDK
{
    [AttributeUsage(AttributeTargets.Class)]
    public class AdAPIAutoLoadAttribute : Attribute
    {
        public Type type;
        public AdAPIAutoLoadAttribute(Type type)
        {
            this.type = type;
        }
    }
}

