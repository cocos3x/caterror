using UnityEngine;
[Serializable]
private class AnimationEventReceiver.FilenameArray
{
    // Fields
    private string[] stringArray;
    
    // Methods
    public string GetRandom()
    {
        return ArrayExtensions.RandomChoose<System.String>(array:  this.stringArray);
    }
    public AnimationEventReceiver.FilenameArray()
    {
    
    }

}
