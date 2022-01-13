using UnityEngine;
public class TimeValidator : SingletonMonoBehaviour<TimeValidator>
{
    // Fields
    private float boundaryMinutes;
    private TimeValidateState state;
    private System.Collections.Generic.List<System.Action<TimeValidationResult>> callbackList;
    private TimeValidationResult result;
    private UnityEngine.Coroutine coroutine;
    
    // Methods
    private void Awake()
    {
        this.coroutine = this.BeginTimeValidation();
    }
    public TimeValidateCoroutine TimeValidation(System.Action<TimeValidationResult> callback)
    {
        var val_4;
        TimeValidator.<>c__DisplayClass6_0 val_1 = new TimeValidator.<>c__DisplayClass6_0();
        if(val_1 != null)
        {
                .<>4__this = this;
        }
        else
        {
                mem[16] = this;
        }
        
        .callback = callback;
        if(this.state != 0)
        {
                callback.Invoke(obj:  this.result);
            val_4 = 0;
            return (TimeValidateCoroutine)val_4;
        }
        
        this.callbackList.Add(item:  callback);
        TimeValidateCoroutine val_3 = null;
        val_4 = val_3;
        val_3 = new TimeValidateCoroutine();
        .removeAction = new System.Action(object:  val_1, method:  System.Void TimeValidator.<>c__DisplayClass6_0::<TimeValidation>b__0());
        return (TimeValidateCoroutine)val_4;
    }
    private void OnApplicationPause(bool pauseStatus)
    {
        if(pauseStatus != false)
        {
                MonoBehaviourExtensions.SafeStopCoroutine(monoBehaviour:  this, c:  this.coroutine);
            this.state = 0;
            return;
        }
        
        this.coroutine = this.BeginTimeValidation();
    }
    private UnityEngine.Coroutine BeginTimeValidation()
    {
        if(UnityEngine.Application.internetReachability != 0)
        {
                return this.StartCoroutine(routine:  this.TimeValidation(succeededCallback:  new System.Action<System.DateTime>(object:  this, method:  System.Void TimeValidator::<BeginTimeValidation>b__8_0(System.DateTime networkTime)), failedCallback:  new System.Action(object:  this, method:  System.Void TimeValidator::<BeginTimeValidation>b__8_1())));
        }
        
        this.state = 2;
        this.result = 1;
        return 0;
    }
    private System.Collections.IEnumerator TimeValidation(System.Action<System.DateTime> succeededCallback, System.Action failedCallback)
    {
        TimeValidator.<TimeValidation>d__9 val_1 = new TimeValidator.<TimeValidation>d__9();
        .<>1__state = 0;
        if(val_1 != null)
        {
                .succeededCallback = succeededCallback;
            .<>4__this = this;
        }
        else
        {
                mem[40] = this;
            mem[32] = succeededCallback;
        }
        
        .failedCallback = failedCallback;
        return (System.Collections.IEnumerator)val_1;
    }
    public TimeValidator()
    {
        this.boundaryMinutes = 5f;
        this.callbackList = new System.Collections.Generic.List<System.Action<TimeValidationResult>>();
    }
    private void <BeginTimeValidation>b__8_0(System.DateTime networkTime)
    {
        ulong val_8;
        ulong val_9;
        TimeValidationResult val_10;
        System.DateTime val_1 = System.DateTime.UtcNow;
        bool val_2 = System.DateTime.op_LessThan(t1:  new System.DateTime() {dateData = networkTime.dateData}, t2:  new System.DateTime() {dateData = val_1.dateData});
        if(val_2 != false)
        {
                val_8 = val_1.dateData;
            val_9 = networkTime.dateData;
        }
        else
        {
                val_8 = networkTime.dateData;
            val_9 = val_1.dateData;
        }
        
        System.TimeSpan val_3 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_8}, d2:  new System.DateTime() {dateData = val_9});
        if(val_3._ticks.TotalMinutes > (double)this.boundaryMinutes)
        {
                this.state = 2;
            var val_5 = (val_2 != true) ? (3 + 1) : 3;
        }
        else
        {
                val_10 = 0;
            this.state = 1;
        }
        
        this.result = val_10;
        List.Enumerator<T> val_6 = this.callbackList.GetEnumerator();
        label_14:
        if(( & 1) == 0)
        {
            goto label_12;
        }
        
        0.Id.Invoke(obj:  this.result);
        goto label_14;
        label_12:
        UniRx.Unit..cctor();
        this.callbackList.Clear();
    }
    private void <BeginTimeValidation>b__8_1()
    {
        this.state = 2;
        this.result = 2;
        List.Enumerator<T> val_1 = this.callbackList.GetEnumerator();
        label_4:
        if(((-1070921304) & 1) == 0)
        {
            goto label_2;
        }
        
        0.Id.Invoke(obj:  this.result);
        goto label_4;
        label_2:
        UniRx.Unit..cctor();
        this.callbackList.Clear();
    }

}
