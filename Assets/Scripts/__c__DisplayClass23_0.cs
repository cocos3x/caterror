using UnityEngine;
private sealed class CoinManager.<>c__DisplayClass23_0
{
    // Fields
    public CoinManager <>4__this;
    public UnityEngine.RectTransform effect;
    public UnityEngine.Vector2 fromPosition;
    public int coin;
    public System.Action<float> <>9__1;
    public System.Action <>9__2;
    
    // Methods
    public CoinManager.<>c__DisplayClass23_0()
    {
    
    }
    internal void <AddCoinEffect>b__0()
    {
        System.Action<System.Single> val_4;
        System.Action val_5;
        val_4 = this.<>9__1;
        if(val_4 == null)
        {
                System.Action<System.Single> val_1 = null;
            val_4 = val_1;
            val_1 = new System.Action<System.Single>(object:  this, method:  System.Void CoinManager.<>c__DisplayClass23_0::<AddCoinEffect>b__1(float t));
            this.<>9__1 = val_4;
        }
        
        val_5 = this.<>9__2;
        if(val_5 == null)
        {
                System.Action val_2 = null;
            val_5 = val_2;
            val_2 = new System.Action(object:  this, method:  System.Void CoinManager.<>c__DisplayClass23_0::<AddCoinEffect>b__2());
            this.<>9__2 = val_5;
        }
        
        UnityEngine.Coroutine val_3 = MonoBehaviourExtensions.CallLerp(monoBehaviour:  this.<>4__this, duration:  0.5f, act:  val_1, callback:  val_2);
    }
    internal void <AddCoinEffect>b__1(float t)
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = this.fromPosition, y = V9.16B});
        UnityEngine.Vector3 val_2 = this.<>4__this.icon.position;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, t:  t * t);
        this.effect.position = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
    }
    internal void <AddCoinEffect>b__2()
    {
        CoinManager val_2;
        TextWithCountUpInt val_3;
        CoinManager val_4;
        CoinManager val_5;
        CoinManager val_6;
        val_2 = this.<>4__this;
        if(val_2 == null)
        {
            goto label_1;
        }
        
        val_3 = this.<>4__this.coinText;
        val_4 = val_2;
        goto label_4;
        label_1:
        val_4 = this.<>4__this;
        val_3 = this.<>4__this.coinText;
        if(val_4 == null)
        {
            goto label_3;
        }
        
        val_2 = val_4;
        goto label_4;
        label_3:
        val_2 = this.<>4__this;
        if(val_2 == null)
        {
            goto label_15;
        }
        
        label_4:
        if(this.coin == 1)
        {
                val_3.ChangeValue(format:  this.<>4__this.coinTextFormat, value:  this.<>4__this.ownCoin);
        }
        else
        {
                val_3.CountUpAnimation(format:  this.<>4__this.coinTextFormat, toValue:  this.<>4__this.ownCoin, duration:  this.<>4__this.duration);
        }
        
        val_5 = this.<>4__this;
        if((this.<>4__this) != null)
        {
            goto label_11;
        }
        
        val_5 = this.<>4__this;
        if(val_5 == null)
        {
            goto label_15;
        }
        
        label_11:
        this.<>4__this.onUpdateCoin.Invoke(arg0:  this.<>4__this.ownCoin);
        val_6 = this.<>4__this;
        if((this.<>4__this) != null)
        {
            goto label_14;
        }
        
        val_6 = this.<>4__this;
        if(val_6 == null)
        {
            goto label_15;
        }
        
        label_14:
        this.<>4__this.onAddCoin.Invoke(arg0:  this.<>4__this.ownCoin);
        UnityEngine.Object.Destroy(obj:  this.effect.gameObject);
        return;
        label_15:
    }

}
