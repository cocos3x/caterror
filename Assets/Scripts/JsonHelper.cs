using UnityEngine;
public static class JsonHelper
{
    // Methods
    public static object[] GetJsonArray(string json, string typeName)
    {
        System.Type val_3 = System.Type.GetType(typeName:  typeName);
        if(val_3 != null)
        {
                return JsonHelper.GetJsonArray(json:  json, type:  val_3 = System.Type.GetType(typeName:  typeName));
        }
        
        return JsonHelper.GetJsonArray(json:  json, type:  val_3);
    }
    public static object[] GetJsonArray(string json, System.Type type)
    {
        string val_9;
        System.Collections.IEnumerable val_10;
        val_9 = json;
        new System.Type[1][0] = type;
        string[] val_4 = new string[1];
        val_4[0] = val_9;
        object val_5 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()).GetMethod(name:  "JsonToArray").Invoke(obj:  0, parameters:  val_4);
        if(val_5 == null)
        {
                return (System.Object[])System.Linq.Enumerable.ToArray<System.Object>(source:  System.Linq.Enumerable.Cast<System.Object>(source:  val_10 = 0));
        }
        
        val_10 = val_5;
        val_9 = null;
        if(val_10 != null)
        {
                return (System.Object[])System.Linq.Enumerable.ToArray<System.Object>(source:  System.Linq.Enumerable.Cast<System.Object>(source:  val_10));
        }
        
        return (System.Object[])System.Linq.Enumerable.ToArray<System.Object>(source:  System.Linq.Enumerable.Cast<System.Object>(source:  val_10));
    }
    public static T[] JsonToArray<T>(string json)
    {
        if(("{ \"array\": "("{ \"array\": ") + json + "}") != null)
        {
                return (T[])val_1.m_stringLength;
        }
        
        return (T[])val_1.m_stringLength;
    }

}
