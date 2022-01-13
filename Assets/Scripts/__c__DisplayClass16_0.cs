using UnityEngine;
private sealed class JSONObject.<>c__DisplayClass16_0
{
    // Fields
    public Umeng.JSONNode aNode;
    
    // Methods
    public JSONObject.<>c__DisplayClass16_0()
    {
    
    }
    internal bool <Remove>b__0(System.Collections.Generic.KeyValuePair<string, Umeng.JSONNode> k)
    {
        return (bool)Umeng.JSONNode.op_Equality(a:  k.Value, b:  this.aNode);
    }

}
