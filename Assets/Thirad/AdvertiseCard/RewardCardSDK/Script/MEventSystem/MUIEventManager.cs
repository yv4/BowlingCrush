using System.Collections;
using System.Collections.Generic;
using System;

namespace MobiiGame.Sdk.Event
{
    public class MUIEventManager : Singleton<MUIEventManager>
    {
        public delegate void OnUIEventHandler(MUIEvent uiEvent);

        private MUIEventManager.OnUIEventHandler[] m_uiEventHandlerMap = new MUIEventManager.OnUIEventHandler[(int)enMUIEventID.MAX_Tag];

        private List<object> m_uiEvents = new List<object>();

        public bool HasUIEventListener(enMUIEventID eventID)
        {
            return this.m_uiEventHandlerMap[(int)eventID] != null;
        }

        public void AddUIEventListener(enMUIEventID eventID, MUIEventManager.OnUIEventHandler onUIEventHandler)
        {
            if (this.m_uiEventHandlerMap[(int)eventID] == null)
            {
                this.m_uiEventHandlerMap[(int)eventID] = delegate
                {
                };
                MUIEventManager.OnUIEventHandler[] uiEventHandlerMap = this.m_uiEventHandlerMap;
                uiEventHandlerMap[(int)eventID] = (MUIEventManager.OnUIEventHandler)Delegate.Combine(uiEventHandlerMap[(int)eventID], onUIEventHandler);
            }
            else
            {
                MUIEventManager.OnUIEventHandler[] uiEventHandlerMap2 = this.m_uiEventHandlerMap;

                uiEventHandlerMap2[(int)eventID] = (MUIEventManager.OnUIEventHandler)Delegate.Remove(uiEventHandlerMap2[(int)eventID], onUIEventHandler);
                MUIEventManager.OnUIEventHandler[] uiEventHandlerMap3 = this.m_uiEventHandlerMap;
                uiEventHandlerMap3[(int)eventID] = (MUIEventManager.OnUIEventHandler)Delegate.Combine(uiEventHandlerMap3[(int)eventID], onUIEventHandler);
            }
        }

        public void RemoveUIEventListener(enMUIEventID eventID, MUIEventManager.OnUIEventHandler onUIEventHandler)
        {
            if (this.m_uiEventHandlerMap[(int)eventID] != null)
            {
                MUIEventManager.OnUIEventHandler[] uiEventHandlerMap = this.m_uiEventHandlerMap;

                uiEventHandlerMap[(int)eventID] = (MUIEventManager.OnUIEventHandler)Delegate.Remove(uiEventHandlerMap[(int)eventID], onUIEventHandler);
            }
        }

        public void DispatchUIEvent(MUIEvent uiEvent)
        {
            uiEvent.m_inUse = true;
            MUIEventManager.OnUIEventHandler onUIEventHandler = this.m_uiEventHandlerMap[(int)uiEvent.m_eventID];
            if (onUIEventHandler != null)
            {
                try
                {
                    onUIEventHandler(uiEvent);
                }
                catch (Exception ex)
                {
                    //LogUtil.LogError("dispatchUIEvent failure:" + (uiEvent != null ? uiEvent.m_eventID.ToString() : "null") + "    " + ex);
                }
            }
            uiEvent.Clear();
        }

        public void DispatchUIEvent(enMUIEventID eventID)
        {
            MUIEvent uIEvent = this.GetUIEvent();
            uIEvent.m_eventID = eventID;
            this.DispatchUIEvent(uIEvent);
        }

        public void DispatchUIEvent(enMUIEventID eventID, MUIEventParams par)
        {
            MUIEvent uIEvent = this.GetUIEvent();
            uIEvent.m_eventID = eventID;
            uIEvent.m_eventParams = par;
            this.DispatchUIEvent(uIEvent);
        }

        public MUIEvent GetUIEvent()
        {
            for (int i = 0; i < this.m_uiEvents.Count; i++)
            {
                MUIEvent cUIEvent = (MUIEvent)this.m_uiEvents[i];
                if (!cUIEvent.m_inUse)
                {
                    return cUIEvent;
                }
            }
            MUIEvent cUIEvent2 = new MUIEvent();
            this.m_uiEvents.Add(cUIEvent2);
            return cUIEvent2;
        }
    }
}