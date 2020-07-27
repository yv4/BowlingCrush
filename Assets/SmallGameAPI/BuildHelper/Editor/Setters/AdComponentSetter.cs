using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Reflection;
namespace MiniGameSDK
{
    public class AdComponentSetter : IBuildValueSetter
    {
        public void SetData(Dictionary<string, string> data)
        {
            var mark = UnityEngine.Object.FindObjectOfType<InitorMark>();
            if (mark)
            {
                if (mark.GetComponentsInChildren<IAdAPI>().Length > 0) return;
                foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
                {
                    if (assembly.FullName.Contains("Assembly-CSharp"))
                    {
                        foreach (var item in assembly.GetTypes())
                        {
                            if (item.IsAbstract || item.IsInterface) continue;
                            if (typeof(IRewardAdAPI).IsAssignableFrom(item)|| typeof(IInterstitialAdAPI).IsAssignableFrom(item))
                            {
                                var adp = item.GetCustomAttribute<AdAPIAutoLoadAttribute>();
                                if (adp != null)
                                {
                                    var adinitor = mark.GetComponent(adp.type);
                                    if (adinitor != null)
                                    {
                                        mark.transform.GetChild(0).gameObject.AddComponent(item);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}

