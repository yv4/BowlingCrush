using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Text的数字文字 动画递增显示
/// </summary>
public class AutoNumberText : MonoBehaviour {

    //ToNumber队列
    private Queue<int> m_Queue = new Queue<int>();

    //显示数字的Text
    private Text m_Text;

    //收录从From到To数字的递增数字列表
    private List<int> m_Lst = new List<int>();

    //动画效果是否完毕
    private bool m_IsBusy = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnDestroy()
    {
        m_Queue = null;
        m_Text = null;
        m_Lst = null;
    }

    /// <summary>
    /// 递增要To的数字
    /// </summary>
    /// <param name="number"></param>
    public void DoNumber(int number)
    {
        //入队要To的数字
        m_Queue.Enqueue(number);

        CheckQueue();
    }

    /// <summary>
    /// 检测队列，如果有数字则播放递增动画效果
    /// </summary>
    void CheckQueue()
    {
        DoAnim();
    }

    /// <summary>
    /// 递增数字到To数字
    /// </summary>
    void DoAnim()
    {
        //判断队列是否有To数字
        if (m_Queue.Count>=1)
        {
            m_IsBusy = true;
            m_Lst.Clear();

            //To数字出列
            int toValue = m_Queue.Dequeue();

            //获取Text组件
            if (m_Text==null)
            {
                m_Text = GetComponent<Text>();
            }

            //获取当前值
            int currValue = 0;
            int.TryParse(m_Text.text, out currValue);

            //计算出差值
            int value = toValue - currValue;

            //步进值 每次累加这个数
            int step = (int)(value / 20);

            //如果差值大于0，每次至少步进1
            if (value>0)
            {
                step = Mathf.Clamp(step, 1, step);
            }
            //如果小于0，每次至少步进-1
            else
            {
                step = Mathf.Clamp(step, step, -1);
            }

            //分段的步进值
            int animValue = currValue;

            if (value>0)
            {
                //当分段值小于To值时，放入列表并累加步进
                while (animValue<toValue)
                {
                    m_Lst.Add(animValue);
                    animValue += step;
                }
            }
            else
            {
                //当分段值大于To值时，放入列表并累加步进
                while (animValue > toValue)
                {
                    m_Lst.Add(animValue);
                    animValue += step;
                }
            }
            //累加步进完毕后，添加最后的To值
            m_Lst.Add(toValue);
            StartCoroutine(DoText());
        }
    }

    //步进累加值协程
    private IEnumerator DoText()
    {
        if (m_Lst.Count>0)
        {
            //循环步进列表取值，并赋值给Text
            for (int i=0;i<m_Lst.Count;i++)
            {
                m_Text.text = m_Lst[i].ToString();
                //每次赋值后等待一段时间
                yield return new WaitForSeconds(0.02f);
            }
            //赋值完成后清空列表
            m_Lst.Clear();
            m_IsBusy = false;

            CheckQueue();
        }
    }
}
