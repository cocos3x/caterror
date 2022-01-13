using UnityEngine;
public interface IJoypacAdInterface
{
    // Methods
    public abstract void Init(); // 0
    public abstract void LoadBanner(System.Action<bool> _callback); // 0
    public abstract void LoadInterstitial(System.Action<bool> _callback, string interId); // 0
    public abstract void LoadVideo(System.Action<bool> _callback); // 0
    public abstract void LoadNative(System.Action<bool> _callback, float width, float height); // 0
    public abstract void ShowVideo(string eventPosition, System.Action<JoypacVideoStatus> _callback); // 0
    public abstract void ShowIntersitial(System.Action<JoypacIntersitialStatus> _callback, string interId); // 0
    public abstract void ShowBanner(); // 0
    public abstract void HideBanner(); // 0
    public abstract void RemoveBanner(); // 0
    public abstract void ShowNative(float x, float y, float w, float h); // 0
    public abstract void RemoveNative(bool _clean); // 0
    public abstract void ShowCrossPromotion(string _url, System.Action _callback); // 0
    public abstract bool IsReadyVideo(); // 0
    public abstract bool IsReadyIntersitial(string interId); // 0
    public abstract bool IsReadyBanner(); // 0
    public abstract bool IsReadyNative(); // 0

}
