using UnityEngine;
public sealed class PolyWave : MonoBehaviour
{
    // Fields
    private float waveHeight;
    private float waveFrequency;
    private float waveLength;
    private UnityEngine.Vector3 waveOriginPosition;
    private UnityEngine.Mesh mesh;
    private UnityEngine.Vector3[] vertices;
    private float pi2;
    
    // Methods
    private void Awake()
    {
        UnityEngine.Mesh val_2 = this.GetComponent<UnityEngine.MeshFilter>().mesh;
        this.mesh = val_2;
        val_2.MarkDynamic();
        System.Int32[] val_4 = this.mesh.triangles;
        UnityEngine.Vector3[] val_5 = new UnityEngine.Vector3[0];
        if(val_4.Length >= 1)
        {
                var val_10 = 0;
            do
        {
            int val_6 = this.mesh.vertices + (val_4[0] * 12);
            var val_7 = val_5 + (0 * 12);
            mem2[0] = (val_4[0x0][0] * 12) + val_3 + 32;
            mem2[0] = (val_4[0x0][0] * 12) + val_3 + 32 + 4;
            mem2[0] = (val_4[0x0][0] * 12) + val_3 + 40;
            mem2[0] = val_10;
            val_10 = val_10 + 1;
        }
        while(val_10 < val_4.Length);
        
        }
        
        this.mesh.vertices = val_5;
        this.mesh.SetTriangles(triangles:  val_4, submesh:  0);
        this.mesh.RecalculateBounds();
        this.mesh.RecalculateNormals();
        float val_11 = mem[1152921512113933472];
        mem[1152921512113933496] = this.mesh.vertices;
        val_11 = val_11 * val_11;
        mem[1152921512113933472] = val_11;
    }
    private void Update()
    {
        var val_4;
        float val_1 = UnityEngine.Time.time;
        float val_6 = this.pi2;
        float val_7 = this.waveFrequency;
        val_1 = val_1 * val_6;
        val_4 = 0;
        goto label_1;
        label_9:
        UnityEngine.Vector3 val_5 = this.waveOriginPosition;
        float val_8 = this.waveLength;
        val_5 = (8.96831E-44f) - val_5;
        val_6 = val_6 * val_6;
        val_7 = (1.344598E-37f) - val_7;
        val_5 = val_5 * val_5;
        val_5 = val_5 + val_6;
        val_5 = val_5 + (val_7 * val_7);
        val_8 = val_5 / val_8;
        val_5 = val_8 * this.pi2;
        val_5 = (val_1 * val_7) + val_5;
        float val_9 = val_5;
        val_9 = this.waveHeight * val_9;
        var val_4 = this.vertices + (0 * 12);
        val_4 = 1;
        mem2[0] = 8.96831E-44f;
        mem2[0] = val_9;
        mem2[0] = 1.344598E-37f;
        label_1:
        if(val_4 < this.vertices.Length)
        {
            goto label_9;
        }
        
        this.mesh.vertices = this.vertices;
        this.mesh.RecalculateNormals();
    }
    public PolyWave()
    {
        this.waveHeight = 0.5f;
        this.waveFrequency = 0.5f;
        this.waveLength = 0.75f;
        this.pi2 = 6.283185f;
    }

}
