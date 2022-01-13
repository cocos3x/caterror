using UnityEngine;

namespace Anima2D
{
    public class SpriteMeshInstance : MonoBehaviour
    {
        // Fields
        private Anima2D.SpriteMesh m_SpriteMesh;
        private UnityEngine.Color m_Color;
        private UnityEngine.Material[] m_Materials;
        private int m_SortingLayerID;
        private int m_SortingOrder;
        private UnityEngine.Transform[] m_BoneTransforms;
        private System.Collections.Generic.List<Anima2D.Bone2D> m_CachedBones;
        private UnityEngine.MaterialPropertyBlock m_MaterialPropertyBlock;
        private UnityEngine.Renderer mCachedRenderer;
        private UnityEngine.MeshFilter mCachedMeshFilter;
        private UnityEngine.SkinnedMeshRenderer mCachedSkinnedRenderer;
        private UnityEngine.Mesh m_InitialMesh;
        private UnityEngine.Mesh m_CurrentMesh;
        
        // Properties
        public Anima2D.SpriteMesh spriteMesh { get; set; }
        public UnityEngine.Material sharedMaterial { get; set; }
        public UnityEngine.Material[] sharedMaterials { get; set; }
        public UnityEngine.Color color { get; set; }
        public int sortingLayerID { get; set; }
        public string sortingLayerName { get; set; }
        public int sortingOrder { get; set; }
        public System.Collections.Generic.List<Anima2D.Bone2D> bones { get; set; }
        private UnityEngine.MaterialPropertyBlock materialPropertyBlock { get; }
        public UnityEngine.Renderer cachedRenderer { get; }
        public UnityEngine.MeshFilter cachedMeshFilter { get; }
        public UnityEngine.SkinnedMeshRenderer cachedSkinnedRenderer { get; }
        private UnityEngine.Texture2D spriteTexture { get; }
        public UnityEngine.Mesh sharedMesh { get; }
        public UnityEngine.Mesh mesh { get; }
        
