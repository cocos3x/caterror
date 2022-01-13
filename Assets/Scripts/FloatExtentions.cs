using UnityEngine;
public static class FloatExtentions
{
    // Fields
    public static float Epsilon;
    
    // Methods
    public static string ToTimeString(float f)
    {
        object val_9;
        System.TimeSpan val_1 = System.TimeSpan.FromSeconds(value:  (double)f);
        val_9 = System.String.Format(format:  "{0:D2}\'{1:D2}\"{2:D3}", arg0:  val_1._ticks.Minutes, arg1:  val_1._ticks.Seconds, arg2:  val_1._ticks.Milliseconds);
        if(val_1._ticks.Hours < 1)
        {
                return (string)val_9;
        }
        
        val_9 = System.String.Format(format:  "{0:D2}:{1}", arg0:  val_1._ticks.Hours, arg1:  val_9);
        return (string)val_9;
    }
    public static string ToTimeString(float f, string secondsStr = "", string minutesStr = "", string hoursStr = "", string daysStr = "", bool isFull = False)
    {
        object val_24;
        int val_25;
        int val_26;
        System.TimeSpan val_1 = System.TimeSpan.FromSeconds(value:  (double)f);
        val_24 = "";
        int val_2 = val_1._ticks.Days;
        int val_24 = val_1._ticks.Hours;
        val_25 = val_1._ticks.Minutes;
        val_26 = val_1._ticks.Seconds;
        if(daysStr.Length < 1)
        {
            goto label_4;
        }
        
        if(val_2 >= 1)
        {
                val_24 = System.String.Format(format:  "{0}{1}", arg0:  val_2, arg1:  daysStr);
        }
        
        label_14:
        if(hoursStr.Length < 1)
        {
            goto label_7;
        }
        
        if(val_24 <= 0)
        {
            goto label_8;
        }
        
        label_19:
        if(val_24.Length < 1)
        {
            goto label_10;
        }
        
        val_24 = System.String.Format(format:  "{0}{1:D2}{2}", arg0:  val_24, arg1:  val_24, arg2:  hoursStr);
        if(minutesStr != null)
        {
            goto label_21;
        }
        
        goto label_16;
        label_4:
        val_24 = val_24 + (val_2 * 24);
        if(hoursStr != null)
        {
            goto label_14;
        }
        
        goto label_14;
        label_7:
        val_25 = val_25 + (val_24 * 60);
        if(minutesStr != null)
        {
            goto label_21;
        }
        
        goto label_16;
        label_8:
        if(isFull == false)
        {
            goto label_20;
        }
        
        if(val_24.Length >= 1)
        {
            goto label_19;
        }
        
        goto label_20;
        label_10:
        val_24 = System.String.Format(format:  "{0}{1}", arg0:  val_24, arg1:  hoursStr);
        label_20:
        if(minutesStr != null)
        {
            goto label_21;
        }
        
        label_16:
        label_21:
        if(minutesStr.Length < 1)
        {
            goto label_22;
        }
        
        if(val_25 <= 0)
        {
            goto label_23;
        }
        
        label_32:
        if(val_24.Length < 1)
        {
            goto label_25;
        }
        
        val_24 = System.String.Format(format:  "{0}{1:D2}{2}", arg0:  val_24, arg1:  val_25, arg2:  minutesStr);
        if(secondsStr != null)
        {
            goto label_34;
        }
        
        goto label_29;
        label_22:
        val_26 = val_26 + (val_25 * 60);
        if(secondsStr != null)
        {
            goto label_34;
        }
        
        goto label_29;
        label_23:
        if(isFull == false)
        {
            goto label_33;
        }
        
        if(val_24.Length >= 1)
        {
            goto label_32;
        }
        
        goto label_33;
        label_25:
        val_24 = System.String.Format(format:  "{0}{1}", arg0:  val_25, arg1:  minutesStr);
        label_33:
        if(secondsStr != null)
        {
            goto label_34;
        }
        
        label_29:
        label_34:
        if(secondsStr.Length < 1)
        {
                return (string)val_24;
        }
        
        if((val_26 <= 0) && (val_24.Length != 0))
        {
                if(isFull == false)
        {
                return (string)val_24;
        }
        
            if(val_24.Length < 1)
        {
                return (string)val_24;
        }
        
        }
        
        if(val_24.Length >= 1)
        {
                string val_22 = System.String.Format(format:  "{0}{1:D2}{2}", arg0:  val_24, arg1:  val_26, arg2:  secondsStr);
        }
        
        val_24 = System.String.Format(format:  "{0}{1}", arg0:  val_26, arg1:  secondsStr);
        return (string)val_24;
    }
    public static string ToTimerString(float f)
    {
        object val_11;
        System.TimeSpan val_1 = System.TimeSpan.FromSeconds(value:  (double)f);
        val_11 = System.String.Format(format:  "{0:D2}", arg0:  val_1._ticks.Seconds);
        if(val_1._ticks.Minutes <= 0)
        {
                if(val_1._ticks.Hours < 1)
        {
            goto label_4;
        }
        
        }
        
        val_11 = System.String.Format(format:  "{0:D2}:{1}", arg0:  val_1._ticks.Minutes, arg1:  val_11);
        label_4:
        if(val_1._ticks.Hours < 1)
        {
                return (string)val_11;
        }
        
        val_11 = System.String.Format(format:  "{0:D2}:{1}", arg0:  val_1._ticks.Hours, arg1:  val_11);
        return (string)val_11;
    }
    public static string ToTimerString(float f, string secondsStr, string minutesStr, string hoursStr, string daysStr, bool isFull = True)
    {
        object val_29;
        int val_30;
        var val_31;
        string val_32;
        object val_33;
        object val_34;
        System.TimeSpan val_1 = System.TimeSpan.FromSeconds(value:  (double)f);
        val_29 = "";
        int val_2 = val_1._ticks.Days;
        int val_29 = val_1._ticks.Hours;
        val_30 = val_1._ticks.Minutes;
        val_31 = val_1._ticks.Seconds;
        if(daysStr.Length < 1)
        {
            goto label_4;
        }
        
        if(val_2 < 1)
        {
            goto label_5;
        }
        
        if(isFull == false)
        {
            goto label_6;
        }
        
        val_29 = System.String.Format(format:  "{0}{1}", arg0:  val_2, arg1:  daysStr);
        label_5:
        label_15:
        if(hoursStr.Length < 1)
        {
            goto label_8;
        }
        
        if(val_29 <= 0)
        {
            goto label_9;
        }
        
        label_21:
        if(val_29.Length < 1)
        {
            goto label_11;
        }
        
        val_29 = System.String.Format(format:  "{0}{1:D2}{2}", arg0:  val_29, arg1:  val_29, arg2:  hoursStr);
        if(minutesStr != null)
        {
            goto label_17;
        }
        
        goto label_17;
        label_4:
        val_29 = val_29 + (val_2 * 24);
        if(hoursStr != null)
        {
            goto label_15;
        }
        
        goto label_15;
        label_8:
        val_30 = val_30 + (val_29 * 60);
        if(minutesStr != null)
        {
            goto label_17;
        }
        
        goto label_17;
        label_6:
        val_32 = "{0}{1}";
        val_33 = val_2 + 1;
        val_34 = daysStr;
        goto label_50;
        label_9:
        if(isFull == false)
        {
            goto label_22;
        }
        
        if(val_29.Length >= 1)
        {
            goto label_21;
        }
        
        goto label_22;
        label_11:
        if(isFull == false)
        {
            goto label_23;
        }
        
        val_29 = System.String.Format(format:  "{0}{1}", arg0:  val_29, arg1:  hoursStr);
        label_22:
        label_17:
        if(minutesStr.Length < 1)
        {
            goto label_25;
        }
        
        if(val_30 <= 0)
        {
            goto label_26;
        }
        
        label_35:
        if(val_29.Length < 1)
        {
            goto label_28;
        }
        
        val_29 = System.String.Format(format:  "{0}{1:D2}{2}", arg0:  val_29, arg1:  val_30, arg2:  minutesStr);
        if(secondsStr != null)
        {
            goto label_32;
        }
        
        goto label_32;
        label_25:
        val_31 = val_31 + (val_30 * 60);
        if(secondsStr != null)
        {
            goto label_32;
        }
        
        goto label_32;
        label_26:
        if(isFull == false)
        {
            goto label_36;
        }
        
        if(val_29.Length >= 1)
        {
            goto label_35;
        }
        
        goto label_36;
        label_28:
        if(isFull == false)
        {
            goto label_37;
        }
        
        val_29 = System.String.Format(format:  "{0}{1}", arg0:  val_30, arg1:  minutesStr);
        label_36:
        label_32:
        if(secondsStr.Length < 1)
        {
                return (string)val_29;
        }
        
        if((val_31 <= 0) && (val_29.Length != 0))
        {
                if(isFull == false)
        {
                return (string)val_29;
        }
        
            if(val_29.Length < 1)
        {
                return (string)val_29;
        }
        
        }
        
        if(val_29.Length < 1)
        {
            goto label_47;
        }
        
        string val_24 = System.String.Format(format:  "{0}{1:D2}{2}", arg0:  val_29, arg1:  val_31 + 1, arg2:  secondsStr);
        goto label_48;
        label_47:
        val_32 = "{0}{1}";
        val_33 = val_31 + 1;
        val_34 = secondsStr;
        goto label_50;
        label_23:
        val_32 = "{0}{1}";
        val_33 = val_29 + 1;
        val_34 = hoursStr;
        goto label_50;
        label_37:
        int val_27 = val_30 + 1;
        val_32 = "{0}{1}";
        val_33 = val_27;
        val_34 = minutesStr;
        label_50:
        label_48:
        val_29 = System.String.Format(format:  val_32, arg0:  val_27, arg1:  val_34);
        return (string)val_29;
    }
    public static string ToTimeStringJ(float f, bool isFull = False)
    {
        return FloatExtentions.ToTimeString(f:  f, secondsStr:  "秒", minutesStr:  "分", hoursStr:  "時間", daysStr:  "日", isFull:  isFull);
    }
    public static string ToTimerStringJ(float f)
    {
        float val_1 = 1f;
        val_1 = f + val_1;
        return FloatExtentions.ToTimeStringJ(f:  val_1, isFull:  true);
    }
    public static float Floor(float f, uint i)
    {
        if(i == 0)
        {
                return (float)f;
        }
        
        float val_1 = 10f;
        var val_2 = 0;
        val_1 = val_1 * f;
        val_2 = val_2 - i;
        float val_3 = 10f;
        val_3 = f * val_3;
        return (float)f;
    }
    public static float EaseInQuadratic(float t)
    {
        t = t * t;
        return (float)t;
    }
    public static float EaseOutQuadratic(float t)
    {
        float val_1 = -2f;
        val_1 = t + val_1;
        t = -(val_1 * t);
        return (float)t;
    }
    public static float EaseInOutQuadratic(float t)
    {
        float val_1;
        float val_2;
        val_1 = t + t;
        if(val_1 < 0)
        {
                val_2 = val_1 * 0.5f;
        }
        else
        {
                float val_1 = -2f;
            val_1 = val_1 + (-1f);
            val_1 = val_1 + val_1;
            val_1 = val_1 * val_1;
            val_1 = val_1 + (-1f);
            val_2 = -0.5f;
        }
        
        val_1 = val_1 * val_2;
        return (float)val_1;
    }
    public static float EaseInCubic(float t)
    {
        t = (t * t) * t;
        return (float)t;
    }
    public static float EaseOutCubic(float t)
    {
        float val_1 = -1f;
        t = t + val_1;
        val_1 = t * t;
        t = t * val_1;
        t = t + 1f;
        return (float)t;
    }
    public static float EaseInOutCubic(float t)
    {
        float val_1;
        float val_2;
        val_1 = t + t;
        if(val_1 < 0)
        {
                float val_1 = 0.5f;
            val_1 = val_1 * val_1;
            val_2 = val_1 * val_1;
        }
        else
        {
                float val_2 = -2f;
            val_1 = val_1 + val_2;
            val_2 = val_1 * val_1;
            val_1 = val_1 * val_2;
            val_1 = val_1 + 2f;
            val_2 = 0.5f;
        }
        
        val_1 = val_1 * val_2;
        return (float)val_1;
    }
    public static float EaseInQuartic(float t)
    {
        float val_1 = t * t;
        val_1 = val_1 * t;
        t = val_1 * t;
        return (float)t;
    }
    public static float EaseOutQuartic(float t)
    {
        t = t + (-1f);
        float val_1 = t * t;
        val_1 = t * val_1;
        t = t * val_1;
        t = t + (-1f);
        return (float)-t;
    }
    public static float EaseInOutQuartic(float t)
    {
        float val_2;
        float val_3;
        val_2 = t + t;
        if(val_2 < 0)
        {
                float val_2 = 0.5f;
            val_2 = val_2 * val_2;
            val_2 = val_2 * val_2;
            val_3 = val_2 * val_2;
        }
        else
        {
                val_2 = val_2 + (-2f);
            float val_1 = val_2 * val_2;
            val_1 = val_2 * val_1;
            val_2 = val_2 * val_1;
            val_2 = val_2 + (-2f);
            val_3 = -0.5f;
        }
        
        val_2 = val_2 * val_3;
        return (float)val_2;
    }
    public static float EaseInQuintic(float t)
    {
        float val_1 = t * t;
        val_1 = val_1 * t;
        val_1 = val_1 * t;
        t = val_1 * t;
        return (float)t;
    }
    public static float EaseOutQuintic(float t)
    {
        float val_1 = -1f;
        t = t + val_1;
        val_1 = t * t;
        val_1 = t * val_1;
        val_1 = t * val_1;
        t = t * val_1;
        t = t + 1f;
        return (float)t;
    }
    public static float EaseInOutQuintic(float t)
    {
        float val_1;
        float val_2;
        val_1 = t + t;
        if(val_1 < 0)
        {
                float val_1 = 0.5f;
            val_1 = val_1 * val_1;
            val_1 = val_1 * val_1;
            val_1 = val_1 * val_1;
            val_2 = val_1 * val_1;
        }
        else
        {
                float val_2 = -2f;
            val_1 = val_1 + val_2;
            val_2 = val_1 * val_1;
            val_2 = val_1 * val_2;
            val_2 = val_1 * val_2;
            val_1 = val_1 * val_2;
            val_1 = val_1 + 2f;
            val_2 = 0.5f;
        }
        
        val_1 = val_1 * val_2;
        return (float)val_1;
    }
    public static float EaseInSinusoidal(float t)
    {
        float val_1 = 1.570796f;
        val_1 = t * val_1;
        val_1 = 1f - val_1;
        return (float)val_1;
    }
    public static float EaseOutSinusoidal(float t)
    {
        float val_1 = 1.570796f;
        val_1 = t * val_1;
    }
    public static float EaseInOutSinusoidal(float t)
    {
        float val_1 = 3.141593f;
        val_1 = t * val_1;
        val_1 = val_1 + (-1f);
        val_1 = val_1 * (-0.5f);
        return (float)val_1;
    }
    public static float EaseInCircular(float t)
    {
        float val_1;
        t = t * t;
        float val_1 = 1f;
        val_1 = val_1 - t;
        if(t >= _TYPE_MAX_)
        {
                val_1 = val_1;
        }
        
        val_1 = val_1 + (-1f);
        return (float)-val_1;
    }
    public static float EaseOutCircular(float t)
    {
        float val_1 = t;
        float val_2 = -1f;
        val_1 = val_1 + val_2;
        val_2 = val_1 * val_1;
        val_2 = 1f - val_2;
        if(1f <= _TYPE_MAX_)
        {
                return 1f;
        }
    
    }
    public static float EaseInOutCircular(float t)
    {
        float val_3;
        float val_4;
        float val_5;
        float val_6;
        float val_1 = t + t;
        if(val_1 < 0)
        {
                val_3 = val_1 * val_1;
            val_4 = -0.5f;
            val_5 = -1f;
        }
        else
        {
                val_1 = val_1 + (-2f);
            val_3 = val_1 * val_1;
            val_4 = 0.5f;
            val_5 = 1f;
        }
        
        if(val_3 >= _TYPE_MAX_)
        {
                val_6 = 1f - val_3;
        }
        
        val_6 = val_5 + val_6;
        val_6 = val_4 * val_6;
        return (float)val_6;
    }
    private static FloatExtentions()
    {
        FloatExtentions.Epsilon = 1.192093E-07f;
    }

}
