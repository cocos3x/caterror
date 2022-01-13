using UnityEngine;
public sealed class DebugOptionButton : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button debugButton;
    private bool isEnable;
    
    // Methods
    private void Awake()
    {
        this.gameObject.SetActive(value:  false);
        this.debugButton.gameObject.SetActive(value:  false);
    }
    public DebugOptionButton()
    {
        this.isEnable = true;
    }

}
