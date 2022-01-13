using UnityEngine;
internal static class TimeValidateCoroutineExtensions
{
    // Methods
    public static void StopCoroutine(TimeValidateCoroutine coroutine)
    {
        if(coroutine == null)
        {
                return;
        }
        
        coroutine.Remove();
    }

}
