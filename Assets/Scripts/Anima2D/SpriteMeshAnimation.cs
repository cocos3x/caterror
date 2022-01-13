using UnityEngine;

namespace Anima2D
{
    public class SpriteMeshAnimation : MonoBehaviour
    {
        // Fields
        private float m_Frame;
        private Anima2D.SpriteMesh[] m_Frames;
        private int m_OldFrame;
        private Anima2D.SpriteMeshInstance m_SpriteMeshInstance;
        
        // Properties
        public Anima2D.SpriteMesh[] frames { get; set; }
        public Anima2D.SpriteMeshInstance cachedSpriteMeshInstance { get; }
        public int frame { get; set; }
        
        // Methods
        public Anima2D.SpriteMesh[] get_frames()
        {
            return (Anima2D.SpriteMesh[])this.m_Frames;
        }
        public void set_frames(Anima2D.SpriteMesh[] value)
        {
            this.m_Frames = value;
        }
        public Anima2D.SpriteMeshInstance get_cachedSpriteMeshInstance()
        {
            Anima2D.SpriteMeshInstance val_3;
            if((UnityEngine.Object.op_Implicit(exists:  this.m_SpriteMeshInstance)) != false)
            {
                    val_3 = this.m_SpriteMeshInstance;
                return val_2;
            }
            
            Anima2D.SpriteMeshInstance val_2 = this.GetComponent<Anima2D.SpriteMeshInstance>();
            this.m_SpriteMeshInstance = val_2;
            return val_2;
        }
        public int get_frame()
        {
            return (int)(int)this.m_Frame;
        }
        public void set_frame(int value)
        {
            this.m_Frame = (float)value;
        }
        private void LateUpdate()
        {
            if(this.m_OldFrame == (int)this.m_Frame)
            {
                    return;
            }
            
            if(this.m_Frames == null)
            {
                    return;
            }
            
            if(this.m_Frames.Length == 0)
            {
                    return;
            }
            
            if((int)this.m_Frame >= this.m_Frames.Length)
            {
                    return;
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  this.cachedSpriteMeshInstance)) == false)
            {
                    return;
            }
            
            this.m_OldFrame = (int)this.m_Frame;
            Anima2D.SpriteMeshInstance val_3 = this.cachedSpriteMeshInstance;
            this = this.m_Frames[(long)(int)this.m_Frame];
            val_3.m_SpriteMesh = this;
        }
        public SpriteMeshAnimation()
        {
        
        }
    
    }

}
