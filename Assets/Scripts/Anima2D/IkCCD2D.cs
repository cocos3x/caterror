using UnityEngine;

namespace Anima2D
{
    public class IkCCD2D : Ik2D
    {
        // Fields
        public int iterations;
        public float damping;
        private Anima2D.IkSolver2DCCD m_Solver;
        
        // Methods
        protected override Anima2D.IkSolver2D GetSolver()
        {
            return (Anima2D.IkSolver2D)this.m_Solver;
        }
        protected override void OnIkUpdate()
        {
            this.OnIkUpdate();
            this.m_Solver.iterations = this.iterations;
            this.m_Solver.damping = this.damping;
        }
        public IkCCD2D()
        {
            this.iterations = 10;
            this.damping = 7.346868E-41f;
            Anima2D.IkSolver2DCCD val_1 = null;
            .iterations = 10;
            .damping = 7.346868E-41f;
            val_1 = new Anima2D.IkSolver2DCCD();
            this.m_Solver = val_1;
            mem[1152921512408231596] = 1065353216;
            mem[1152921512408231600] = 257;
            this = new UnityEngine.MonoBehaviour();
        }
    
    }

}
