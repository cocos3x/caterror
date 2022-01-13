using UnityEngine;

namespace UnityEngine.UI
{
    public class GraphicCast : Graphic
    {
        // Methods
        protected override void OnPopulateMesh(UnityEngine.UI.VertexHelper vh)
        {
            this.OnPopulateMesh(vh:  vh);
            vh.Clear();
        }
        public GraphicCast()
        {
        
        }
    
    }

}
