using UnityEngine;

namespace GameAnalyticsSDK.Setup
{
    public class Organization
    {
        // Fields
        private string <Name>k__BackingField;
        private string <ID>k__BackingField;
        private System.Collections.Generic.List<GameAnalyticsSDK.Setup.Studio> <Studios>k__BackingField;
        
        // Properties
        public string Name { get; set; }
        public string ID { get; set; }
        public System.Collections.Generic.List<GameAnalyticsSDK.Setup.Studio> Studios { get; set; }
        
        // Methods
        public string get_Name()
        {
            return (string)this.<Name>k__BackingField;
        }
        private void set_Name(string value)
        {
            this.<Name>k__BackingField = value;
        }
        public string get_ID()
        {
            return (string)this.<ID>k__BackingField;
        }
        private void set_ID(string value)
        {
            this.<ID>k__BackingField = value;
        }
        public System.Collections.Generic.List<GameAnalyticsSDK.Setup.Studio> get_Studios()
        {
            return (System.Collections.Generic.List<GameAnalyticsSDK.Setup.Studio>)this.<Studios>k__BackingField;
        }
        private void set_Studios(System.Collections.Generic.List<GameAnalyticsSDK.Setup.Studio> value)
        {
            this.<Studios>k__BackingField = value;
        }
        public Organization(string name, string id)
        {
            val_1 = new System.Object();
            this.<Name>k__BackingField = name;
            this.<ID>k__BackingField = val_1;
            this.<Studios>k__BackingField = new System.Collections.Generic.List<GameAnalyticsSDK.Setup.Studio>();
        }
        public static string[] GetOrganizationNames(System.Collections.Generic.List<GameAnalyticsSDK.Setup.Organization> organizations, bool addFirstEmpty = True)
        {
            string val_16;
            var val_17;
            var val_18;
            string val_19;
            if(organizations == null)
            {
                goto label_1;
            }
            
            if(addFirstEmpty == false)
            {
                goto label_2;
            }
            
            int val_2 = organizations.Count + 1;
            val_17 = new string[0];
            val_17[0] = "-";
            val_16 = "";
            if(organizations.Count < 1)
            {
                    return (System.String[])val_17;
            }
            
            val_18 = 1152921512376400368;
            var val_16 = 0;
            do
            {
                GameAnalyticsSDK.Setup.Organization val_5 = organizations.Item[0];
                val_19 = val_5.<Name>k__BackingField(val_5.<Name>k__BackingField) + val_16;
                val_16 = val_16 + 1;
                val_17[(long)val_16] = val_19;
                val_16 = val_16 + " ";
            }
            while(val_16 < organizations.Count);
            
            return (System.String[])val_17;
            label_1:
            val_17 = new string[1];
            val_17[0] = "-";
            return (System.String[])val_17;
            label_2:
            val_17 = new string[0];
            val_16 = "";
            if(organizations.Count < 1)
            {
                    return (System.String[])val_17;
            }
            
            val_18 = 1152921512376400368;
            var val_17 = 0;
            label_27:
            GameAnalyticsSDK.Setup.Organization val_12 = organizations.Item[0];
            val_19 = val_12.<Name>k__BackingField(val_12.<Name>k__BackingField) + val_16;
            if(val_17 == null)
            {
                goto label_21;
            }
            
            if(val_19 != null)
            {
                goto label_22;
            }
            
            goto label_25;
            label_21:
            if(val_19 == null)
            {
                goto label_25;
            }
            
            label_22:
            label_25:
            val_17[0] = val_19;
            val_16 = val_16 + " ";
            val_17 = val_17 + 1;
            if(val_17 < organizations.Count)
            {
                goto label_27;
            }
            
            return (System.String[])val_17;
        }
    
    }

}
