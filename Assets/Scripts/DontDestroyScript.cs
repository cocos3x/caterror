using UnityEngine;
public class DontDestroyScript : MonoBehaviour
{
    // Methods
    private void Start()
    {
        UnityEngine.Object.DontDestroyOnLoad(target:  this);
    }
    private void Update()
    {
    
    }
    public DontDestroyScript()
    {
    
    }

}
