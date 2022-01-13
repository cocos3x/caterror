using UnityEngine;
public sealed class OutlineFilter : MonoBehaviour
{
    // Fields
    private UnityEngine.Color color;
    private float width;
    private float cutOut;
    private UnityEngine.LayerMask outlineLayer;
    private UnityEngine.Shader flatColorShader;
    private UnityEngine.Material haloMaterial;
    private UnityEngine.Material blurMaterial;
    private UnityEngine.Camera _camera;
    private UnityEngine.Camera renderTextureCamera;
    private int idOffsets;
    private int idGlowTex;
    private int idGlowColor;
    private int idCutOut;
    
    // Methods
    private void Awake()
    {
        this._camera = this.GetComponent<UnityEngine.Camera>();
        this.flatColorShader = UnityEngine.Shader.Find(name:  "Hidden/USAYALib/Outline/FlatColor");
        this.blurMaterial = ShaderExtensions.CreateHiddenMaterial(shader:  UnityEngine.Shader.Find(name:  "Hidden/USAYALib/Outline/Blur"));
        this.haloMaterial = ShaderExtensions.CreateHiddenMaterial(shader:  UnityEngine.Shader.Find(name:  "Hidden/USAYALib/Outline/Halo"));
        UnityEngine.Camera val_8 = new UnityEngine.GameObject(name:  "OutlineRendererTextureCamera").AddComponent<UnityEngine.Camera>();
        this.renderTextureCamera = val_8;
        val_8.transform.parent = this._camera.gameObject.transform;
        this.renderTextureCamera.enabled = false;
        this.idOffsets = UnityEngine.Shader.PropertyToID(name:  "_Offsets");
        this.idGlowTex = UnityEngine.Shader.PropertyToID(name:  "_GlowTex");
        this.idGlowColor = UnityEngine.Shader.PropertyToID(name:  "_GlowColor");
        this.idCutOut = UnityEngine.Shader.PropertyToID(name:  "_CutOut");
    }
    private void OnRenderImage(UnityEngine.RenderTexture src, UnityEngine.RenderTexture dst)
    {
        UnityEngine.Graphics.Blit(source:  src, dest:  dst);
        this.renderTextureCamera.CopyFrom(other:  this._camera);
        this.renderTextureCamera.clearFlags = 2;
        UnityEngine.Color val_1 = UnityEngine.Color.black;
        this.renderTextureCamera.backgroundColor = new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a};
        UnityEngine.RenderTexture val_2 = UnityEngine.RenderTexture.GetTemporary(width:  src, height:  src, depthBuffer:  16, format:  16);
        this.renderTextureCamera.targetTexture = val_2;
        this.renderTextureCamera.cullingMask = UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask() {m_Mask = this.outlineLayer});
        this.renderTextureCamera.RenderWithShader(shader:  this.flatColorShader, replacementTag:  "");
        UnityEngine.RenderTexture val_6 = UnityEngine.RenderTexture.GetTemporary(width:  UnityEngine.Screen.width, height:  UnityEngine.Screen.height, depthBuffer:  0);
        UnityEngine.RenderTexture val_9 = UnityEngine.RenderTexture.GetTemporary(width:  UnityEngine.Screen.width, height:  UnityEngine.Screen.height, depthBuffer:  0);
        UnityEngine.Vector2 val_10 = UnityEngine.Vector2.up;
        this.DoBlurPass(input:  val_2, output:  val_6, direction:  new UnityEngine.Vector2() {x = val_10.x, y = val_10.y});
        UnityEngine.Vector2 val_11 = UnityEngine.Vector2.right;
        this.DoBlurPass(input:  val_6, output:  val_9, direction:  new UnityEngine.Vector2() {x = val_11.x, y = val_11.y});
        this.haloMaterial.SetTexture(nameID:  this.idGlowTex, value:  val_2);
        this.haloMaterial.SetColor(nameID:  this.idGlowColor, value:  new UnityEngine.Color() {r = this.color, g = val_1.g, b = val_1.b, a = val_1.a});
        this.haloMaterial.SetFloat(nameID:  this.idCutOut, value:  this.cutOut);
        UnityEngine.Graphics.Blit(source:  val_9, dest:  dst, mat:  this.haloMaterial);
        UnityEngine.RenderTexture.ReleaseTemporary(temp:  val_2);
        UnityEngine.RenderTexture.ReleaseTemporary(temp:  val_6);
        UnityEngine.RenderTexture.ReleaseTemporary(temp:  val_9);
    }
    private void DoBlurPass(UnityEngine.RenderTexture input, UnityEngine.RenderTexture output, UnityEngine.Vector2 direction)
    {
        float val_4 = this.width;
        float val_3 = (float)input;
        val_3 = val_4 * val_3;
        val_4 = val_3 / 1920f;
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = direction.x, y = direction.y}, d:  val_4);
        UnityEngine.Vector4 val_2 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y});
        this.blurMaterial.SetVector(nameID:  this.idOffsets, value:  new UnityEngine.Vector4() {x = val_2.x, y = val_2.y, z = val_2.z, w = val_2.w});
        UnityEngine.Graphics.Blit(source:  input, dest:  output, mat:  this.blurMaterial);
    }
    public OutlineFilter()
    {
        UnityEngine.Color val_1 = UnityEngine.Color.white;
        this.color = val_1;
        mem[1152921511984101308] = val_1.g;
        mem[1152921511984101312] = val_1.b;
        mem[1152921511984101316] = val_1.a;
        this.width = 1f;
    }

}
