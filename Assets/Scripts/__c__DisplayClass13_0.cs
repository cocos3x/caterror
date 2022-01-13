using UnityEngine;
private sealed class PageScrollRect.<>c__DisplayClass13_0
{
    // Fields
    public PageScrollRect <>4__this;
    public float destX;
    public int pageIndex;
    public int maxPage;
    
    // Methods
    public PageScrollRect.<>c__DisplayClass13_0()
    {
    
    }
    internal void <ChangePage>b__1()
    {
        int val_7;
        this.<>4__this.prevPageIndexLate = this.pageIndex;
        val_7 = 1152921504793800704;
        if((UnityEngine.Object.op_Implicit(exists:  this.<>4__this.prevButton)) != false)
        {
                this.<>4__this.prevButton.gameObject.SetActive(value:  (this.pageIndex > 0) ? 1 : 0);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.<>4__this.nextButton)) != false)
        {
                val_7 = this.pageIndex;
            this.<>4__this.nextButton.gameObject.SetActive(value:  (val_7 < this.maxPage) ? 1 : 0);
        }
        
        this.<>4__this.onPageChanged.Invoke(arg0:  this.pageIndex);
    }

}
