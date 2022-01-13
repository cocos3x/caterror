using UnityEngine;
public class ScrollNormalizedPositionInitializer : MonoBehaviour
{
    // Fields
    private bool initializeHorizontal;
    private bool initializeVertical;
    private int firstIndex;
    
    // Methods
    private void Start()
    {
        int val_16;
        var val_17;
        var val_19;
        var val_21;
        var val_22;
        int val_25;
        val_16 = this;
        UnityEngine.UI.ScrollRect val_1 = this.GetComponent<UnityEngine.UI.ScrollRect>();
        System.Collections.IEnumerator val_3 = val_1.content.GetEnumerator();
        val_17 = 0;
        goto label_3;
        label_21:
        var val_18 = 0;
        val_18 = val_18 + 1;
        val_19 = val_3.Current;
        if(val_19 != null)
        {
                val_19 = 0;
        }
        
        val_17 = val_17 + val_19.gameObject.activeSelf;
        label_3:
        var val_19 = 0;
        val_19 = val_19 + 1;
        if(val_3.MoveNext() == true)
        {
            goto label_21;
        }
        
        val_21 = 0;
        val_22 = 0;
        val_25 = val_3;
        if(val_25 != null)
        {
                var val_20 = 0;
            val_20 = val_20 + 1;
            val_25.Dispose();
        }
        
        if(this.initializeHorizontal != false)
        {
                val_25 = this.firstIndex;
            float val_21 = (float)val_25;
            val_21 = val_21 + 1f;
            val_21 = val_21 / ((float)val_17 - 1);
            val_1.horizontalNormalizedPosition = val_21;
        }
        
        if(this.initializeVertical == false)
        {
                return;
        }
        
        val_16 = this.firstIndex;
        float val_22 = (float)val_16;
        val_22 = val_22 + 1f;
        val_22 = val_22 / ((float)val_17 - 1);
        val_22 = 1f - val_22;
        val_1.verticalNormalizedPosition = val_22;
    }
    public ScrollNormalizedPositionInitializer()
    {
        this.firstIndex = 1;
    }

}
