using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MobiiGame.Sdk.Event
{
    public class MUIEvent
    {
        public enMUIEventID m_eventID;
        public MUIEventParams m_eventParams;

        public bool m_inUse;

        public void Clear()
        {
            this.m_eventID = enMUIEventID.None;
            this.m_inUse = false;
        }
    }
}