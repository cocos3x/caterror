using UnityEngine;
public class PlaySEPlayableBehaviour : PlayableBehaviour
{
    // Fields
    private string playSEFilename;
    
    // Properties
    set; }
    
    // Methods
    public void set_PlaySEFilename(string value)
    {
        this.playSEFilename = value;
    }
    public override void OnGraphStart(UnityEngine.Playables.Playable playable)
    {
    
    }
    public override void OnGraphStop(UnityEngine.Playables.Playable playable)
    {
    
    }
    public override void OnBehaviourPlay(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info)
    {
        SingletonMonoBehaviour<SoundManager>.Instance.PlaySE(filePath:  System.String.Format(format:  "Sounds/SE/{0}", arg0:  this.playSEFilename), maxCount:  0, volume:  1f, pitch:  1f);
    }
    public override void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info)
    {
    
    }
    public override void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info)
    {
    
    }
    public PlaySEPlayableBehaviour()
    {
    
    }

}
