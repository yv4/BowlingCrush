using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class ChangeMeshAction : AbstractRoleAction
{
    #region 成员变量

    private GameObject m_MeshParent;

    #endregion

    #region 生命周期

    protected override void GetMemberReference()
    {
        m_MeshParent = BaseOption.FindChild(this.gameObject, "Mesh");

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
    /// 设置皮肤
    /// </summary>
    /// <param name="meshObjPath"></param>
    public void SetMesh(string meshObjPath)
    {
        List<Vector3> childPos = new List<Vector3>();
        for (int i=0;i<m_MeshParent.transform.childCount;i++)
        {
            Transform child = m_MeshParent.transform.GetChild(i);
            childPos.Add(child.localPosition);
            GameObject.Destroy(child.gameObject);
        }

        StringBuilder sb = new StringBuilder(GameTags.BottleMesh);
        sb.Append(meshObjPath);

        foreach (Vector3 pos in childPos)
        {
            GameObject meshObj = ResourcesMgr.Instance.Load(sb.ToString(), true, true);
            meshObj.transform.SetParent(m_MeshParent.transform);
            meshObj.transform.localPosition = pos;
        }
    }


    #endregion

    #region 委托方法

    #endregion
}
