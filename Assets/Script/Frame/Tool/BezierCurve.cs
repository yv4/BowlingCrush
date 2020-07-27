using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BezierCurve : MonoBehaviour
{
    public Transform PointsParent;
    public LineRenderer lineRenderer;
    public int vectexCount;
    public List<Transform> positions = new List<Transform>();
    public List<Vector3> pointList;


    // Start is called before the first frame update
    private void Awake()
    {
        vectexCount = 0;
        positions.Clear();
        if (PointsParent != null)
        {
            #region 获取成员变量引用

            GameObject points = BaseOption.FindChild(PointsParent.gameObject, "Points");
            Transform[] trans = points.GetComponentsInChildren<Transform>();
            foreach (Transform item in trans)
            {
                if (!item.name.Equals("Points"))
                {
                    positions.Add(item);
                }
            }
            vectexCount = positions.Count;

            #endregion
        }
    }
    void Start()
    {
        pointList = new List<Vector3>();
        lineRenderer.startWidth = 0.1f;
        lineRenderer.endWidth = 0.1f;

       

        //player.Run();
    }

    // Update is called once per frame
    void Update()
    {
        BezierCurveWidthUnlimitPoints();
        lineRenderer.positionCount = pointList.Count;
        lineRenderer.SetPositions(pointList.ToArray());
    }

    /// <summary>
    /// 运行高阶贝塞尔曲线
    /// </summary>
    public void BezierCurveWidthUnlimitPoints()
    {
        pointList.Clear();
        for (float ratio=0;ratio<=1; ratio += 1.0f/vectexCount)
        {
            pointList.Add(UnlimitBezierCurve(positions,ratio));
        }

        pointList.Add(positions[positions.Count - 1].position);
    }

    /// <summary>
    /// 贝塞尔曲线运算
    /// </summary>
    /// <param name="trans"></param>
    /// <param name="t"></param>
    /// <returns></returns>
    public Vector3 UnlimitBezierCurve(List<Transform> trans,float t)
    {
        Vector3[] temp = new Vector3[trans.Count];

        for (int i = 0; i < temp.Length; i++)
        {
            temp[i] = trans[i].position;
        }

        int n = temp.Length - 1;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n-i; j++)
            {
                temp[j] = Vector3.Lerp(temp[j], temp[j + 1], t);
            }
        }

        return temp[0];
    }
}
