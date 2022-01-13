using UnityEngine;
public class PlayGif : MonoBehaviour
{
    // Fields
    public UnityEngine.Sprite[] UIArray;
    public bool Loop;
    private UnityEngine.UI.Image image;
    public float playSpeed;
    private float interval;
    private bool isRun;
    private float timer;
    
    // Methods
    private void OnEnable()
    {
        this.image = this.GetComponent<UnityEngine.UI.Image>();
        this.isRun = true;
        UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.TUI());
    }
    private void Start()
    {
        float val_1 = this.playSpeed;
        val_1 = 1f / val_1;
        this.interval = val_1;
    }
    private System.Collections.IEnumerator TUI()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new PlayGif.<TUI>d__9();
    }
    public PlayGif()
    {
    
    }

}
