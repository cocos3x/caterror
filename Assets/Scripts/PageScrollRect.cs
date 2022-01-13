using UnityEngine;
public class PageScrollRect : ScrollRect, IPointerDownHandler, IEventSystemHandler
{
    // Fields
    private float duration;
    private UnityEngine.UI.Button prevButton;
    private UnityEngine.UI.Button nextButton;
    private PageChangedEvent onPageChanged;
    private float pageWidth;
    private int prevPageIndex;
    private int prevPageIndexLate;
    private UnityEngine.Coroutine coroutine;
    
    // Properties
    public PageChangedEvent OnPageChanged { get; }
    
    // Methods
    public PageChangedEvent get_OnPageChanged()
    {
        return (PageChangedEvent)this.onPageChanged;
    }
    protected override void Awake()
    {
        float val_14;
        this.Awake();
        UnityEngine.UI.GridLayoutGroup val_2 = this.content.GetComponent<UnityEngine.UI.GridLayoutGroup>();
        if(val_2 != null)
        {
                UnityEngine.Vector2 val_3 = val_2.cellSize;
            val_14 = val_3.x;
        }
        else
        {
                UnityEngine.Vector2 val_4 = val_2.cellSize;
            val_14 = val_4.x;
        }
        
        UnityEngine.Vector2 val_5 = val_2.spacing;
        val_5.x = val_14 + val_5.x;
        this.pageWidth = val_5.x;
        if((UnityEngine.Object.op_Implicit(exists:  this.prevButton)) != false)
        {
                this.prevButton.gameObject.SetActive(value:  (this.prevPageIndex > 0) ? 1 : 0);
            this.prevButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void PageScrollRect::<Awake>b__10_0()));
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.nextButton)) == false)
        {
                return;
        }
        
        this.nextButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void PageScrollRect::<Awake>b__10_1()));
    }
    public override void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
    {
        this.OnBeginDrag(eventData:  eventData);
    }
    public override void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData)
    {
        float val_7;
        int val_8;
        this.OnEndDrag(eventData:  eventData);
        this.StopMovement();
        UnityEngine.Vector2 val_2 = this.content.anchoredPosition;
        val_7 = val_2.x;
        val_2.x = val_7 / this.pageWidth;
        int val_3 = UnityEngine.Mathf.RoundToInt(f:  val_2.x);
        val_8 = -val_3;
        if(this.prevPageIndex == val_3)
        {
                UnityEngine.Vector2 val_4 = eventData.delta;
            val_7 = val_4.x;
            if(System.Math.Abs(val_7) >= 5f)
        {
                UnityEngine.Vector2 val_5 = eventData.delta;
            val_7 = val_5.x;
            val_8 = val_8 - ((int)UnityEngine.Mathf.Sign(f:  val_7));
        }
        
        }
        
        this.ChangePage(pageIndex:  val_8);
    }
    private void ChangePage(int pageIndex)
    {
        PageScrollRect.<>c__DisplayClass13_0 val_13;
        PageScrollRect.<>c__DisplayClass13_0 val_1 = new PageScrollRect.<>c__DisplayClass13_0();
        if(val_1 != null)
        {
                .<>4__this = this;
        }
        else
        {
                mem[16] = this;
        }
        
        .pageIndex = pageIndex;
        int val_13 = this.content;
        val_13 = val_13.childCount - 1;
        .maxPage = val_13;
        int val_4 = UnityEngine.Mathf.Clamp(value:  (PageScrollRect.<>c__DisplayClass13_0)[1152921512069422496].pageIndex, min:  0, max:  val_13);
        .pageIndex = val_4;
        float val_14 = this.pageWidth;
        val_14 = val_14 * ((float)-val_4);
        .destX = val_14;
        val_13 = this.content;
        UnityEngine.Vector2 val_6 = val_13.anchoredPosition;
        if(val_6.x != ((PageScrollRect.<>c__DisplayClass13_0)[1152921512069422496].destX))
        {
                .CS$<>8__locals1 = val_1;
            MonoBehaviourExtensions.SafeStopCoroutine(monoBehaviour:  this, c:  this.coroutine);
            UnityEngine.Vector2 val_9 = this.content.anchoredPosition;
            .from = val_9.x;
            val_9.x = val_9.x - ((PageScrollRect.<>c__DisplayClass13_1)[1152921512069434784].CS$<>8__locals1.destX);
            val_13 = (PageScrollRect.<>c__DisplayClass13_1)[1152921512069434784].CS$<>8__locals1;
            val_9.x = this.duration * System.Math.Abs(val_9.x);
            val_9.x = val_9.x / this.pageWidth;
            this.coroutine = MonoBehaviourExtensions.CallLerpRealtime(monoBehaviour:  this, duration:  val_9.x, act:  new System.Action<System.Single>(object:  new PageScrollRect.<>c__DisplayClass13_1(), method:  System.Void PageScrollRect.<>c__DisplayClass13_1::<ChangePage>b__0(float t)), callback:  new System.Action(object:  val_13, method:  System.Void PageScrollRect.<>c__DisplayClass13_0::<ChangePage>b__1()));
        }
        
        this.prevPageIndex = (PageScrollRect.<>c__DisplayClass13_0)[1152921512069422496].pageIndex;
    }
    public void ImmediateChangePage(int pageIndex)
    {
        float val_17;
        int val_16 = this.content;
        val_16 = val_16.childCount - 1;
        int val_3 = UnityEngine.Mathf.Clamp(value:  pageIndex, min:  0, max:  val_16);
        val_17 = this.pageWidth * ((float)-val_3);
        UnityEngine.Vector2 val_5 = this.content.anchoredPosition;
        if(val_5.x != val_17)
        {
                MonoBehaviourExtensions.SafeStopCoroutine(monoBehaviour:  this, c:  this.coroutine);
            UnityEngine.Vector2 val_8 = this.content.anchoredPosition;
            UnityEngine.Vector2 val_9 = Vector2Extensions.SetX(v:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y}, f:  val_17);
            val_17 = val_9.x;
            this.content.anchoredPosition = new UnityEngine.Vector2() {x = val_17, y = val_9.y};
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.prevButton)) != false)
        {
                this.prevButton.gameObject.SetActive(value:  (val_3 > 0) ? 1 : 0);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.nextButton)) != false)
        {
                this.nextButton.gameObject.SetActive(value:  (val_3 < val_16) ? 1 : 0);
        }
        
        this.prevPageIndex = val_3;
        this.prevPageIndexLate = val_3;
    }
    public void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
    {
        MonoBehaviourExtensions.SafeStopCoroutine(monoBehaviour:  this, c:  this.coroutine);
    }
    public PageScrollRect()
    {
        this.duration = 0.2f;
    }
    private void <Awake>b__10_0()
    {
        this.ChangePage(pageIndex:  this.prevPageIndexLate - 1);
    }
    private void <Awake>b__10_1()
    {
        this.ChangePage(pageIndex:  this.prevPageIndexLate + 1);
    }

}
