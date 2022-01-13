using UnityEngine;

namespace Unity.IO.Compression
{
    internal class DeflateStreamAsyncResult : IAsyncResult
    {
        // Fields
        public byte[] buffer;
        public int offset;
        public int count;
        public bool isWrite;
        private object m_AsyncObject;
        private object m_AsyncState;
        private System.AsyncCallback m_AsyncCallback;
        private object m_Result;
        internal bool m_CompletedSynchronously;
        private int m_InvokedCallback;
        private int m_Completed;
        private object m_Event;
        
        // Properties
        public object AsyncState { get; }
        public System.Threading.WaitHandle AsyncWaitHandle { get; }
        public bool CompletedSynchronously { get; }
        public bool IsCompleted { get; }
        internal object Result { get; }
        
        // Methods
        public DeflateStreamAsyncResult(object asyncObject, object asyncState, System.AsyncCallback asyncCallback, byte[] buffer, int offset, int count)
        {
            val_1 = new System.Object();
            this.buffer = buffer;
            this.offset = offset;
            this.count = count;
            this.m_AsyncObject = asyncObject;
            this.m_AsyncState = val_1;
            this.m_CompletedSynchronously = true;
            this.m_AsyncCallback = asyncCallback;
        }
        public object get_AsyncState()
        {
            return (object)this.m_AsyncState;
        }
        public System.Threading.WaitHandle get_AsyncWaitHandle()
        {
            object val_7;
            var val_8;
            val_7 = this.m_Event;
            val_8 = null;
            if(val_7 != null)
            {
                goto label_1;
            }
            
            object val_3 = System.Threading.Interlocked.CompareExchange(location1: ref  val_7, value:  new System.Threading.ManualResetEvent(initialState:  (this.m_Completed != 0) ? 1 : 0), comparand:  0);
            val_7 = val_7;
            if(val_7 == null)
            {
                goto label_3;
            }
            
            val_8 = null;
            label_1:
            if(null != val_8)
            {
                    val_7 = 0;
            }
            
            label_3:
            if(this.m_Completed != 0)
            {
                    return (System.Threading.WaitHandle)val_7;
            }
            
            if(this.m_Completed == 0)
            {
                    return (System.Threading.WaitHandle)val_7;
            }
            
            bool val_5 = val_7.Set();
            return (System.Threading.WaitHandle)val_7;
        }
        public bool get_CompletedSynchronously()
        {
            return (bool)this.m_CompletedSynchronously;
        }
        public bool get_IsCompleted()
        {
            return (bool)(this.m_Completed != 0) ? 1 : 0;
        }
        internal object get_Result()
        {
            return (object)this.m_Result;
        }
        internal void Close()
        {
            var val_2;
            if(this.m_Event == null)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
            
            val_2 = X0;
        }
        internal void InvokeCallback(bool completedSynchronously, object result)
        {
            this.m_CompletedSynchronously = completedSynchronously;
            this.Complete(result:  result);
        }
        internal void InvokeCallback(object result)
        {
            this.Complete(result:  result);
        }
        private void Complete(bool completedSynchronously, object result)
        {
            this.m_CompletedSynchronously = completedSynchronously;
            this.Complete(result:  result);
        }
        private void Complete(object result)
        {
            object val_7;
            this.m_Result = result;
            int val_2 = System.Threading.Interlocked.Increment(location: ref  this.m_Completed);
            val_7 = this.m_Event;
            if(val_7 != null)
            {
                    if(null != null)
            {
                    val_7 = 0;
            }
            
                bool val_4 = val_7.Set();
            }
            
            if((System.Threading.Interlocked.Increment(location: ref  this.m_InvokedCallback)) != 1)
            {
                    return;
            }
            
            if(this.m_AsyncCallback == null)
            {
                    return;
            }
            
            this.m_AsyncCallback.Invoke(ar:  this);
        }
    
    }

}
