using UnityEngine;
[Serializable]
public sealed class PlaySEPlayableAsset : PlayableAsset
{
    // Fields
    private string playSEFilename;
    
    // Methods
    public override UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go)
    {
        .playSEFilename = this.playSEFilename;
        UnityEngine.Playables.ScriptPlayable<T> val_2 = UnityEngine.Playables.ScriptPlayable<PlaySEPlayableBehaviour>.Create(graph:  new UnityEngine.Playables.PlayableGraph() {m_Handle = graph.m_Handle, m_Version = graph.m_Version}, template:  new PlaySEPlayableBehaviour(), inputCount:  0);
        return UnityEngine.Playables.ScriptPlayable<PlaySEPlayableBehaviour>.op_Implicit(playable:  new UnityEngine.Playables.ScriptPlayable<T>() {m_Handle = new UnityEngine.Playables.PlayableHandle() {m_Handle = val_2.m_Handle.m_Handle, m_Version = val_2.m_Handle.m_Version}});
    }
    public PlaySEPlayableAsset()
    {
    
    }

}
