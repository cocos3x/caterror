using UnityEngine;
public class AnimateHierarchyOrder : MonoBehaviour
{
    // Fields
    public float siblingOrder;
    
    // Methods
    private void Awake()
    {
        this.siblingOrder = (float)this.transform.GetSiblingIndex();
    }
    private void OnValidate()
    {
        var val_1;
        var val_8;
        float val_9;
        if(this.siblingOrder >= 0f)
        {
            goto label_3;
        }
        
        if((double)this.siblingOrder != (-0.5))
        {
            goto label_4;
        }
        
        val_8 = val_1;
        val_9 = -1f;
        goto label_5;
        label_3:
        if((double)this.siblingOrder != 0.5)
        {
            goto label_6;
        }
        
        val_8 = val_1;
        val_9 = 1f;
        label_5:
        val_9 = (float)val_8 + val_9;
        var val_2 = (((long)val_8 & 1) != 0) ? ((float)val_8) : (val_9);
        goto label_8;
        label_4:
        float val_8 = -0.5f;
        val_8 = this.siblingOrder + val_8;
        goto label_8;
        label_6:
        float val_9 = 0.5f;
        val_9 = this.siblingOrder + val_9;
        label_8:
        this.siblingOrder = this.siblingOrder;
        if(this.siblingOrder == (float)this.transform.GetSiblingIndex())
        {
                return;
        }
        
        this.transform.SetSiblingIndex(index:  (int)this.siblingOrder);
        this.siblingOrder = (float)this.transform.GetSiblingIndex();
    }
    private void OnDidApplyAnimationProperties()
    {
        this.OnValidate();
    }
    public void UpdateOrder(int siblingOrder)
    {
        this.siblingOrder = (float)siblingOrder;
        this.OnValidate();
    }
    public void UpdateOrder()
    {
        this.OnValidate();
    }
    public AnimateHierarchyOrder()
    {
    
    }

}
