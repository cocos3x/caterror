using UnityEngine;
public class JoypacAdClient : MonoBehaviour
{
    // Fields
    private static System.Action m_vcPresentCallback;
    private static System.Action m_vcDismissCallback;
    private static JoypacAdClient s_instance;
    
    // Properties
    public static JoypacAdClient Instance { get; }
    
    // Methods
    public static JoypacAdClient get_Instance()
    {
        JoypacAdClient val_4;
        UnityEngine.Object val_5;
        val_4 = JoypacAdClient.s_instance;
        if(val_4 != 0)
        {
                return (JoypacAdClient)JoypacAdClient.s_instance;
        }
        
        UnityEngine.GameObject val_2 = null;
        val_4 = val_2;
        val_2 = new UnityEngine.GameObject();
        if(val_4 != null)
        {
                val_2.name = "AdObject";
            val_5 = val_4;
        }
        else
        {
                0.name = "AdObject";
            val_5 = 0;
        }
        
        JoypacAdClient.s_instance = val_2.AddComponent<JoypacAdClient>();
        UnityEngine.Object.DontDestroyOnLoad(target:  val_5);
        return (JoypacAdClient)JoypacAdClient.s_instance;
    }
    public JoypacAdClient()
    {
    
    }

}
