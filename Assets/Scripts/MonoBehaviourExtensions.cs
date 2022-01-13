using UnityEngine;
public static class MonoBehaviourExtensions
{
    // Methods
    public static void SafeStopCoroutine(UnityEngine.MonoBehaviour monoBehaviour, UnityEngine.Coroutine c)
    {
        if(c == null)
        {
                return;
        }
        
        monoBehaviour.StopCoroutine(routine:  c);
    }
    public static UnityEngine.Coroutine CallWaitForOneFrame(UnityEngine.MonoBehaviour monoBehaviour, System.Action act)
    {
        if(monoBehaviour != null)
        {
                return monoBehaviour.StartCoroutine(routine:  MonoBehaviourExtensions.DoCallWaitForOneFrame(act:  act));
        }
        
        return monoBehaviour.StartCoroutine(routine:  MonoBehaviourExtensions.DoCallWaitForOneFrame(act:  act));
    }
    private static System.Collections.IEnumerator DoCallWaitForOneFrame(System.Action act)
    {
        .<>1__state = 0;
        .act = act;
        return (System.Collections.IEnumerator)new MonoBehaviourExtensions.<DoCallWaitForOneFrame>d__2();
    }
    public static UnityEngine.Coroutine CallWaitForFrame(UnityEngine.MonoBehaviour monoBehaviour, int frameCount, System.Action act)
    {
        if(monoBehaviour != null)
        {
                return monoBehaviour.StartCoroutine(routine:  MonoBehaviourExtensions.DoCallWaitForFrame(frameCount:  frameCount, act:  act));
        }
        
        return monoBehaviour.StartCoroutine(routine:  MonoBehaviourExtensions.DoCallWaitForFrame(frameCount:  frameCount, act:  act));
    }
    private static System.Collections.IEnumerator DoCallWaitForFrame(int frameCount, System.Action act)
    {
        MonoBehaviourExtensions.<DoCallWaitForFrame>d__4 val_1 = new MonoBehaviourExtensions.<DoCallWaitForFrame>d__4();
        .<>1__state = 0;
        if(val_1 != null)
        {
                .frameCount = frameCount;
        }
        else
        {
                mem[32] = frameCount;
        }
        
        .act = act;
        return (System.Collections.IEnumerator)val_1;
    }
    public static UnityEngine.Coroutine CallWaitForOneFixedUpdate(UnityEngine.MonoBehaviour monoBehaviour, System.Action act)
    {
        if(monoBehaviour != null)
        {
                return monoBehaviour.StartCoroutine(routine:  MonoBehaviourExtensions.DoCallWaitForOneFixedUpdate(act:  act));
        }
        
        return monoBehaviour.StartCoroutine(routine:  MonoBehaviourExtensions.DoCallWaitForOneFixedUpdate(act:  act));
    }
    private static System.Collections.IEnumerator DoCallWaitForOneFixedUpdate(System.Action act)
    {
        .<>1__state = 0;
        .act = act;
        return (System.Collections.IEnumerator)new MonoBehaviourExtensions.<DoCallWaitForOneFixedUpdate>d__6();
    }
    public static UnityEngine.Coroutine CallWaitForFixedUpdate(UnityEngine.MonoBehaviour monoBehaviour, int frameCount, System.Action act)
    {
        if(monoBehaviour != null)
        {
                return monoBehaviour.StartCoroutine(routine:  MonoBehaviourExtensions.DoCallWaitForFixedUpdate(frameCount:  frameCount, act:  act));
        }
        
        return monoBehaviour.StartCoroutine(routine:  MonoBehaviourExtensions.DoCallWaitForFixedUpdate(frameCount:  frameCount, act:  act));
    }
    private static System.Collections.IEnumerator DoCallWaitForFixedUpdate(int frameCount, System.Action act)
    {
        MonoBehaviourExtensions.<DoCallWaitForFixedUpdate>d__8 val_1 = new MonoBehaviourExtensions.<DoCallWaitForFixedUpdate>d__8();
        .<>1__state = 0;
        if(val_1 != null)
        {
                .frameCount = frameCount;
        }
        else
        {
                mem[32] = frameCount;
        }
        
        .act = act;
        return (System.Collections.IEnumerator)val_1;
    }
    public static UnityEngine.Coroutine CallWaitForSeconds(UnityEngine.MonoBehaviour monoBehaviour, float seconds, System.Action act)
    {
        if(monoBehaviour != null)
        {
                return monoBehaviour.StartCoroutine(routine:  MonoBehaviourExtensions.DoCallWaitForSeconds(seconds:  seconds, act:  act));
        }
        
        return monoBehaviour.StartCoroutine(routine:  MonoBehaviourExtensions.DoCallWaitForSeconds(seconds:  seconds, act:  act));
    }
    private static System.Collections.IEnumerator DoCallWaitForSeconds(float seconds, System.Action act)
    {
        MonoBehaviourExtensions.<DoCallWaitForSeconds>d__10 val_1 = new MonoBehaviourExtensions.<DoCallWaitForSeconds>d__10();
        .<>1__state = 0;
        if(val_1 != null)
        {
                .seconds = seconds;
        }
        else
        {
                mem[32] = seconds;
        }
        
        .act = act;
        return (System.Collections.IEnumerator)val_1;
    }
    public static UnityEngine.Coroutine CallWaitForSeconds(UnityEngine.MonoBehaviour monoBehaviour, float seconds, System.Action<float> act, System.Action callback)
    {
        if(monoBehaviour != null)
        {
                return monoBehaviour.StartCoroutine(routine:  MonoBehaviourExtensions.DoCallWaitForSeconds(seconds:  seconds, act:  act, callback:  callback));
        }
        
        return monoBehaviour.StartCoroutine(routine:  MonoBehaviourExtensions.DoCallWaitForSeconds(seconds:  seconds, act:  act, callback:  callback));
    }
    private static System.Collections.IEnumerator DoCallWaitForSeconds(float seconds, System.Action<float> act, System.Action callback)
    {
        MonoBehaviourExtensions.<DoCallWaitForSeconds>d__12 val_1 = new MonoBehaviourExtensions.<DoCallWaitForSeconds>d__12();
        .<>1__state = 0;
        if(val_1 != null)
        {
                .seconds = seconds;
            .act = act;
        }
        else
        {
                mem[40] = seconds;
            mem[32] = act;
        }
        
        .callback = callback;
        return (System.Collections.IEnumerator)val_1;
    }
    public static UnityEngine.Coroutine CallWaitForRealTimeSeconds(UnityEngine.MonoBehaviour monoBehaviour, float seconds, System.Action callback)
    {
        null = null;
        if(monoBehaviour != null)
        {
                return monoBehaviour.StartCoroutine(routine:  MonoBehaviourExtensions.DoCallWaitForRealTimeSeconds(seconds:  seconds, act:  ActionExtensions.EmptyActionFloat, callback:  callback));
        }
        
        return monoBehaviour.StartCoroutine(routine:  MonoBehaviourExtensions.DoCallWaitForRealTimeSeconds(seconds:  seconds, act:  ActionExtensions.EmptyActionFloat, callback:  callback));
    }
    public static UnityEngine.Coroutine CallWaitForRealTimeSeconds(UnityEngine.MonoBehaviour monoBehaviour, float seconds, System.Action<float> act, System.Action callback)
    {
        if(monoBehaviour != null)
        {
                return monoBehaviour.StartCoroutine(routine:  MonoBehaviourExtensions.DoCallWaitForRealTimeSeconds(seconds:  seconds, act:  act, callback:  callback));
        }
        
        return monoBehaviour.StartCoroutine(routine:  MonoBehaviourExtensions.DoCallWaitForRealTimeSeconds(seconds:  seconds, act:  act, callback:  callback));
    }
    private static System.Collections.IEnumerator DoCallWaitForRealTimeSeconds(float seconds, System.Action<float> act, System.Action callback)
    {
        MonoBehaviourExtensions.<DoCallWaitForRealTimeSeconds>d__15 val_1 = new MonoBehaviourExtensions.<DoCallWaitForRealTimeSeconds>d__15();
        .<>1__state = 0;
        if(val_1 != null)
        {
                .seconds = seconds;
            .act = act;
        }
        else
        {
                mem[40] = seconds;
            mem[32] = act;
        }
        
        .callback = callback;
        return (System.Collections.IEnumerator)val_1;
    }
    public static UnityEngine.Coroutine CallLerp(UnityEngine.MonoBehaviour monoBehaviour, float duration, System.Action<float> act)
    {
        null = null;
        return MonoBehaviourExtensions.CallLerp(monoBehaviour:  monoBehaviour, duration:  duration, act:  act, callback:  ActionExtensions.EmptyAction);
    }
    public static UnityEngine.Coroutine CallLerp(UnityEngine.MonoBehaviour monoBehaviour, float duration, System.Action<float> act, System.Action callback)
    {
        if(monoBehaviour != null)
        {
                return monoBehaviour.StartCoroutine(routine:  MonoBehaviourExtensions.DoCallLerp(duration:  duration, act:  act, callback:  callback));
        }
        
        return monoBehaviour.StartCoroutine(routine:  MonoBehaviourExtensions.DoCallLerp(duration:  duration, act:  act, callback:  callback));
    }
    public static System.Collections.IEnumerator DoCallLerp(float duration, System.Action<float> act)
    {
        null = null;
        return MonoBehaviourExtensions.DoCallLerp(duration:  duration, act:  act, callback:  ActionExtensions.EmptyAction);
    }
    public static System.Collections.IEnumerator DoCallLerp(float duration, System.Action<float> act, System.Action callback)
    {
        MonoBehaviourExtensions.<DoCallLerp>d__19 val_1 = new MonoBehaviourExtensions.<DoCallLerp>d__19();
        .<>1__state = 0;
        if(val_1 != null)
        {
                .duration = duration;
            .act = act;
        }
        else
        {
                mem[40] = duration;
            mem[32] = act;
        }
        
        .callback = callback;
        return (System.Collections.IEnumerator)val_1;
    }
    public static UnityEngine.Coroutine CallFixedLerp(UnityEngine.MonoBehaviour monoBehaviour, float duration, System.Action<float> act)
    {
        null = null;
        return MonoBehaviourExtensions.CallFixedLerp(monoBehaviour:  monoBehaviour, duration:  duration, act:  act, callback:  ActionExtensions.EmptyAction);
    }
    public static UnityEngine.Coroutine CallFixedLerp(UnityEngine.MonoBehaviour monoBehaviour, float duration, System.Action<float> act, System.Action callback)
    {
        if(monoBehaviour != null)
        {
                return monoBehaviour.StartCoroutine(routine:  MonoBehaviourExtensions.DoCallFixedLerp(duration:  duration, act:  act, callback:  callback));
        }
        
        return monoBehaviour.StartCoroutine(routine:  MonoBehaviourExtensions.DoCallFixedLerp(duration:  duration, act:  act, callback:  callback));
    }
    public static System.Collections.IEnumerator DoCallFixedLerp(float duration, System.Action<float> act)
    {
        null = null;
        return MonoBehaviourExtensions.DoCallFixedLerp(duration:  duration, act:  act, callback:  ActionExtensions.EmptyAction);
    }
    public static System.Collections.IEnumerator DoCallFixedLerp(float duration, System.Action<float> act, System.Action callback)
    {
        MonoBehaviourExtensions.<DoCallFixedLerp>d__23 val_1 = new MonoBehaviourExtensions.<DoCallFixedLerp>d__23();
        .<>1__state = 0;
        if(val_1 != null)
        {
                .duration = duration;
            .act = act;
        }
        else
        {
                mem[40] = duration;
            mem[32] = act;
        }
        
        .callback = callback;
        return (System.Collections.IEnumerator)val_1;
    }
    public static UnityEngine.Coroutine CallLerpSmooth(UnityEngine.MonoBehaviour monoBehaviour, float duration, System.Action<float> act)
    {
        null = null;
        return MonoBehaviourExtensions.CallLerpSmooth(monoBehaviour:  monoBehaviour, duration:  duration, act:  act, callback:  ActionExtensions.EmptyAction);
    }
    public static UnityEngine.Coroutine CallLerpSmooth(UnityEngine.MonoBehaviour monoBehaviour, float duration, System.Action<float> act, System.Action callback)
    {
        if(monoBehaviour != null)
        {
                return monoBehaviour.StartCoroutine(routine:  MonoBehaviourExtensions.DoCallLerpSmooth(duration:  duration, act:  act, callback:  callback));
        }
        
        return monoBehaviour.StartCoroutine(routine:  MonoBehaviourExtensions.DoCallLerpSmooth(duration:  duration, act:  act, callback:  callback));
    }
    public static System.Collections.IEnumerator DoCallLerpSmooth(float duration, System.Action<float> act)
    {
        null = null;
        return MonoBehaviourExtensions.DoCallLerpSmooth(duration:  duration, act:  act, callback:  ActionExtensions.EmptyAction);
    }
    public static System.Collections.IEnumerator DoCallLerpSmooth(float duration, System.Action<float> act, System.Action callback)
    {
        MonoBehaviourExtensions.<DoCallLerpSmooth>d__27 val_1 = new MonoBehaviourExtensions.<DoCallLerpSmooth>d__27();
        .<>1__state = 0;
        if(val_1 != null)
        {
                .duration = duration;
            .act = act;
        }
        else
        {
                mem[40] = duration;
            mem[32] = act;
        }
        
        .callback = callback;
        return (System.Collections.IEnumerator)val_1;
    }
    public static UnityEngine.Coroutine CallLerpRealtime(UnityEngine.MonoBehaviour monoBehaviour, float duration, System.Action<float> act)
    {
        null = null;
        return MonoBehaviourExtensions.CallLerpRealtime(monoBehaviour:  monoBehaviour, duration:  duration, act:  act, callback:  ActionExtensions.EmptyAction);
    }
    public static UnityEngine.Coroutine CallLerpRealtime(UnityEngine.MonoBehaviour monoBehaviour, float duration, System.Action<float> act, System.Action callback)
    {
        if(monoBehaviour != null)
        {
                return monoBehaviour.StartCoroutine(routine:  MonoBehaviourExtensions.DoCallLerpRealtime(duration:  duration, act:  act, callback:  callback));
        }
        
        return monoBehaviour.StartCoroutine(routine:  MonoBehaviourExtensions.DoCallLerpRealtime(duration:  duration, act:  act, callback:  callback));
    }
    public static System.Collections.IEnumerator DoCallLerpRealtime(float duration, System.Action<float> act)
    {
        null = null;
        return MonoBehaviourExtensions.DoCallLerpRealtime(duration:  duration, act:  act, callback:  ActionExtensions.EmptyAction);
    }
    public static System.Collections.IEnumerator DoCallLerpRealtime(float duration, System.Action<float> act, System.Action callback)
    {
        MonoBehaviourExtensions.<DoCallLerpRealtime>d__31 val_1 = new MonoBehaviourExtensions.<DoCallLerpRealtime>d__31();
        .<>1__state = 0;
        if(val_1 != null)
        {
                .duration = duration;
            .act = act;
        }
        else
        {
                mem[40] = duration;
            mem[32] = act;
        }
        
        .callback = callback;
        return (System.Collections.IEnumerator)val_1;
    }
    public static UnityEngine.Coroutine CallTimer(UnityEngine.MonoBehaviour monoBehaviour, float seconds, float interval, System.Action<int> action)
    {
        null = null;
        return MonoBehaviourExtensions.CallTimer(monoBehaviour:  monoBehaviour, seconds:  seconds, firstTime:  0f, interval:  interval, action:  action, callback:  ActionExtensions.EmptyAction);
    }
    public static UnityEngine.Coroutine CallTimer(UnityEngine.MonoBehaviour monoBehaviour, float seconds, float interval, System.Action<int> action, System.Action callback)
    {
        if(monoBehaviour != null)
        {
                return monoBehaviour.StartCoroutine(routine:  MonoBehaviourExtensions.DoCallTimer(seconds:  seconds, firstTime:  0f, interval:  interval, action:  action, callback:  callback));
        }
        
        return monoBehaviour.StartCoroutine(routine:  MonoBehaviourExtensions.DoCallTimer(seconds:  seconds, firstTime:  0f, interval:  interval, action:  action, callback:  callback));
    }
    public static UnityEngine.Coroutine CallTimer(UnityEngine.MonoBehaviour monoBehaviour, float seconds, float firstTime, float interval, System.Action<int> action)
    {
        null = null;
        return MonoBehaviourExtensions.CallTimer(monoBehaviour:  monoBehaviour, seconds:  seconds, firstTime:  firstTime, interval:  interval, action:  action, callback:  ActionExtensions.EmptyAction);
    }
    public static UnityEngine.Coroutine CallTimer(UnityEngine.MonoBehaviour monoBehaviour, float seconds, float firstTime, float interval, System.Action<int> action, System.Action callback)
    {
        if(monoBehaviour != null)
        {
                return monoBehaviour.StartCoroutine(routine:  MonoBehaviourExtensions.DoCallTimer(seconds:  seconds, firstTime:  firstTime, interval:  interval, action:  action, callback:  callback));
        }
        
        return monoBehaviour.StartCoroutine(routine:  MonoBehaviourExtensions.DoCallTimer(seconds:  seconds, firstTime:  firstTime, interval:  interval, action:  action, callback:  callback));
    }
    private static System.Collections.IEnumerator DoCallTimer(float seconds, float firstTime, float interval, System.Action<int> action, System.Action callback)
    {
        MonoBehaviourExtensions.<DoCallTimer>d__36 val_1 = new MonoBehaviourExtensions.<DoCallTimer>d__36();
        .<>1__state = 0;
        if(val_1 != null)
        {
                .seconds = seconds;
            .firstTime = firstTime;
            .interval = interval;
            .action = action;
        }
        else
        {
                mem[48] = seconds;
            mem[32] = firstTime;
            .interval = interval;
            mem[40] = action;
        }
        
        .callback = callback;
        return (System.Collections.IEnumerator)val_1;
    }
    public static UnityEngine.Coroutine CallTimerRealtime(UnityEngine.MonoBehaviour monoBehaviour, float seconds, float interval, System.Action<int> action, System.Action callback)
    {
        if(monoBehaviour != null)
        {
                return monoBehaviour.StartCoroutine(routine:  MonoBehaviourExtensions.DoCallTimerRealtime(seconds:  seconds, interval:  interval, action:  action, callback:  callback));
        }
        
        return monoBehaviour.StartCoroutine(routine:  MonoBehaviourExtensions.DoCallTimerRealtime(seconds:  seconds, interval:  interval, action:  action, callback:  callback));
    }
    private static System.Collections.IEnumerator DoCallTimerRealtime(float seconds, float interval, System.Action<int> action, System.Action callback)
    {
        MonoBehaviourExtensions.<DoCallTimerRealtime>d__38 val_1 = new MonoBehaviourExtensions.<DoCallTimerRealtime>d__38();
        .<>1__state = 0;
        if(val_1 != null)
        {
                .interval = interval;
            .seconds = seconds;
            .action = action;
        }
        else
        {
                .seconds = seconds;
            mem[40] = interval;
            mem[32] = action;
        }
        
        .callback = callback;
        return (System.Collections.IEnumerator)val_1;
    }

}
