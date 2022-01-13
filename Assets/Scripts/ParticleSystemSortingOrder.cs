using UnityEngine;
public class ParticleSystemSortingOrder : MonoBehaviour
{
    // Fields
    public int sortingOrder;
    
    // Methods
    private void Awake()
    {
        this.GetComponent<UnityEngine.ParticleSystemRenderer>().sortingOrder = this.sortingOrder;
    }
    private void OnValidate()
    {
        this.GetComponent<UnityEngine.ParticleSystemRenderer>().sortingOrder = this.sortingOrder;
    }
    public ParticleSystemSortingOrder()
    {
    
    }

}
