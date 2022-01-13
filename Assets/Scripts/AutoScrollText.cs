using UnityEngine;
public class AutoScrollText : MonoBehaviour
{
    // Fields
    private UnityEngine.RectTransform rectTransform;
    private float parentSizeX;
    public float speed;
    
    // Methods
    private void Awake()
    {
        this.rectTransform = this.GetComponent<UnityEngine.RectTransform>();
        UnityEngine.Rect val_5 = this.transform.parent.GetComponent<UnityEngine.RectTransform>().rect;
        this.parentSizeX = val_5.m_XMin;
    }
    private void OnEnable()
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.Scroll());
    }
    private System.Collections.IEnumerator Scroll()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new AutoScrollText.<Scroll>d__5();
    }
    public AutoScrollText()
    {
        this.speed = 100f;
    }

}
