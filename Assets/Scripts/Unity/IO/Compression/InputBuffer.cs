using UnityEngine;

namespace Unity.IO.Compression
{
    internal class InputBuffer
    {
        // Fields
        private byte[] buffer;
        private int start;
        private int end;
        private uint bitBuffer;
        private int bitsInBuffer;
        
        // Properties
        public int AvailableBits { get; }
        public int AvailableBytes { get; }
        
        // Methods
        public int get_AvailableBits()
        {
            return (int)this.bitsInBuffer;
        }
        public int get_AvailableBytes()
        {
            int val_4 = this.start;
            val_4 = this.end - val_4;
            return (int)val_4 + (((this.bitsInBuffer < 0) ? (this.bitsInBuffer + 7) : this.bitsInBuffer) >> 3);
        }
        public bool EnsureBitsAvailable(int count)
        {
            var val_6;
            uint val_7;
            if(this.bitsInBuffer >= count)
            {
                goto label_5;
            }
            
            if((long)this.start != this.end)
            {
                goto label_1;
            }
            
            label_6:
            val_6 = 0;
            return (bool)val_6;
            label_1:
            val_7 = this.bitBuffer;
            this.start = (long)this.start + 1;
            int val_7 = this.bitsInBuffer;
            byte val_6 = this.buffer[(long)this.start];
            val_7 = val_7 + 8;
            val_6 = val_6 << (val_7 & 31);
            byte val_3 = val_6 | val_7;
            this.bitBuffer = val_3;
            this.bitsInBuffer = val_7;
            if(val_7 >= count)
            {
                goto label_5;
            }
            
            val_7 = (long)this.start;
            if(val_7 == this.end)
            {
                goto label_6;
            }
            
            this.start = val_7 + 1;
            int val_9 = this.bitsInBuffer;
            byte val_8 = this.buffer[val_7];
            val_9 = val_9 + 8;
            val_8 = val_8 << (val_9 & 31);
            val_8 = val_8 | val_3;
            this.bitBuffer = val_8;
            this.bitsInBuffer = val_9;
            label_5:
            val_6 = 1;
            return (bool)val_6;
        }
        public uint TryLoad16Bits()
        {
            var val_6;
            System.Byte[] val_7;
            uint val_8;
            int val_9;
            int val_10;
            if(this.bitsInBuffer <= 7)
            {
                goto label_0;
            }
            
            if(this.bitsInBuffer > 15)
            {
                    return (uint)this.bitBuffer;
            }
            
            val_6 = (long)this.start;
            if(val_6 >= this.end)
            {
                    return (uint)this.bitBuffer;
            }
            
            val_7 = this.buffer;
            val_8 = this.bitBuffer;
            this.start = val_6 + 1;
            if(val_6 >= this.buffer.Length)
            {
                goto label_4;
            }
            
            goto label_11;
            label_0:
            val_9 = this.start;
            val_10 = this.end;
            if(val_9 < val_10)
            {
                    val_8 = this.bitBuffer;
                this.start = val_9 + 1;
                int val_7 = this.bitsInBuffer;
                byte val_6 = this.buffer[(long)val_9];
                val_9 = this.start;
                val_10 = this.end;
                val_6 = val_6 << (val_7 & 31);
                val_7 = val_7 + 8;
                val_6 = val_6 | val_8;
                this.bitBuffer = val_6;
                this.bitsInBuffer = val_7;
            }
            
            if(val_9 >= val_10)
            {
                    return (uint)this.bitBuffer;
            }
            
            val_7 = this.buffer;
            val_8 = this.bitBuffer;
            this.start = val_9 + 1;
            val_6 = (long)val_9;
            if(val_9 < this.buffer.Length)
            {
                goto label_11;
            }
            
            label_4:
            label_11:
            int val_9 = this.bitsInBuffer;
            byte val_8 = val_7[val_6];
            val_9 = val_9 + 8;
            val_8 = val_8 << (val_9 & 31);
            val_8 = val_8 | val_8;
            this.bitBuffer = val_8;
            this.bitsInBuffer = val_9;
            return (uint)this.bitBuffer;
        }
        private uint GetBitMask(int count)
        {
            int val_1 = count & 31;
            val_1 = 1 << val_1;
            return (uint)val_1 - 1;
        }
        public int GetBits(int count)
        {
            var val_4;
            if((this.EnsureBitsAvailable(count:  count)) != false)
            {
                    int val_4 = this.bitsInBuffer;
                int val_2 = count & 31;
                var val_3 = 1;
                val_3 = val_3 << val_2;
                val_3 = val_3 - 1;
                val_2 = this.bitBuffer >> val_2;
                val_4 = val_4 - count;
                val_4 = this.bitBuffer & val_3;
                this.bitBuffer = val_2;
                this.bitsInBuffer = val_4;
                return (int)val_4;
            }
            
            val_4 = 0;
            return (int)val_4;
        }
        public int CopyTo(byte[] output, int offset, int length)
        {
            var val_6;
            var val_7;
            int val_8;
            int val_9;
            val_6 = length;
            val_7 = 0;
            if(val_6 < 1)
            {
                goto label_1;
            }
            
            val_8 = this.bitsInBuffer;
            if(val_8 < 1)
            {
                goto label_1;
            }
            
            var val_4 = 0;
            label_5:
            val_9 = offset + 1;
            output[(long)offset] = this.bitBuffer;
            val_4 = val_4 - 1;
            val_8 = this.bitsInBuffer - 8;
            this.bitBuffer = this.bitBuffer >> 8;
            this.bitsInBuffer = val_8;
            if((val_6 + val_4) >= 2)
            {
                    if(val_8 > 0)
            {
                goto label_5;
            }
            
            }
            
            val_6 = val_6 + val_4;
            val_7 = -val_4;
            if(val_6 != 0)
            {
                goto label_6;
            }
            
            return (int)val_7;
            label_1:
            val_9 = offset;
            if(val_6 == 0)
            {
                    return (int)val_7;
            }
            
            label_6:
            int val_5 = this.end;
            val_5 = val_5 - this.start;
            int val_3 = (val_6 > val_5) ? (val_5) : (val_6);
            System.Array.Copy(sourceArray:  this.buffer, sourceIndex:  this.start, destinationArray:  output, destinationIndex:  val_9, length:  val_3);
            int val_6 = this.start;
            val_7 = val_3 + val_7;
            val_6 = val_3 + val_6;
            this.start = val_6;
            return (int)val_7;
        }
        public bool NeedsInput()
        {
            return (bool)(this.start == this.end) ? 1 : 0;
        }
        public void SetInput(byte[] buffer, int offset, int length)
        {
            this.buffer = buffer;
            this.start = offset;
            this.end = length + offset;
        }
        public void SkipBits(int n)
        {
            uint val_2 = this.bitBuffer;
            int val_3 = this.bitsInBuffer;
            val_2 = val_2 >> (n & 31);
            val_3 = val_3 - n;
            this.bitBuffer = val_2;
            this.bitsInBuffer = val_3;
        }
        public void SkipToByteBoundary()
        {
            int val_3 = this.bitsInBuffer;
            int val_2 = (val_3 < 0) ? (val_3 + 7) : (val_3);
            val_2 = val_2 & 4294967288;
            val_3 = val_3 - val_2;
            val_3 = val_3 & 31;
            val_3 = this.bitBuffer >> val_3;
            this.bitBuffer = val_3;
            this.bitsInBuffer = val_2;
        }
        public InputBuffer()
        {
        
        }
    
    }

}
