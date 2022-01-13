using UnityEngine;
public sealed class SparrowShelter : Shelter
{
    // Fields
    private UnityEngine.Transform waitTransform;
    private UnityEngine.Transform flyTransform;
    private UnityEngine.Collider2D collider2d;
    private UnityEngine.GameObject shadow;
    private UnityEngine.Animator animator;
    private UnityEngine.Rect cameraRect;
    private UnityEngine.Camera mainCamera;
    private bool isFlying;
    
    // Methods
    private void Awake()
    {
        this.mainCamera = UnityEngine.Camera.main;
    }
    private void Update()
    {
        if(this.isFlying == true)
        {
                return;
        }
        
        if((SingletonMonoBehaviour<Cat>.Instance.IsSearching) == false)
        {
                return;
        }
        
        UnityEngine.Vector3 val_4 = this.transform.position;
        UnityEngine.Vector3 val_5 = this.mainCamera.WorldToViewportPoint(position:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        if((this.cameraRect & 1) == 0)
        {
                return;
        }
        
        this.isFlying = true;
        this.animator.SetTrigger(name:  "Found");
    }
    public void OnFly()
    {
        .<>4__this = this;
        this.shadow.SetActive(value:  false);
        this.waitTransform.gameObject.SetActive(value:  false);
        this.flyTransform.gameObject.SetActive(value:  true);
        UnityEngine.Vector3 val_4 = this.flyTransform.position;
        float val_7 = 20f;
        val_7 = val_4.y + val_7;
        .from = val_4.y;
        .to = val_7;
        UnityEngine.Coroutine val_6 = MonoBehaviourExtensions.CallLerp(monoBehaviour:  this, duration:  1f, act:  new System.Action<System.Single>(object:  new SparrowShelter.<>c__DisplayClass10_0(), method:  System.Void SparrowShelter.<>c__DisplayClass10_0::<OnFly>b__0(float t)));
        UnityEngine.Object.Destroy(obj:  this.collider2d);
        this.collider2d = 0;
    }
    public SparrowShelter()
    {
        this.cameraRect = 0;
        mem[1152921511934358036] = 0;
        mem[1152921511934358044] = 0;
        this = new UnityEngine.MonoBehaviour();
    }

}
