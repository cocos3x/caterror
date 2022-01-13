using UnityEngine;

namespace Umeng
{
    public static class JSON
    {
        // Methods
        public static Umeng.JSONNode Parse(string aJSON)
        {
            return Umeng.JSONNode.Parse(aJSON:  aJSON);
        }
    
    }

}
