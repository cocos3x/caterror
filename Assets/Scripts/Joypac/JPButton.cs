using UnityEngine;

namespace Joypac
{
    public class JPButton : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Button button;
        
        // Methods
        public virtual void Start()
        {
            if((this.GetComponent<UnityEngine.UI.Button>()) != 0)
            {
                    UnityEngine.UI.Button val_3 = this.GetComponent<UnityEngine.UI.Button>();
            }
            else
            {
                    UnityEngine.UI.Button val_5 = this.gameObject.AddComponent<UnityEngine.UI.Button>();
            }
            
            this.button = val_5;
            val_5.onClick.RemoveAllListeners();
            this.button.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void Joypac.JPButton::<Start>b__1_0()));
        }
        public virtual void OnClick()
        {
        
        }
        public JPButton()
        {
        
        }
        private void <Start>b__1_0()
        {
            goto typeof(Joypac.JPButton).__il2cppRuntimeField_178;
        }
    
    }

}
