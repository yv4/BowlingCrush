using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneDontDesObjCheck : Singleton<SceneDontDesObjCheck>
{
    public GameObject EffectObj;

    public void EnableDontSaveObj(bool enable)
    {
        if (EffectObj)
        {
            EffectObj.gameObject.SetActive(enable);
        }
    }

    public void Clear()
    {
        if (EffectObj)
        {
            GameObject.Destroy(EffectObj);
            EffectObj = null;
        }

    
    }
}
