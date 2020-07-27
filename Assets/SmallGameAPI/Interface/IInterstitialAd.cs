using System;

namespace MiniGameSDK
{
    public interface IInterstitialAdAPI : IAdAPI
    {
        Action<bool> onClose { get; set; }
    }
}
