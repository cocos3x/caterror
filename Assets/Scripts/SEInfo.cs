using UnityEngine;
[Serializable]
public sealed class SEInfo
{
    // Fields
    private float delay;
    private float time;
    private float interval;
    private string filename;
    private int maxCount;
    
    // Properties
    public float Delay { get; }
    public float Time { get; }
    public float Interval { get; }
    public string Filename { get; }
    public int MaxCount { get; }
    
    // Methods
    public float get_Delay()
    {
        return (float)this.delay;
    }
    public float get_Time()
    {
        return (float)this.time;
    }
    public float get_Interval()
    {
        return (float)this.interval;
    }
    public string get_Filename()
    {
        return "Sounds/SE/"("Sounds/SE/") + this.filename;
    }
    public int get_MaxCount()
    {
        return (int)this.maxCount;
    }
    public SEInfo()
    {
    
    }

}
