using UnityEngine;
private sealed class JSONClass.<>c__DisplayClass12_0
{
    // Fields
    public com.adjust.sdk.JSONNode aNode;
    
    // Methods
    public JSONClass.<>c__DisplayClass12_0()
    {
    
    }
    internal bool <Remove>b__0(System.Collections.Generic.KeyValuePair<string, com.adjust.sdk.JSONNode> k)
    {
        return (bool)com.adjust.sdk.JSONNode.op_Equality(a:  k.Value, b:  this.aNode);
    }

}
