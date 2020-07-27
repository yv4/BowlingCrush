using System;
using System.Collections.Generic;

namespace MiniGameSDK
{
    public static class APIProvider
    {
        static Dictionary<Type, IAPI> ads = new Dictionary<Type, IAPI>();
        public static T GetAPI<T>() where T : IAPI
        {
            Type tType = typeof(T);
            if (!tType.IsInterface)
                return default;
            ads.TryGetValue(tType, out IAPI ad);
            return (T)ad;
        }
        public static void Provide<T>(T value) where T : IAPI
        {
            if (!typeof(T).IsInterface)
                throw new ArgumentException("Just Support 'interface' Type");
            ads.Add(typeof(T), value);
        }
    }
}