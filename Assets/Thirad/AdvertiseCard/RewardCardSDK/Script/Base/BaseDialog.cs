using UnityEngine;
using System;

namespace MobiiGame.Sdk.Base
{
    public class BaseDialog : MonoBehaviour
    {
        public static BaseDialog instance;
        public Animator anim;
        public AnimationClip hidingAnimation;
        public GameObject title, message;
        public Action<BaseDialog> onDialogOpened;
        public Action<BaseDialog> onDialogClosed;
        public Action onDialogCompleteClosed;
        public Action<BaseDialog> onButtonCloseClicked;
        public bool isTop = false;

        private AnimatorStateInfo info;

        protected virtual void Awake()
        {
            instance = this;

            if (anim == null) anim = GetComponent<Animator>();
        }

        protected virtual void Start()
        {
            onDialogCompleteClosed += OnDialogCompleteClosed;
            //GetComponent<Canvas>().worldCamera = Camera.main;

            if (isTop)
            {
                GetComponent<Canvas>().sortingOrder = 15;
            }
        }

        protected virtual void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                OnBackPressed();
            }
        }

        public virtual void Show()
        {
            gameObject.SetActive(true);
            if (anim != null && IsIdle())
            {
                anim.SetTrigger("show");
                onDialogOpened(this);
            }
        }

        protected virtual void OnBackPressed()
        {
            Close();
        }

        public virtual void Close()
        {
            if (anim != null && IsIdle() && hidingAnimation != null)
            {
                anim.SetTrigger("hide");
                Timer.Schedule(this, hidingAnimation.length, DoClose);
            }
            else
            {
                DoClose();
            }

            onDialogClosed?.Invoke(this);
        }

        private void DoClose()
        {
            Destroy(gameObject);
            onDialogCompleteClosed?.Invoke();
        }

        public void Hide()
        {
            gameObject.SetActive(false);
        }

        public bool IsIdle()
        {
            info = anim.GetCurrentAnimatorStateInfo(0);
            return info.IsName("Idle");
        }

        //    public bool IsShowing()
        //    {
        //        return isShowing;
        //    }

        public virtual void OnDialogCompleteClosed()
        {
            onDialogCompleteClosed -= OnDialogCompleteClosed;
        }
    }
}