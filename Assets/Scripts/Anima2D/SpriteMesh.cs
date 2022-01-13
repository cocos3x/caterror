using UnityEngine;

namespace Anima2D
{
    public class SpriteMesh : ScriptableObject
    {
        // Fields
        public const int api_version = 4;
        private int m_ApiVersion;
        private UnityEngine.Sprite m_Sprite;
        private UnityEngine.Mesh m_SharedMesh;
        private UnityEngine.Material[] m_SharedMaterials;
        
        // Properties
        public UnityEngine.Sprite sprite { get; set; }
        public UnityEngine.Mesh sharedMesh { get; set; }
        
        // Methods
        public UnityEngine.Sprite get_sprite()
        {
            return (UnityEngine.Sprite)this.m_Sprite;
        }
        private void set_sprite(UnityEngine.Sprite value)
        {
            this.m_Sprite = value;
        }
        public UnityEngine.Mesh get_sharedMesh()
        {
            return (UnityEngine.Mesh)this.m_SharedMesh;
        }
        private void set_sharedMesh(UnityEngine.Mesh value)
        {
            this.m_SharedMesh = value;
        }
        public SpriteMesh()
        {
        
        }
    
    }

}
