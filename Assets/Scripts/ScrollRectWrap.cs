using UnityEngine;
public class ScrollRectWrap : ScrollRect
{
    // Fields
    private bool isScroll;
    
    // Properties
    public bool IsScroll { get; }
    
    // Methods
    public bool get_IsScroll()
    {
        return (bool)this.isScroll;
    }
    public override void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
    {
        this.OnBeginDrag(eventData:  eventData);
        this.isScroll = true;
    }
    public override void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData)
    {
        this.OnEndDrag(eventData:  eventData);
        this.isScroll = false;
    }
    public ScrollRectWrap()
    {
    
    }

}
