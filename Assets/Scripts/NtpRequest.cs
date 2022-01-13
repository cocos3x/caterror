using UnityEngine;
public class NtpRequest
{
    // Fields
    private System.DateTime ntpDateTime;
    private System.Threading.Thread thread;
    private System.Net.Sockets.Socket socket;
    private bool threadRunning;
    private int timeout;
    private int retryCount;
    private string[] NTP_SERVER;
    
    // Methods
    private void OnApplicationQuit()
    {
        this.CloseRequest();
    }
    public UnityEngine.Coroutine GetNetworkTime(UnityEngine.MonoBehaviour behaviour, System.Action<System.DateTime> succeededCallback, System.Action failedCallback, int timeout = 3000)
    {
        var val_2;
        if(this.threadRunning != false)
        {
                return 0;
        }
        
        this.timeout = timeout;
        this.retryCount = 0;
        val_2 = null;
        val_2 = null;
        this.ntpDateTime = System.DateTime.MinValue;
        this._threadStart();
        if(behaviour != null)
        {
                return behaviour.StartCoroutine(routine:  this.WaitForRequest(succeededCallback:  succeededCallback, failedCallback:  failedCallback));
        }
        
        return behaviour.StartCoroutine(routine:  this.WaitForRequest(succeededCallback:  succeededCallback, failedCallback:  failedCallback));
    }
    private void _threadStart()
    {
        this.threadRunning = true;
        System.Threading.Thread val_2 = new System.Threading.Thread(start:  new System.Threading.ThreadStart(object:  this, method:  System.Void NtpRequest::NetworkRequest()));
        this.thread = val_2;
        val_2.Start();
    }
    private System.Collections.IEnumerator WaitForRequest(System.Action<System.DateTime> succeededCallback, System.Action failedCallback)
    {
        NtpRequest.<WaitForRequest>d__10 val_1 = new NtpRequest.<WaitForRequest>d__10();
        .<>1__state = 0;
        if(val_1 != null)
        {
                .<>4__this = this;
            .succeededCallback = succeededCallback;
        }
        else
        {
                mem[32] = this;
            mem[40] = succeededCallback;
        }
        
        .failedCallback = failedCallback;
        return (System.Collections.IEnumerator)val_1;
    }
    private void NetworkRequest()
    {
        int val_12;
        byte[] val_1 = new byte[48];
        val_1[0] = 27;
        new System.Net.IPEndPoint() = new System.Net.IPEndPoint(address:  System.Net.Dns.GetHostEntry(hostNameOrAddress:  this.NTP_SERVER[this.retryCount]).AddressList[0], port:  123);
        new System.Net.Sockets.Socket() = new System.Net.Sockets.Socket(addressFamily:  2, socketType:  2, protocolType:  17);
        this.socket = new System.Net.Sockets.Socket();
        new System.Net.Sockets.Socket().Connect(remoteEP:  new System.Net.IPEndPoint());
        int val_6 = this.socket.Send(buffer:  val_1);
        int val_7 = this.socket.Receive(buffer:  val_1);
        this.socket.Close();
        val_12 = val_1.Length;
        if(val_12 <= 40)
        {
                val_12 = val_1.Length;
        }
        
        if(val_12 <= 41)
        {
                val_12 = val_1.Length;
        }
        
        byte val_15 = val_1[5];
        if(val_12 <= 42)
        {
                val_12 = val_1.Length;
        }
        
        byte val_16 = val_1[5];
        if(val_12 <= 43)
        {
                val_12 = val_1.Length;
        }
        
        if(val_12 <= 44)
        {
                val_12 = val_1.Length;
        }
        
        if(val_12 <= 45)
        {
                val_12 = val_1.Length;
        }
        
        byte val_19 = val_1[5];
        if(val_12 <= 46)
        {
                val_12 = val_1.Length;
        }
        
        byte val_20 = val_1[5];
        byte val_8 = val_1[5] << 24;
        byte val_9 = val_1[5] << 24;
        val_8 = val_8 | val_1[5];
        val_9 = val_9 | val_1[5];
        val_8 = val_8 * 1000;
        val_8 = (val_9 * 1000) + (val_8 >> 32);
        System.DateTime val_11 = 0.AddMilliseconds(value:  (double)val_8);
        this.ntpDateTime = val_11;
    }
    private void CloseRequest()
    {
        if(this.thread != null)
        {
                this.thread.Abort();
        }
        
        if(this.socket == null)
        {
                return;
        }
        
        this.socket.Close();
    }
    public NtpRequest()
    {
        this.timeout = 3000;
        string[] val_1 = new string[2];
        val_1[0] = "time.google.com";
        val_1[1] = "cn.pool.ntp.org";
        this.NTP_SERVER = val_1;
    }

}
