using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractInput  {

    public SwipeDirectionEnum CurrentDir;
    public abstract void CheckMoveDir();

}
