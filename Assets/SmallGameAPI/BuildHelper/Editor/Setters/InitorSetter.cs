using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace MiniGameSDK
{
    public class InitorSetter : IBuildValueSetter
    {
        public void SetData(Dictionary<string, string> data)
        {
            var initor = Object.FindObjectOfType<InitorMark>();
            if (initor)
            {
                foreach (var item in initor.GetComponents<ISDKInitor>())
                {
                    string[] sp = data[item.paramName].Split(',');
                    for (int i = 0; i < sp.Length; i++)
                    {
                        sp[i] = sp[i].Trim();
                    }
                    item.SetParam(sp);
                    EditorSaveHelper.SaveSceneObject(item as Object);
                }
            }
        }
    }
}
