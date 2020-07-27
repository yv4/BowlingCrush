using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fade : MonoBehaviour {

    private float m_FadeTime;
    [SerializeField]
    private float m_FadeThreshold;
    private Image m_FadeUI;
    private Text m_FadeText;
    private float m_StartTimer;
    [SerializeField]
    private float m_StartThreshold=3;
    private bool m_StartFade;

	// Use this for initialization
	void Start () {
        m_FadeUI = this.GetComponent<Image>();
        m_FadeText = BaseOption.FindChild<Text>(this.gameObject, "Text");
	}
	
	// Update is called once per frame
	void Update () {

        if (m_StartFade)
        {
            if (m_StartTimer < m_StartThreshold)
            {
                m_StartTimer += Time.deltaTime;

            }
            else
            {
                FadeAnim();
            }
        }
        
	}

    public void StartPromptFade()
    {
        m_StartFade = true;
    }

    private void FadeAnim()
    {
        float alpha = Mathf.Lerp(m_FadeUI.color.a, 0, 0.1f / m_FadeThreshold);
        if (m_FadeTime < m_FadeThreshold)
        {
            m_FadeTime += Time.deltaTime;
            m_FadeUI.color = new Color(m_FadeUI.color.r, m_FadeUI.color.g, m_FadeUI.color.b, alpha);
            if (m_FadeText != null)
            {
                m_FadeText.color = new Color(m_FadeText.color.r, m_FadeText.color.g, m_FadeText.color.b, alpha);
            }
        }
        else
        {
            m_FadeTime = 0;
            this.enabled = false;
            this.gameObject.SetActive(false);

        }
    }
}
