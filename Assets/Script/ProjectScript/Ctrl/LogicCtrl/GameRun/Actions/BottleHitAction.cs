using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using TimerDelay;
using UnityEngine;

public class BottleHitAction : AbstractRoleAction
{
    #region 成员变量

    public float FlySpeed = 10;
    public float DisappearTime = 0.5f;
    private List<GameObject> m_MeshsObj = new List<GameObject>();
    private List<ParticleSystem> m_EffectObj = new List<ParticleSystem>();
    private bool m_Shake;
    public bool SingleCollider;

    #endregion

    #region 生命周期

    protected override void GetMemberReference()
    {



    }

    protected override void OnInit()
    {

    }

    protected override void OnUpdate()
    {

    }

    private void FixedUpdate()
    {

    }

    protected override void DestroySelf()
    {

    }

    #endregion

    #region 成员方法

    /// <summary>
    /// 获取子物体
    /// </summary>
    public void GetObjs()
    {
        Transform mesh = BaseOption.FindChild(this.gameObject, "Mesh").transform;
        for (int i = 0; i < mesh.childCount; i++)
        {
            GameObject childObj = mesh.GetChild(i).gameObject;
            m_MeshsObj.Add(childObj);
        }
    }

    /// <summary>
    /// 获取特效
    /// </summary>
    public void GetEffects()
    {
        Transform mesh = BaseOption.FindChild(this.gameObject, "DissappearEffect").transform;
        for (int i = 0; i < mesh.childCount; i++)
        {
            GameObject childObj = mesh.GetChild(i).gameObject;
            m_MeshsObj.Add(childObj);
        }
    }

    /// <summary>
    /// 开始碰撞
    /// </summary>
    public void StartCollider(Transform collider)
    {

        if (m_MeshsObj.Count > 1 && !m_Shake)
        {
            Camera.main.DOComplete();
            Camera.main.DOShakePosition(0.2f, 1, 1, 3);
            m_Shake = true;
        }

        if (!SingleCollider)
        {

            foreach (GameObject item in m_MeshsObj)
            {

                ColliderBottleFly(item);

            }

            if (m_MeshsObj.Count > 1)
            {
                AudioEffectMgr.Instance.PlayShock();
            }
        }
        else
        {
            ColliderBottleFly(collider.gameObject);
        }


    }

    /// <summary>
    /// 击飞
    /// </summary>
    private void ColliderBottleFly(GameObject item)
    {
        Vector3 force = new Vector3(Random.Range(-30f, 30f), Random.Range(30f, 40f), FlySpeed);
        item.transform.DOLocalMove(force, 0.5f).SetEase(Ease.OutCirc);
        item.transform.DORotate(new Vector3(360, 0), Random.Range(0.2f, 1f), RotateMode.WorldAxisAdd).SetLoops(Random.Range(2, 5)).SetEase(Ease.Linear);
        Timer.Register(DisappearTime, () => {

            foreach (GameObject mesh in m_MeshsObj)
            {
                mesh.GetComponent<MeshRenderer>().enabled = false;
                ParticleSystem dead = mesh.GetComponentInChildren<ParticleSystem>();
                dead.Play();
            }
        });
    }

    #endregion

    #region 委托方法

    #endregion
}
