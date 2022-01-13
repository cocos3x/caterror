using UnityEngine;

namespace Unity.IO.Compression
{
    internal class DeflateInput
    {
        // Fields
        private byte[] buffer;
        private int count;
        private int startIndex;
        
        // Properties
        internal byte[] Buffer { get; set; }
        internal int Count { get; set; }
        internal int StartIndex { get; set; }
        
        // Methods
        internal byte[] get_Buffer()
        {
            return (System.Byte[])this.buffer;
        }
        internal void set_Buffer(byte[] value)
        {
            this.buffer = value;
        }
        internal int get_Count()
        {
            return (int)this.count;
        }
        internal void set_Count(int value)
        {
            this.count = value;
        }
        internal int get_StartIndex()
        {
            return (int)this.startIndex;
        }
        internal void set_StartIndex(int value)
        {
            this.startIndex = value;
        }
        internal void ConsumeBytes(int n)
        {
            int val_2 = this.count;
            int val_1 = this.startIndex;
            val_1 = val_1 + n;
            val_2 = val_2 - n;
            this.count = val_2;
            this.startIndex = val_1;
        }
        internal Unity.IO.Compression.DeflateInput.InputState DumpState()
        {
            return new InputState() {count = this.count, startIndex = this.count};
        }
        internal void RestoreState(Unity.IO.Compression.DeflateInput.InputState state)
        {
            this.count = state.count;
            this.startIndex = state.count >> 32;
        }
        public DeflateInput()
        {
        
        }
    
    }

}
