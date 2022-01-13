using UnityEngine;

namespace Light2D
{
    public class Light2DEventManager
    {
        // Fields
        public const string kEnterMessageName = "OnEnterLight2D";
        public const string kExitMessageName = "OnExitLight2D";
        private System.Collections.Generic.HashSet<UnityEngine.GameObject> m_CurrentSet;
        private System.Collections.Generic.HashSet<UnityEngine.GameObject> m_PreviousSet;
        
        // Methods
        public void Add(UnityEngine.GameObject go)
        {
            bool val_1 = this.m_CurrentSet.Add(item:  go);
        }
        public void SendEnterMessage(Light2D.Light2DBase light)
        {
            HashSet.Enumerator<T> val_1 = this.m_CurrentSet.GetEnumerator();
            label_6:
            if(((-1021742952) & 1) == 0)
            {
                goto label_2;
            }
            
            string val_2 = 0.Id;
            if((this.m_PreviousSet.Contains(item:  val_2)) == true)
            {
                goto label_6;
            }
            
            val_2.SendMessage(methodName:  "OnEnterLight2D", value:  light = light);
            goto label_6;
            label_2:
            UniRx.Unit..cctor();
        }
        public void SendExitMessage(Light2D.Light2DBase light)
        {
            HashSet.Enumerator<T> val_1 = this.m_PreviousSet.GetEnumerator();
            label_9:
            if(((-1021598104) & 1) == 0)
            {
                goto label_2;
            }
            
            string val_2 = 0.Id;
            if((val_2 == 0) || ((this.m_CurrentSet.Contains(item:  val_2)) == true))
            {
                goto label_9;
            }
            
            val_2.SendMessage(methodName:  "OnExitLight2D", value:  light = light);
            goto label_9;
            label_2:
            UniRx.Unit..cctor();
        }
        public void Complete()
        {
            this.m_CurrentSet = this.m_PreviousSet;
            this.m_PreviousSet = this.m_CurrentSet;
            this.m_PreviousSet.Clear();
        }
        public Light2DEventManager()
        {
            this.m_CurrentSet = new System.Collections.Generic.HashSet<UnityEngine.GameObject>();
            this.m_PreviousSet = new System.Collections.Generic.HashSet<UnityEngine.GameObject>();
        }
    
    }

}
