using UnityEngine;
public class LimitTrailRenderer : MonoBehaviour
{
    // Fields
    private float time;
    private float length;
    private UnityEngine.LineRenderer[] lineRendererArray;
    private System.Collections.Generic.List<System.ValueTuple<float, UnityEngine.Vector3>> worldList;
    private System.Collections.Generic.List<UnityEngine.Vector3> localList;
    
    // Methods
    private void OnEnable()
    {
        this.worldList.Clear();
    }
    private void LateUpdate()
    {
        UnityEngine.LineRenderer val_41;
        var val_42;
        var val_43;
        float val_44;
        float val_45;
        float val_46;
        float val_47;
        float val_48;
        var val_49;
        float val_50;
        float val_51;
        var val_52;
        var val_53;
        var val_54;
        float val_55;
        var val_56;
        val_41 = this;
        val_42 = 1152921512105475456;
        val_43 = 0;
        goto label_1;
        label_5:
        System.ValueTuple<System.Single, UnityEngine.Vector3> val_2 = X21.Item[0];
        val_44 = V2.16B;
        val_45 = UnityEngine.Time.deltaTime + UnityEngine.Time.deltaTime;
        this.worldList.set_Item(index:  0, value:  new System.ValueTuple<System.Single, UnityEngine.Vector3>() {Item2 = new UnityEngine.Vector3() {x = -0.4766045f, y = 2.524355E-29f}});
        val_43 = 1;
        label_1:
        if(val_43 < this.worldList.Count)
        {
            goto label_5;
        }
        
        UnityEngine.Vector3 val_5 = this.transform.position;
        val_46 = 0f;
        val_47 = 0f;
        this.worldList.Add(item:  new System.ValueTuple<System.Single, UnityEngine.Vector3>() {Item2 = new UnityEngine.Vector3() {x = -0.4771538f, y = 2.524355E-29f, z = -0.4766045f}});
        goto label_8;
        label_13:
        System.ValueTuple<System.Single, UnityEngine.Vector3> val_6 = this.worldList.Item[1];
        val_46 = this.time;
        if(0f <= val_46)
        {
            goto label_10;
        }
        
        this.worldList.RemoveAt(index:  0);
        label_8:
        if(this.worldList.Count >= 3)
        {
            goto label_13;
        }
        
        label_10:
        this.localList.Clear();
        UnityEngine.Vector3 val_9 = this.transform.position;
        System.Collections.Generic.List<System.ValueTuple<System.Single, UnityEngine.Vector3>> val_40 = this.worldList;
        val_48 = 0f;
        val_40 = val_40.Count - 1;
        if((val_40 & 2147483648) != 0)
        {
            goto label_18;
        }
        
        val_42 = 1152921504783470592;
        val_49 = 1152921512105523584;
        label_25:
        float val_41 = this.length;
        val_41 = val_41 * val_41;
        if(val_48 > val_41)
        {
            goto label_18;
        }
        
        System.ValueTuple<System.Single, UnityEngine.Vector3> val_11 = this.worldList.Item[val_40];
        val_45 = val_9.y;
        val_50 = 0f;
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_45, y = val_9.z, z = 0f}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
        val_44 = val_12.z;
        val_46 = val_9.z;
        val_47 = val_50;
        val_48 = val_48 + (Vector3Extensions.MagnitudeNotSqrt(v:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_44}));
        this.localList.Add(item:  new UnityEngine.Vector3() {x = val_45, y = val_46, z = 0f});
        val_40 = val_40 - 1;
        if((val_40 & 2147483648) == 0)
        {
            goto label_25;
        }
        
        label_18:
        if(this.localList.Count < 2)
        {
            goto label_35;
        }
        
        val_49 = 1152921512105537920;
        val_51 = 0f;
        val_52 = 1;
        goto label_28;
        label_34:
        int val_42 = 0;
        UnityEngine.Vector3 val_15 = this.localList.Item[0];
        val_44 = val_15.y;
        val_42 = val_42 + 1;
        UnityEngine.Vector3 val_16 = this.localList.Item[val_42];
        val_45 = val_16.x;
        val_50 = val_16.z;
        val_46 = val_44;
        val_47 = val_15.z;
        UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_15.x, y = val_46, z = val_47}, b:  new UnityEngine.Vector3() {x = val_45, y = val_16.y, z = val_50});
        val_51 = val_51 + val_17.x;
        val_52 = val_42 + 1;
        label_28:
        if(val_52 < (this.localList.Count - 1))
        {
            goto label_34;
        }
        
        if(val_51 > this.length)
        {
                if(this.localList != null)
        {
                val_53 = this.localList.Count;
        }
        else
        {
                val_53 = 0.Count;
        }
        
            UnityEngine.Vector3 val_24 = this.localList.Item[val_53 - 2];
            if(this.localList != null)
        {
                val_54 = this.localList.Count;
        }
        else
        {
                val_54 = 0.Count;
        }
        
            UnityEngine.Vector3 val_28 = this.localList.Item[val_54 - 1];
            if(this.localList != null)
        {
                val_42 = this.localList.Count;
        }
        else
        {
                val_42 = 0.Count;
        }
        
            UnityEngine.Vector3 val_32 = this.localList.Item[val_42 - 2];
            UnityEngine.Vector3 val_33 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z}, b:  new UnityEngine.Vector3() {x = val_32.x, y = val_32.y, z = val_32.z});
            float val_43 = this.length;
            val_43 = val_43 - val_51;
            UnityEngine.Vector3 val_34 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_33.x, y = val_33.y, z = val_33.z}, d:  val_43);
            val_45 = val_34.x;
            val_50 = val_34.z;
            if(val_34.x >= _TYPE_MAX_)
        {
                val_55 = val_48;
        }
        
            UnityEngine.Vector3 val_36 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_45, y = val_34.y, z = val_50}, d:  val_55 - val_51);
            UnityEngine.Vector3 val_37 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z}, b:  new UnityEngine.Vector3() {x = val_36.x, y = val_36.y, z = val_36.z});
            val_48 = val_37.x;
            val_44 = val_37.z;
            this.localList.set_Item(index:  this.localList.Count - 1, value:  new UnityEngine.Vector3() {x = val_48, y = val_37.y, z = val_44});
        }
        
        label_35:
        T[] val_39 = this.localList.ToArray();
        val_56 = 0;
        goto label_50;
        label_57:
        val_41 = this.lineRendererArray[0];
        if(val_39 == null)
        {
            goto label_52;
        }
        
        if(val_41 == null)
        {
            goto label_53;
        }
        
        label_55:
        val_41.positionCount = val_39.Length;
        goto label_54;
        label_52:
        if(val_41 != null)
        {
            goto label_55;
        }
        
        label_53:
        0.positionCount = val_39.Length;
        label_54:
        val_41.SetPositions(positions:  val_39);
        val_56 = 1;
        label_50:
        if(val_56 < this.lineRendererArray.Length)
        {
            goto label_57;
        }
    
    }
    public void InsertPosition(UnityEngine.Vector3 position, float deltaTime)
    {
        this.worldList.Add(item:  new System.ValueTuple<System.Single, UnityEngine.Vector3>() {Item2 = new UnityEngine.Vector3() {x = -0.4771538f, y = 2.524355E-29f}});
    }
    public void AddPosition(UnityEngine.Vector3 value)
    {
        goto label_1;
        label_7:
        System.ValueTuple<System.Single, UnityEngine.Vector3> val_1 = this.worldList.Item[0];
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = value.y, y = value.z, z = V3.16B}, b:  new UnityEngine.Vector3() {x = value.x, y = value.y, z = value.z});
        this.worldList.set_Item(index:  0, value:  new System.ValueTuple<System.Single, UnityEngine.Vector3>() {Item2 = new UnityEngine.Vector3() {x = -0.4766045f, y = 2.524355E-29f}});
        0 = 1;
        label_1:
        if(0 < this.worldList.Count)
        {
            goto label_7;
        }
    
    }
    public LimitTrailRenderer()
    {
        this.time = 1f;
        this.length = 0f;
        this.worldList = new System.Collections.Generic.List<System.ValueTuple<System.Single, UnityEngine.Vector3>>();
        this.localList = new System.Collections.Generic.List<UnityEngine.Vector3>();
    }

}
