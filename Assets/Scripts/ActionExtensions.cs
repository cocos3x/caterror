using UnityEngine;
public static class ActionExtensions
{
    // Fields
    public static System.Action EmptyAction;
    public static System.Action<float> EmptyActionFloat;
    public static System.Action<bool> EmptyActionBool;
    
    // Methods
    private static ActionExtensions()
    {
        null = null;
        ActionExtensions.EmptyAction = new System.Action(object:  ActionExtensions.<>c.<>9, method:  System.Void ActionExtensions.<>c::<.cctor>b__3_0());
        ActionExtensions.EmptyActionFloat = new System.Action<System.Single>(object:  ActionExtensions.<>c.<>9, method:  System.Void ActionExtensions.<>c::<.cctor>b__3_1(float f));
        ActionExtensions.EmptyActionBool = new System.Action<System.Boolean>(object:  ActionExtensions.<>c.<>9, method:  System.Void ActionExtensions.<>c::<.cctor>b__3_2(bool b));
    }

}
