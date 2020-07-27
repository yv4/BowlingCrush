using System.Collections;
using System.Collections.Generic;
using TimerDelay;
using UnityEngine;

public class ObstacleCtrl : MonoBehaviour
{
    private bool m_Fly;
    private Vector3 m_ColliderPos;
    private GameObject m_Mesh;
    private Vector3 m_RotateVec = new Vector3(1, 1, 1);
    public float FlySpeed = 10;
    public float RotateSpeed = 2000;
    private List<Vector3> m_MovePoints;
    public float ResetTime = 1;

    // Start is called before the first frame update\
    private void Awake()
    {
        m_Mesh = BaseOption.FindChild(this.gameObject, "Mesh");
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (m_Fly)
        {
            Vector3 colliderDir = m_ColliderPos- transform.position;
            colliderDir.Normalize();
       
            transform.Translate((colliderDir + new Vector3(0,1,-0.8f)) * Time.deltaTime * FlySpeed,Space.World);
            m_Mesh.transform.Rotate(m_RotateVec, 10);

            Timer.Register(ResetTime, () =>
            {
                m_Fly = false;
                m_Mesh.transform.eulerAngles = Vector3.zero;
                transform.localPosition = Vector3.zero;
                this.gameObject.SetActive(false);
            }
            );
        }

       
    }

    /// <summary>
    /// 击飞
    /// </summary>
    public void ColliderFly(Vector3 pos)
    {
        m_ColliderPos = pos;
        m_Fly = true;
    }

}
