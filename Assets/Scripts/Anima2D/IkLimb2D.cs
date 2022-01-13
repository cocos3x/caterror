using UnityEngine;

namespace Anima2D
{
    public class IkLimb2D : Ik2D
    {
        // Fields
        public bool flip;
        private Anima2D.IkSolver2DLimb m_Solver;
        
        // Methods
        protected override Anima2D.IkSolver2D GetSolver()
        {
            return (Anima2D.IkSolver2D)this.m_Solver;
        }
        protected override void Validate()
        {
            this.numBones = 2;
        }
        protected override int ValidateNumBones(int numBones)
        {
            return 2;
        }
        protected override void OnIkUpdate()
        {
            this.OnIkUpdate();
            this.m_Solver.flip = this.flip;
        }
        private void OnValidate()
        {
            this.numBones = 2;
        }
        public IkLimb2D()
        {
            this.m_Solver = new Anima2D.IkSolver2DLimb();
            mem[1152921512409300012] = 1065353216;
            mem[1152921512409300016] = 257;
            this = new UnityEngine.MonoBehaviour();
        }
    
    }

}
