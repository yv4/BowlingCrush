using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalInit : Singleton<GlobalInit> {

    public AnimationCurve UIAnimationCurve = new AnimationCurve(new Keyframe(0f, 0f, 0f, 1f), new Keyframe(1f, 1f, 1f, 0f));
}
