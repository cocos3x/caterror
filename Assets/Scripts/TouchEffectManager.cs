using UnityEngine;
public class TouchEffectManager : SingletonMonoBehaviour<TouchEffectManager>
{
    // Fields
    private UnityEngine.Transform effectPrefab;
    private System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> raycastResults;
    
    // Methods
    private void Awake()
    {
        bool val_1 = this.CheckInstance();
    }
    private void Update()
    {
        UnityEngine.Object val_22;
        var val_23;
        float val_24;
        UnityEngine.Object val_25;
        if((UnityEngine.Input.GetMouseButtonDown(button:  0)) == false)
        {
                return;
        }
        
        val_22 = UnityEngine.Camera.main;
        UnityEngine.Camera[] val_3 = UnityEngine.Camera.allCameras;
        if(val_3.Length < 2)
        {
            goto label_3;
        }
        
        val_23 = 0;
        val_24 = -10f;
        goto label_4;
        label_10:
        UnityEngine.Camera val_22 = UnityEngine.Camera.allCameras[0];
        float val_5 = val_22.depth;
        if(val_24 < 0)
        {
                val_24 = val_22.depth;
            val_22 = val_22;
        }
        
        val_23 = 1;
        label_4:
        if(val_23 < val_4.Length)
        {
            goto label_10;
        }
        
        label_3:
        val_25 = 1152921504793800704;
        if(val_22 == 0)
        {
                return;
        }
        
        val_25 = UnityEngine.EventSystems.EventSystem.current;
        if(val_25 == 0)
        {
            goto label_35;
        }
        
        UnityEngine.EventSystems.PointerEventData val_10 = new UnityEngine.EventSystems.PointerEventData(eventSystem:  val_25);
        UnityEngine.Vector3 val_11 = UnityEngine.Input.mousePosition;
        UnityEngine.Vector2 val_12 = Vector3Extensions.ToVector2(v:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
        val_24 = val_12.x;
        val_10.position = new UnityEngine.Vector2() {x = val_24, y = val_12.y};
        this.raycastResults.Clear();
        val_25.RaycastAll(eventData:  val_10, raycastResults:  this.raycastResults);
        val_25 = this.raycastResults;
        List.Enumerator<T> val_13 = val_25.GetEnumerator();
        val_23 = 1152921512127440160;
        label_28:
        if(((-1069315160) & 1) == 0)
        {
            goto label_25;
        }
        
        val_25 = Id.name;
        if((val_25.Contains(value:  "shareButton")) == false)
        {
            goto label_28;
        }
        
        UniRx.Unit..cctor();
        return;
        label_25:
        UniRx.Unit..cctor();
        label_35:
        UnityEngine.Vector3 val_18 = UnityEngine.Input.mousePosition;
        UnityEngine.Vector3 val_19 = val_22.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z});
        UnityEngine.Vector3 val_20 = Vector3Extensions.SetZ(v:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z}, f:  0f);
        val_24 = val_20.x;
        this.InstantiateEffect(position:  new UnityEngine.Vector3() {x = val_24, y = val_20.y, z = val_20.z}, parent:  this.transform);
    }
    private void InstantiateEffect(UnityEngine.Vector3 position, UnityEngine.Transform parent)
    {
        UnityEngine.Quaternion val_1 = UnityEngine.Quaternion.identity;
        UnityEngine.Transform val_2 = UnityEngine.Object.Instantiate<UnityEngine.Transform>(original:  this.effectPrefab, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, rotation:  new UnityEngine.Quaternion() {x = val_1.x, y = val_1.y, z = val_1.z, w = val_1.w}, parent:  parent);
    }
    public void AllDestroyEffects()
    {
        var val_14;
        var val_15;
        System.Collections.IEnumerator val_2 = this.transform.GetEnumerator();
        goto label_17;
        label_24:
        var val_14 = 0;
        val_14 = val_14 + 1;
        object val_4 = val_2.Current;
        if((0.name.Contains(value:  this.effectPrefab.name)) != false)
        {
                UnityEngine.Object.Destroy(obj:  0.gameObject);
        }
        
        label_17:
        var val_15 = 0;
        val_15 = val_15 + 1;
        if(val_2.MoveNext() == true)
        {
            goto label_24;
        }
        
        val_14 = 0;
        val_15 = 0;
        if(val_2 != null)
        {
                var val_16 = 0;
            val_16 = val_16 + 1;
            val_2.Dispose();
        }
        
        if( != 1)
        {
                return;
        }
        
        if( == false)
        {
                return;
        }
    
    }
    public TouchEffectManager()
    {
        this.raycastResults = new System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult>();
    }

}
