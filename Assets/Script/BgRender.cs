using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace CutIt
{
    public class BgRender : MonoBehaviour
    {
        //public Color[] colors;
        //Mesh mesh;
        void Start()
        {
            //mesh = GetComponent<MeshFilter>().mesh;
            //setColor();
            SetScale();
            //var rd=GetComponent<MeshRenderer>();
            //rd.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.Off;
            //rd.receiveShadows = false;
        }
        void SetScale()
        {
            var cam = GetComponentInParent<Camera>();
            Vector3 scale = Vector3.one;
            scale.y = transform.localPosition.z * Mathf.Tan(Mathf.Deg2Rad * cam.fieldOfView * 0.5f)*2;
            scale.x = scale.y * Screen.width / Screen.height;
            transform.localScale = scale;
        }
        //void setColor()
        //{
        //    mesh.colors = colors;
        //    RenderSettings.fogColor = Color.Lerp(colors[0], colors[2], 0.8f);
        //}
        public void SetColor(Color bottom,Color top)
        {
            //colors[0] = colors[1] = bottom;
            //colors[2] = colors[3] = top;
            //setColor();
        }
        private void Update()
        {
            //setColor();
            SetScale();
        }
    }
}

