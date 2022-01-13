using UnityEngine;

namespace Unity.IO.Compression
{
    internal class OutputBuffer
    {
        // Fields
        private byte[] byteBuffer;
        private int pos;
        private uint bitBuf;
        private int bitCount;
        
        // Properties
        internal int BytesWritten { get; }
        internal int FreeBytes { get; }
        internal int BitsInBuffer { get; }
        
        // Methods
        internal void UpdateBuffer(byte[] output)
        {
            this.byteBuffer = output;
            this.pos = 0;
        }
        internal int get_BytesWritten()
        {
            return (int)this.pos;
        }
        internal int get_FreeBytes()
        {
            return (int)this.byteBuffer.Length - this.pos;
        }
        internal void WriteUInt16(ushort value)
        {
            this.pos = this.pos + 1;
            this.byteBuffer[this.pos] = value;
            this.pos = this.pos + 1;
            this.byteBuffer[this.pos] = value >> 8;
        }
        internal void WriteBits(int n, uint bits)
        {
            int val_6 = this.bitCount;
            int val_1 = val_6 & 31;
            val_6 = val_6 + n;
            val_1 = bits << val_1;
            uint val_2 = val_1 | this.bitBuf;
            this.bitBuf = val_2;
            this.bitCount = val_6;
            if(val_6 < 16)
            {
                    return;
            }
            
            this.pos = this.pos + 1;
            this.byteBuffer[this.pos] = val_2;
            this.pos = (long)this.pos + 1;
            this.byteBuffer[(long)this.pos] = this.bitBuf >> 8;
            int val_7 = this.bitCount;
            val_7 = val_7 - 16;
            this.bitBuf = this.byteBuffer[(long)this.pos];
            this.bitCount = val_7;
        }
        internal void FlushBits()
        {
            int val_4;
            int val_5;
            val_4 = this.bitCount;
            if(val_4 >= 8)
            {
                    do
            {
                val_5 = this.pos;
                this.pos = val_5 + 1;
                this.byteBuffer[val_5] = this.bitBuf;
                val_4 = this.bitCount - 8;
                this.bitBuf = this.bitBuf >> 8;
                this.bitCount = val_4;
            }
            while(val_4 > 7);
            
            }
            
            if(val_4 < 1)
            {
                    return;
            }
            
            val_5 = this.byteBuffer;
            this.pos = (long)this.pos + 1;
            val_5[(long)this.pos] = this.bitBuf;
            this.bitBuf = 0;
            this.bitCount = 0;
        }
        internal void WriteBytes(byte[] byteArray, int offset, int count)
        {
            if(this.bitCount != 0)
            {
                    this.WriteBytesUnaligned(byteArray:  byteArray, offset:  offset, count:  count);
                return;
            }
            
            System.Array.Copy(sourceArray:  byteArray, sourceIndex:  offset, destinationArray:  this.byteBuffer, destinationIndex:  this.pos, length:  count);
            int val_1 = this.pos;
            val_1 = val_1 + count;
            this.pos = val_1;
        }
        private void WriteBytesUnaligned(byte[] byteArray, int offset, int count)
        {
            int val_1 = offset;
            if(count < 1)
            {
                    return;
            }
            
            int val_2 = count;
            do
            {
                this.WriteBits(n:  8, bits:  byteArray[(long)val_1]);
                val_2 = val_2 - 1;
                val_1 = val_1 + 1;
            }
            while(val_2 != 0);
        
        }
        private void WriteByteUnaligned(byte b)
        {
            this.WriteBits(n:  8, bits:  b & 255);
        }
        internal int get_BitsInBuffer()
        {
            int val_3 = this.bitCount;
            val_3 = (val_3 < 0) ? (val_3 + 7) : (val_3);
            val_3 = val_3 >> 3;
            return (int)val_3 + 1;
        }
        internal Unity.IO.Compression.OutputBuffer.BufferState DumpState()
        {
            return new BufferState() {pos = this.pos, bitBuf = this.pos, bitCount = this.bitCount};
        }
        internal void RestoreState(Unity.IO.Compression.OutputBuffer.BufferState state)
        {
            this.pos = state.pos;
            this.bitBuf = state.pos >> 32;
            this.bitCount = state.bitCount;
        }
        public OutputBuffer()
        {
        
        }
    
    }

}
