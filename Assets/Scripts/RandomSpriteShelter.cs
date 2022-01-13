using UnityEngine;
public class RandomSpriteShelter : Shelter
{
    // Fields
    private UnityEngine.Sprite[] spriteArray;
    private UnityEngine.SpriteRenderer spriteRenderer;
    
    // Methods
    private void Awake()
    {
        this.spriteRenderer.sprite = ArrayExtensions.RandomChoose<UnityEngine.Sprite>(array:  this.spriteArray);
    }
    public RandomSpriteShelter()
    {
        val_1 = new UnityEngine.MonoBehaviour();
    }

}
