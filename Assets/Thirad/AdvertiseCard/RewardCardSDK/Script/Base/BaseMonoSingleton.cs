using UnityEngine;

namespace MobiiGame.Sdk.Base
{
    public class BaseMonoSingleton<T> : MonoSingleton<T> where T : MonoBehaviour
    {
        public virtual void Initialize() { }

        protected virtual void OnAwake()
        {

        }

        protected sealed override void Awake()
        {
            Initialize();
            base.Awake();
            OnAwake();
        }
    }
}