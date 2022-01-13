using UnityEngine;
[Serializable]
public class JoypacAdjustAttribution
{
    // Fields
    public string trackerToken;
    public string adgroup;
    public string creative;
    public string adid;
    public string clickLabel;
    public string network;
    public string trackerName;
    
    // Methods
    public JoypacAdjustAttribution(com.adjust.sdk.AdjustAttribution attribution)
    {
        this.trackerToken = "";
        this.adgroup = "";
        this.creative = "";
        this.adid = "";
        this.clickLabel = "";
        this.network = "";
        this.trackerName = "";
        if(attribution != null)
        {
                this.trackerToken = attribution.trackerToken;
            this.adgroup = attribution.adgroup;
            this.creative = attribution.creative;
            this.adid = attribution.adid;
            this.clickLabel = attribution.clickLabel;
            this.network = attribution.network;
        }
        else
        {
                this.trackerToken = 0.trackerToken;
            this.adgroup = 0.adgroup;
            this.creative = 0.creative;
            this.adid = 0.adid;
            this.clickLabel = 0.clickLabel;
            this.network = 0.network;
        }
        
        this.trackerName = attribution.trackerName;
    }

}
