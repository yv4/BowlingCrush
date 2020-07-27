using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseOption : AbstractInput
{
    private bool m_ActiveInput;//输入激活
    private Vector3 m_MousePos;//鼠标位置
    private bool m_OptionHaveInput;//操作输入
    private Vector3 m_CurrentPos;//当前位置
    private Canvas m_Canvas;//当前画布
    private bool m_Launch;//启动
    private float m_OverTime;//接触时间
    private float m_OverTimeMax = 0.1f;//接触时间阀值
    private Vector2 m_LastMousPos = Vector2.zero;//上次鼠标位置
 

    public MouseOption()
    {
        GameObject canvas = BaseOption.GetCanvas(GameTags.GameRunCanvas);
        if (canvas!=null)
        {
            m_Canvas = canvas.GetComponent<Canvas>();
        }
        
    }

    /// <summary>
    /// 检测是否加速
    /// </summary>
    public bool CheckAcceelerate()
    {
        if (Input.GetMouseButton(0))
        {
            return true;
        }

        return false;
    }

    private void CheckLaunch()
    {
        if (Input.GetMouseButton(0))
        {
            m_OverTime += Time.deltaTime;
        }

        if (Input.GetMouseButtonUp(0))
        {
            m_OverTime = 0;
            m_Launch = false;
        }

        if (m_OverTime>m_OverTimeMax)
        {
            m_Launch = true;
        }
    }

    private Vector3 GetMousePosition()
    {
      
        Vector2 tempPos = Vector2.zero;
        //if (m_Launch)
        //{
        //    Vector3 Pos2D = Input.mousePosition;//获取屏幕的鼠标2d坐标
        //    tempPos = new Vector2(Pos2D.x, 0);
     
        //}

        Vector3 Pos2D = Input.mousePosition;//获取屏幕的鼠标2d坐标
        tempPos = new Vector2(Pos2D.x, 0);
        //m_LastMousPos = tempPos;

        return tempPos;
      
    }

    public float GetFingerPos()
    {
        CheckLaunch();
        if (!m_Launch)
        {
            return 0;
        }

        if (m_CurrentPos == Vector3.zero)
        {
            Vector3 tempValue = GetMousePosition();
            tempValue = new Vector3(tempValue.x, tempValue.y, tempValue.z);
            m_CurrentPos = tempValue;
        }

        Vector3 curMousePos = GetMousePosition();
        curMousePos = new Vector3(curMousePos.x, curMousePos.y, curMousePos.z);
        Vector3 delta = Vector3.zero;
        delta = new Vector3(curMousePos.x - m_CurrentPos.x, 0, curMousePos.z - m_CurrentPos.z);
        m_CurrentPos = curMousePos;
        if (Mathf.Abs(delta.x)>100)
        {
            return 0;
        }
        return delta.x;
       

    }



    /// <summary>
    /// 检测左右输入
    /// </summary>
    public override void CheckMoveDir()
    {

        if (Input.GetMouseButtonDown(0))
        {
            m_ActiveInput = true;
            m_MousePos = Input.mousePosition;
        }

        
        if (Input.GetMouseButton(0) && m_ActiveInput)
        {
            Vector3 Dir = Input.mousePosition - m_MousePos;
            if (Dir.magnitude > 20)
            {
                float xVal = Mathf.Abs(Dir.x);
                float yVal = Mathf.Abs(Dir.y);

                if (xVal > yVal && Dir.x > 0)
                {
                    m_OptionHaveInput = true;
                    CurrentDir = SwipeDirectionEnum.SwipeRight;
                }
                else if (xVal > yVal && Dir.x < 0)
                {
                    m_OptionHaveInput = true;
                    CurrentDir = SwipeDirectionEnum.SwipeLeft;
                }

                m_ActiveInput = false;

                if (m_OptionHaveInput)
                {
                    m_OptionHaveInput = false;
                }
               
            }
        }
    }
}
