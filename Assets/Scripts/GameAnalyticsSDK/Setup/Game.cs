using UnityEngine;

namespace GameAnalyticsSDK.Setup
{
    public class Game
    {
        // Fields
        private string <Name>k__BackingField;
        private int <ID>k__BackingField;
        private string <GameKey>k__BackingField;
        private string <SecretKey>k__BackingField;
        
        // Properties
        public string Name { get; set; }
        public int ID { get; set; }
        public string GameKey { get; set; }
        public string SecretKey { get; set; }
        
        // Methods
        public string get_Name()
        {
            return (string)this.<Name>k__BackingField;
        }
        private void set_Name(string value)
        {
            this.<Name>k__BackingField = value;
        }
        public int get_ID()
        {
            return (int)this.<ID>k__BackingField;
        }
        private void set_ID(int value)
        {
            this.<ID>k__BackingField = value;
        }
        public string get_GameKey()
        {
            return (string)this.<GameKey>k__BackingField;
        }
        private void set_GameKey(string value)
        {
            this.<GameKey>k__BackingField = value;
        }
        public string get_SecretKey()
        {
            return (string)this.<SecretKey>k__BackingField;
        }
        private void set_SecretKey(string value)
        {
            this.<SecretKey>k__BackingField = value;
        }
        public Game(string name, int id, string gameKey, string secretKey)
        {
            val_1 = new System.Object();
            this.<Name>k__BackingField = name;
            this.<ID>k__BackingField = id;
            this.<GameKey>k__BackingField = val_1;
            this.<SecretKey>k__BackingField = secretKey;
        }
    
    }

}