        // Methods
        public Anima2D.SpriteMesh get_spriteMesh()
        {
            return (Anima2D.SpriteMesh)this.m_SpriteMesh;
        }
        public void set_spriteMesh(Anima2D.SpriteMesh value)
        {
            this.m_SpriteMesh = value;
        }
        public UnityEngine.Material get_sharedMaterial()
        {
            UnityEngine.Material[] val_1;
            UnityEngine.Material val_2;
            val_1 = this;
            if(this.m_Materials.Length != 0)
            {
                    val_1 = this.m_Materials;
                val_2 = val_1[0];
                return (UnityEngine.Material)val_2;
            }
            
            val_2 = 0;
            return (UnityEngine.Material)val_2;
        }
        public void set_sharedMaterial(UnityEngine.Material value)
        {
            UnityEngine.Material[] val_1 = new UnityEngine.Material[1];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(value != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(value == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = value;
            this.m_Materials = val_1;
        }
        public UnityEngine.Material[] get_sharedMaterials()
        {
            return (UnityEngine.Material[])this.m_Materials;
        }
        public void set_sharedMaterials(UnityEngine.Material[] value)
        {
            this.m_Materials = value;
        }
        public UnityEngine.Color get_color()
        {
            return new UnityEngine.Color() {r = this.m_Color};
        }
        public void set_color(UnityEngine.Color value)
        {
            this.m_Color = value;
            mem[1152921512418488068] = value.g;
            mem[1152921512418488072] = value.b;
            mem[1152921512418488076] = value.a;
        }
        public int get_sortingLayerID()
        {
            return (int)this.m_SortingLayerID;
        }
        public void set_sortingLayerID(int value)
        {
            this.m_SortingLayerID = value;
        }
        public string get_sortingLayerName()
        {
            if((UnityEngine.Object.op_Implicit(exists:  this.cachedRenderer)) == false)
            {
                    return "Default";
            }
            
            UnityEngine.Renderer val_3 = this.cachedRenderer;
            if(val_3 != null)
            {
                    return val_3.sortingLayerName;
            }
            
            return val_3.sortingLayerName;
        }
        public void set_sortingLayerName(string value)
        {
            if((UnityEngine.Object.op_Implicit(exists:  this.cachedRenderer)) == false)
            {
                    return;
            }
            
            this.cachedRenderer.sortingLayerName = value;
            this.m_SortingLayerID = this.cachedRenderer.sortingLayerID;
        }
        public int get_sortingOrder()
        {
            return (int)this.m_SortingOrder;
        }
        public void set_sortingOrder(int value)
        {
            this.m_SortingOrder = value;
        }
        public System.Collections.Generic.List<Anima2D.Bone2D> get_bones()
        {
            var val_15;
            Anima2D.Bone2D val_16;
            var val_17;
            if((this.m_BoneTransforms == null) || (this.m_CachedBones.Count == this.m_BoneTransforms.Length))
            {
                goto label_4;
            }
            
            this.m_CachedBones = new System.Collections.Generic.List<Anima2D.Bone2D>(capacity:  this.m_BoneTransforms.Length);
            val_15 = 0;
            goto label_6;
            label_17:
            val_16 = 0;
            if((UnityEngine.Object.op_Implicit(exists:  this.m_BoneTransforms[0])) != false)
            {
                    val_16 = this.m_BoneTransforms[0].GetComponent<Anima2D.Bone2D>();
            }
            
            this.m_CachedBones.Add(item:  val_16);
            val_15 = 1;
            label_6:
            if(val_15 < this.m_BoneTransforms.Length)
            {
                goto label_17;
            }
            
            label_4:
            val_17 = 0;
            goto label_18;
            label_45:
            if((UnityEngine.Object.op_Implicit(exists:  this.m_CachedBones.Item[0])) != false)
            {
                    if(this.m_BoneTransforms[0] != this.m_CachedBones.Item[0].transform)
            {
                    this.m_CachedBones.set_Item(index:  0, value:  0);
            }
            
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  this.m_CachedBones.Item[0])) != true)
            {
                    if((UnityEngine.Object.op_Implicit(exists:  this.m_BoneTransforms[0])) != false)
            {
                    this.m_CachedBones.set_Item(index:  0, value:  this.m_BoneTransforms[0].GetComponent<Anima2D.Bone2D>());
            }
            
            }
            
            val_17 = 1;
            label_18:
            if(val_17 < this.m_CachedBones.Count)
            {
                goto label_45;
            }
            
            return (System.Collections.Generic.List<Anima2D.Bone2D>)this.m_CachedBones;
        }
        public void set_bones(System.Collections.Generic.List<Anima2D.Bone2D> value)
        {
            var val_11;
            System.Collections.Generic.List<Anima2D.Bone2D> val_1 = new System.Collections.Generic.List<Anima2D.Bone2D>(collection:  value);
            this.m_CachedBones = val_1;
            int val_2 = val_1.Count;
            this.m_BoneTransforms = new UnityEngine.Transform[0];
            val_11 = 0;
            goto label_2;
            label_15:
            Anima2D.Bone2D val_4 = this.m_CachedBones.Item[0];
            if((UnityEngine.Object.op_Implicit(exists:  val_4)) == false)
            {
                goto label_6;
            }
            
            UnityEngine.Transform val_6 = val_4.transform;
            if(this.m_BoneTransforms == null)
            {
                goto label_8;
            }
            
            if(val_6 != null)
            {
                goto label_9;
            }
            
            goto label_12;
            label_8:
            if(val_6 == null)
            {
                goto label_12;
            }
            
            label_9:
            label_12:
            this.m_BoneTransforms[0] = val_6;
            label_6:
            val_11 = 1;
            label_2:
            if(val_11 < this.m_CachedBones.Count)
            {
                goto label_15;
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  this.cachedSkinnedRenderer)) == false)
            {
                    return;
            }
            
