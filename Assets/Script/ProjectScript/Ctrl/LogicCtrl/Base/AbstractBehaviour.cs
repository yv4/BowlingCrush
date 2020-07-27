using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractBehaviour :MonoBehaviour {

    private void Awake()
    {
        GetMemberReference();
    }

    private void Start()
    {
        OnInit();
    }

    private void OnDestroy()
    {
        DestorySelf();


    }

    private void Update()
    {
        OnUpdate();
    }

    protected abstract void GetMemberReference();
    protected abstract void OnInit();
    protected abstract void DestorySelf();
    protected abstract void OnUpdate();

   
}
