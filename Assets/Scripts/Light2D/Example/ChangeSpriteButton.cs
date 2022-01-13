using UnityEngine;

namespace Light2D.Example
{
    public class ChangeSpriteButton : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Button m_Button;
        private Light2D.Light2DSource m_TargetLight;
        private UnityEngine.Sprite m_Sprite;
        private UnityEngine.Color m_Color;
        
        // Properties
        public UnityEngine.UI.Button button { get; }
        
        // Methods
        public UnityEngine.UI.Button get_button()
        {
            UnityEngine.UI.Button val_3;
            if(this.m_Button == 0)
            {
                    this.m_Button = this.GetComponent<UnityEngine.UI.Button>();
                return val_3;
            }
            
            val_3 = this.m_Button;
            return val_3;
        }
        private void OnEnable()
        {
            this.button.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void Light2D.Example.ChangeSpriteButton::OnClicked()));
        }
        private void OnDisable()
        {
            this.button.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void Light2D.Example.ChangeSpriteButton::OnClicked()));
        }
        private void OnClicked()
        {
            this.m_TargetLight.SetSprite(sourceSprite:  this.m_Sprite);
            this.m_TargetLight.color = new UnityEngine.Color() {r = this.m_Color, g = V9.16B, b = V10.16B, a = V11.16B};
        }
        public ChangeSpriteButton()
        {
        
        }
    
    }

}
