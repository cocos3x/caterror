using UnityEngine;
public class SiblingIndexLastSetter : MonoBehaviour
{
    // Methods
    private void Start()
    {
        this.transform.SetSiblingIndex(index:  this.transform.parent.childCount);
    }
    public SiblingIndexLastSetter()
    {
    
    }

}
