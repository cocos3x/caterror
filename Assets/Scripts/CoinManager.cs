using UnityEngine;
public sealed class CoinManager : SingletonMonoBehaviour<CoinManager>
{
    // Fields
    private UnityEngine.RectTransform coinPrefab;
    private float duration;
    private UnityEngine.RectTransform canvas;
    private UnityEngine.Camera mainCamera;
    private UnityEngine.GameObject panel;
    private UnityEngine.RectTransform icon;
    private TextWithCountUpInt coinText;
    private UpdateCoinEvent onUpdateCoin;
    private UpdateCoinEvent onAddCoin;
    private UpdateCoinEvent onSubCoin;
    private int ownCoin;
    private string coinTextFormat;
    
    // Properties
    public UpdateCoinEvent OnUpdateCoin { get; }
    public int OwnCoin { get; }
    
    // Methods
    public UpdateCoinEvent get_OnUpdateCoin()
    {
        return (UpdateCoinEvent)this.onUpdateCoin;
    }
    public int get_OwnCoin()
    {
        return (int)this.ownCoin;
    }
    private void Awake()
    {
        bool val_1 = this.CheckInstance();
    }
    public void Hide()
    {
        this.panel.SetActive(value:  false);
    }
    public void Show()
    {
        this.panel.SetActive(value:  true);
    }
    public void ChangeCoin(int coin)
    {
        this.ownCoin = coin;
        this.coinText.ChangeValue(format:  this.coinTextFormat, value:  coin);
        this.onUpdateCoin.Invoke(arg0:  this.ownCoin);
    }
    public void AddBonusCoin(int coin)
    {
        this.AddCoin(coin:  coin);
    }
    public void AddCoin()
    {
        int val_1 = this.ownCoin + 1;
        this.ownCoin = val_1;
        this.coinText.ChangeValue(format:  this.coinTextFormat, value:  val_1);
        this.onUpdateCoin.Invoke(arg0:  this.ownCoin);
        this.onAddCoin.Invoke(arg0:  this.ownCoin);
    }
    public void AddCoin(int coin)
    {
        int val_1 = coin;
        val_1 = this.ownCoin + val_1;
        this.ownCoin = val_1;
        this.coinText.CountUpAnimation(format:  this.coinTextFormat, toValue:  val_1, duration:  this.duration);
        this.onUpdateCoin.Invoke(arg0:  this.ownCoin);
        this.onAddCoin.Invoke(arg0:  this.ownCoin);
    }
    public void AddCoinEffect(UnityEngine.Vector3 worldPosition, int coin)
    {
        int val_9;
        int val_10;
        UnityEngine.Vector2 val_11;
        float val_12;
        UnityEngine.RectTransform val_13;
        val_9 = coin;
        CoinManager.<>c__DisplayClass23_0 val_1 = new CoinManager.<>c__DisplayClass23_0();
        if(val_1 != null)
        {
                .<>4__this = this;
            .coin = val_9;
            val_10 = this.ownCoin;
        }
        else
        {
                mem[16] = this;
            mem[40] = val_9;
            val_10 = this.ownCoin;
            val_9 = mem[40];
        }
        
        this.ownCoin = val_9 + val_10;
        UnityEngine.Vector2 val_3 = UnityEngine.RectTransformUtility.WorldToScreenPoint(cam:  this.mainCamera, worldPoint:  new UnityEngine.Vector3() {x = worldPosition.x, y = worldPosition.y, z = worldPosition.z});
        val_11 = val_3.x;
        val_12 = val_3.y;
        if(val_1 != null)
        {
                .fromPosition = val_3;
            mem[1152921511898769476] = val_12;
            val_13 = this.coinPrefab;
        }
        else
        {
                .fromPosition = val_3;
            mem[1152921511898769476] = val_12;
            val_13 = this.coinPrefab;
            val_11 = (CoinManager.<>c__DisplayClass23_0)[1152921511898769440].fromPosition;
        }
        
        UnityEngine.Vector3 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_11, y = val_12});
        UnityEngine.Quaternion val_5 = UnityEngine.Quaternion.identity;
        .effect = UnityEngine.Object.Instantiate<UnityEngine.RectTransform>(original:  val_13, position:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, rotation:  new UnityEngine.Quaternion() {x = val_5.x, y = val_5.y, z = val_5.z, w = val_5.w}, parent:  this.canvas);
        UnityEngine.Coroutine val_8 = MonoBehaviourExtensions.CallWaitForSeconds(monoBehaviour:  this, seconds:  0.5f, act:  new System.Action(object:  val_1, method:  System.Void CoinManager.<>c__DisplayClass23_0::<AddCoinEffect>b__0()));
    }
    public void SubCoin(int coin)
    {
        int val_3 = this.ownCoin;
        val_3 = val_3 - coin;
        this.ownCoin = val_3;
        if(this.coinText.gameObject.activeInHierarchy != false)
        {
                this.coinText.CountUpAnimation(format:  this.coinTextFormat, toValue:  this.ownCoin, duration:  this.duration);
        }
        else
        {
                this.coinText.ChangeValue(format:  this.coinTextFormat, value:  this.ownCoin);
        }
        
        this.onUpdateCoin.Invoke(arg0:  this.ownCoin);
        this.onSubCoin.Invoke(arg0:  this.ownCoin);
    }
    public CoinManager()
    {
        this.duration = 0.5f;
        this.coinTextFormat = "{0}";
    }

}
