using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TipsUI : MonoBehaviour
{
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void Show(string message,int hideTime)
    {
        CancelInvoke("AutoHide");
        text.text = message;
        this.gameObject.SetActive(true);
        Invoke("AutoHide", hideTime);
    }

    void AutoHide()
    {
        this.gameObject.SetActive(false);
    }
}
