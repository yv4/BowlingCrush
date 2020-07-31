using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ChangeParticleSize : MonoBehaviour
{
    public int Size = 3;

    private void Awake()
    {
        ParticleSystem particle = BaseOption.FindChild(this.gameObject, "tiaodai").GetComponent<ParticleSystem>();
        var main = particle.main;
        main.startSize = new ParticleSystem.MinMaxCurve(Size);
        particle.gameObject.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        //Undo.RecordObject(this.gameObject, "Modify Obj");
        //EditorUtility.SetDirty(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