            this.cachedSkinnedRenderer.bones = this.m_BoneTransforms;
        }
        private UnityEngine.MaterialPropertyBlock get_materialPropertyBlock()
        {
            UnityEngine.MaterialPropertyBlock val_2 = this.m_MaterialPropertyBlock;
            if(val_2 != null)
            {
                    return val_2;
            }
            
            UnityEngine.MaterialPropertyBlock val_1 = null;
            val_2 = val_1;
            val_1 = new UnityEngine.MaterialPropertyBlock();
            this.m_MaterialPropertyBlock = val_2;
            return val_2;
        }
        public UnityEngine.Renderer get_cachedRenderer()
        {
            UnityEngine.Renderer val_3;
            if((UnityEngine.Object.op_Implicit(exists:  this.mCachedRenderer)) != false)
            {
                    val_3 = this.mCachedRenderer;
                return val_2;
            }
            
            UnityEngine.Renderer val_2 = this.GetComponent<UnityEngine.Renderer>();
            this.mCachedRenderer = val_2;
            return val_2;
        }
        public UnityEngine.MeshFilter get_cachedMeshFilter()
        {
            UnityEngine.MeshFilter val_3;
            if((UnityEngine.Object.op_Implicit(exists:  this.mCachedMeshFilter)) != false)
            {
                    val_3 = this.mCachedMeshFilter;
                return val_2;
            }
            
            UnityEngine.MeshFilter val_2 = this.GetComponent<UnityEngine.MeshFilter>();
            this.mCachedMeshFilter = val_2;
            return val_2;
        }
        public UnityEngine.SkinnedMeshRenderer get_cachedSkinnedRenderer()
        {
            UnityEngine.SkinnedMeshRenderer val_3;
            if((UnityEngine.Object.op_Implicit(exists:  this.mCachedSkinnedRenderer)) != false)
            {
                    val_3 = this.mCachedSkinnedRenderer;
                return val_2;
            }
            
            UnityEngine.SkinnedMeshRenderer val_2 = this.GetComponent<UnityEngine.SkinnedMeshRenderer>();
            this.mCachedSkinnedRenderer = val_2;
            return val_2;
        }
        private UnityEngine.Texture2D get_spriteTexture()
        {
            if((UnityEngine.Object.op_Implicit(exists:  this.m_SpriteMesh)) == false)
            {
                    return 0;
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  this.m_SpriteMesh.m_Sprite)) == false)
            {
                    return 0;
            }
            
            if(this.m_SpriteMesh.m_Sprite != null)
            {
                    return this.m_SpriteMesh.m_Sprite.texture;
            }
            
            return this.m_SpriteMesh.m_Sprite.texture;
        }
        public UnityEngine.Mesh get_sharedMesh()
        {
            if((UnityEngine.Object.op_Implicit(exists:  this.m_InitialMesh)) == false)
            {
                    return 0;
            }
            
            0 = this.m_InitialMesh;
            return 0;
        }
        public UnityEngine.Mesh get_mesh()
        {
            UnityEngine.Mesh val_3;
            var val_4;
            val_3 = this;
            val_4 = 0;
            if((UnityEngine.Object.op_Implicit(exists:  this.m_CurrentMesh)) == false)
            {
                    return (UnityEngine.Mesh)UnityEngine.Object.Instantiate<UnityEngine.Mesh>(original:  val_3 = this.m_CurrentMesh);
            }
            
            return (UnityEngine.Mesh)UnityEngine.Object.Instantiate<UnityEngine.Mesh>(original:  val_3);
        }
        private void OnDestroy()
        {
            if((UnityEngine.Object.op_Implicit(exists:  this.m_CurrentMesh)) == false)
            {
                    return;
            }
            
            UnityEngine.Object.Destroy(obj:  this.m_CurrentMesh);
        }
        private void Awake()
        {
            this.UpdateCurrentMesh();
        }
        private void UpdateInitialMesh()
        {
            this.m_InitialMesh = 0;
            if((UnityEngine.Object.op_Implicit(exists:  this.m_SpriteMesh)) == false)
            {
                    return;
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  this.m_SpriteMesh.m_SharedMesh)) == false)
            {
                    return;
            }
            
            this.m_InitialMesh = this.m_SpriteMesh.m_SharedMesh;
        }
        private void UpdateCurrentMesh()
        {
            float val_12;
            float val_13;
            var val_29;
            var val_30;
            var val_31;
            UnityEngine.Mesh val_32;
            this.UpdateInitialMesh();
            if((UnityEngine.Object.op_Implicit(exists:  this.m_InitialMesh)) == false)
            {
                goto label_3;
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  this.m_CurrentMesh)) != true)
            {
                    UnityEngine.Mesh val_3 = new UnityEngine.Mesh();
                this.m_CurrentMesh = val_3;
                val_3.hideFlags = 52;
                val_3.MarkDynamic();
            }
            
            val_3.Clear();
            val_3.UploadMeshData(markNoLongerReadable:  false);
            this.m_CurrentMesh.name = this.m_InitialMesh.name;
            this.m_CurrentMesh.vertices = this.m_InitialMesh.vertices;
            this.m_CurrentMesh.uv = this.m_InitialMesh.uv;
            this.m_CurrentMesh.normals = this.m_InitialMesh.normals;
            this.m_CurrentMesh.tangents = this.m_InitialMesh.tangents;
            this.m_CurrentMesh.boneWeights = this.m_InitialMesh.boneWeights;
            this.m_CurrentMesh.bindposes = this.m_InitialMesh.bindposes;
            UnityEngine.Bounds val_11 = this.m_InitialMesh.bounds;
            this.m_CurrentMesh.bounds = new UnityEngine.Bounds() {m_Center = new UnityEngine.Vector3() {x = val_13, y = val_13, z = val_13}, m_Extents = new UnityEngine.Vector3() {x = val_13, y = val_12, z = val_12}};
            UnityEngine.Color[] val_14 = this.m_InitialMesh.colors;
            this.m_CurrentMesh.colors = val_14;
            val_29 = 0;
            goto label_29;
            label_33:
            val_14.SetTriangles(triangles:  this.m_InitialMesh.GetTriangles(submesh:  0), submesh:  0);
            val_29 = 1;
            label_29:
            if(val_29 < this.m_InitialMesh.subMeshCount)
            {
                goto label_33;
            }
            
            val_3.ClearBlendShapes();
            val_30 = 0;
            goto label_35;
            label_45:
            val_31 = 0;
            goto label_37;
            label_43:
            int val_19 = this.m_InitialMesh.vertexCount;
            UnityEngine.Vector3[] val_20 = new UnityEngine.Vector3[0];
            this.m_InitialMesh.GetBlendShapeFrameVertices(shapeIndex:  0, frameIndex:  0, deltaVertices:  val_20, deltaNormals:  0, deltaTangents:  0);
            val_3.AddBlendShapeFrame(shapeName:  this.m_InitialMesh.GetBlendShapeName(shapeIndex:  0), frameWeight:  this.m_InitialMesh.GetBlendShapeFrameWeight(shapeIndex:  0, frameIndex:  0), deltaVertices:  val_20, deltaNormals:  0, deltaTangents:  0);
            val_31 = 1;
            label_37:
            if(val_31 < (this.m_InitialMesh.GetBlendShapeFrameCount(shapeIndex:  0)))
            {
                goto label_43;
            }
            
            val_30 = 1;
            label_35:
            val_32 = this.m_InitialMesh;
            if(val_30 < val_32.blendShapeCount)
            {
                goto label_45;
            }
            
            val_3.hideFlags = 52;
            goto label_50;
            label_3:
            this.m_InitialMesh = 0;
            if((UnityEngine.Object.op_Implicit(exists:  this.m_CurrentMesh)) != false)
            {
                    val_3.Clear();
            }
            
            label_50:
            if((UnityEngine.Object.op_Implicit(exists:  val_3)) != false)
            {
                    if(((UnityEngine.Object.op_Implicit(exists:  this.m_SpriteMesh)) != false) && ((UnityEngine.Object.op_Implicit(exists:  this.m_SpriteMesh.m_Sprite)) != false))
            {
                    if(this.m_SpriteMesh.m_Sprite.packed != false)
            {
                    val_32 = this.m_SpriteMesh;
                this.SetSpriteUVs(mesh:  val_3, sprite:  this.m_SpriteMesh.m_Sprite);
            }
            
            }
            
                val_3.UploadMeshData(markNoLongerReadable:  false);
            }
            
            this.UpdateRenderers();
        }
        private void SetSpriteUVs(UnityEngine.Mesh mesh, UnityEngine.Sprite sprite)
        {
            UnityEngine.Vector2[] val_1 = sprite.uv;
            if(mesh.vertexCount != val_1.Length)
            {
                    return;
            }
            
            mesh.uv = sprite.uv;
        }
        private void UpdateRenderers()
        {
            if((UnityEngine.Object.op_Implicit(exists:  this.m_InitialMesh)) != false)
            {
                    0 = this.m_CurrentMesh;
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  this.cachedSkinnedRenderer)) != false)
            {
                    this.cachedSkinnedRenderer.sharedMesh = 0;
                return;
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  this.cachedMeshFilter)) == false)
            {
                    return;
            }
            
            this.cachedMeshFilter.sharedMesh = 0;
        }
        private void LateUpdate()
        {
            if((UnityEngine.Object.op_Implicit(exists:  this.m_SpriteMesh)) != false)
            {
                    if((UnityEngine.Object.op_Implicit(exists:  this.m_SpriteMesh)) == false)
            {
                    return;
            }
            
                if(this.m_SpriteMesh.m_SharedMesh == this.m_InitialMesh)
            {
                    return;
            }
            
            }
            
            this.UpdateCurrentMesh();
        }
        private void OnWillRenderObject()
        {
            UnityEngine.MaterialPropertyBlock val_15;
            this.UpdateRenderers();
            if((UnityEngine.Object.op_Implicit(exists:  this.cachedRenderer)) == false)
            {
                    return;
            }
            
            this.cachedRenderer.sortingLayerID = this.m_SortingLayerID;
            this.cachedRenderer.sortingOrder = this.m_SortingOrder;
            this.cachedRenderer.sharedMaterials = this.m_Materials;
            val_15 = this.materialPropertyBlock;
            this.cachedRenderer.GetPropertyBlock(properties:  val_15);
            if((UnityEngine.Object.op_Implicit(exists:  this.spriteTexture)) != false)
            {
                    val_15 = this.spriteTexture;
                this.materialPropertyBlock.SetTexture(name:  "_MainTex", value:  val_15);
            }
            
            this.materialPropertyBlock.SetColor(name:  "_Color", value:  new UnityEngine.Color() {r = this.m_Color, g = V9.16B, b = V10.16B, a = V11.16B});
            this.cachedRenderer.SetPropertyBlock(properties:  this.materialPropertyBlock);
        }
        public SpriteMeshInstance()
        {
            UnityEngine.Color val_1 = UnityEngine.Color.white;
            this.m_Color = val_1;
            mem[1152921512423868180] = val_1.g;
            mem[1152921512423868184] = val_1.b;
            mem[1152921512423868188] = val_1.a;
            this.m_CachedBones = new System.Collections.Generic.List<Anima2D.Bone2D>();
        }
    
    }

}
