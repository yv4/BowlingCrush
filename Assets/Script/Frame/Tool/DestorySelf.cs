using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestorySelf : MonoBehaviour {

    private float m_DestoryTimer;

    [SerializeField]
    private float m_DestoryThreshold;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (m_DestoryTimer<m_DestoryThreshold)
        {
            m_DestoryTimer += Time.deltaTime;
        }
        else
        {
            GameObject.Destroy(this.gameObject);
        }
	}
}
