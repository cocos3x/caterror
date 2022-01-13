using UnityEngine;
private sealed class IAPDemo.<>c__DisplayClass38_0
{
    // Fields
    public string txId;
    
    // Methods
    public IAPDemo.<>c__DisplayClass38_0()
    {
    
    }
    internal void <ValidateButtonClick>b__0(bool success, string signData, string signature)
    {
        object[] val_1 = new object[4];
        val_1[0] = this.txId;
        val_1[1] = success;
        val_1[2] = signData;
        val_1[3] = signature;
        UnityEngine.Debug.LogFormat(format:  "ValidateReceipt transactionId {0}, success {1}, signData {2}, signature {3}", args:  val_1);
    }

}
