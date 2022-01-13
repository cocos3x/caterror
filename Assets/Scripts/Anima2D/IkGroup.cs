using UnityEngine;

namespace Anima2D
{
    public class IkGroup : MonoBehaviour
    {
        // Fields
        private System.Collections.Generic.List<Anima2D.Ik2D> m_IkComponents;
        
        // Methods
        public void UpdateGroup()
        {
            goto label_1;
            label_9:
            Anima2D.Ik2D val_1 = this.m_IkComponents.Item[0];
            if((UnityEngine.Object.op_Implicit(exists:  val_1)) != false)
            {
                    if(val_1 != null)
            {
                    val_1.enabled = false;
            }
            else
            {
                    0.enabled = false;
            }
            
                val_1.UpdateIK();
            }
            
            0 = 1;
            label_1:
            if(0 < this.m_IkComponents.Count)
            {
                goto label_9;
            }
        
        }
        private void LateUpdate()
        {
            this.UpdateGroup();
        }
        public IkGroup()
        {
            this.m_IkComponents = new System.Collections.Generic.List<Anima2D.Ik2D>();
        }
    
    }

}
