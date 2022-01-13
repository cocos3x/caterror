using UnityEngine;
public class AndroidHide : MonoBehaviour
{
    // Methods
    private void OnEnable()
    {
        this.gameObject.SetActive(value:  false);
    }
    public AndroidHide()
    {
    
    }

}
