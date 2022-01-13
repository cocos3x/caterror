using UnityEngine;
public class Impression : MonoBehaviour
{
    // Fields
    public string sort;
    public string position;
    
    // Methods
    private void OnEnable()
    {
        JoypacAnalyticsManager.DesignEvent(_logType:  32, sort:  this.sort, type:  "impression", position:  this.position, onlyFirst:  false, extra:  "");
    }
    public Impression()
    {
    
    }

}
