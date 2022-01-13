using UnityEngine;

namespace Unity.IO.Compression
{
    internal class OutputWindow
    {
        // Fields
        private const int WindowSize = 32768;
        private const int WindowMask = 32767;
        private byte[] window;
        private int end;
        private int bytesUsed;
        
        // Properties
        public int FreeBytes { get; }
        public int AvailableBytes { get; }
        
        // Methods
        public void Write(byte b)
        {
            this.end = this.end + 1;
            this.window[this.end] = b;
            int val_2 = this.end;
            int val_3 = this.bytesUsed;
            val_2 = val_2 & 32767;
            val_3 = val_3 + 1;
            this.end = val_2;
            this.bytesUsed = val_3;
        }
        public void WriteLengthDistance(int length, int distance)
        {
            int val_6;
            int val_7;
            int val_8;
            int val_9;
            System.Byte[] val_10;
            int val_11;
            val_6 = this.end;
            int val_5 = this.bytesUsed;
            val_7 = length;
            var val_4 = 32768;
            val_4 = val_4 - val_7;
            val_5 = val_5 + val_7;
            val_8 = (val_6 - distance) & 32767;
            this.bytesUsed = val_5;
            if((val_6 >= val_4) || (val_8 > val_4))
            {
                goto label_1;
            }
            
            if(val_7 <= distance)
            {
                goto label_2;
            }
            
            if(val_7 >= 1)
            {
                goto label_3;
            }
            
            return;
            label_8:
            val_9 = this.end;
            val_7 = val_7 - 1;
            val_8 = val_8 + 1;
            label_3:
            val_10 = this.window;
            this.end = val_9 + 1;
            val_11 = (long)val_9;
            val_10[val_11] = val_10[(long)val_8];
            if(val_7 >= 2)
            {
                goto label_8;
            }
            
            return;
            label_1:
            if(val_7 < 1)
            {
                    return;
            }
            
            val_7 = val_7 + 1;
            do
            {
                val_10 = this.window;
                this.end = val_6 + 1;
                val_8 = val_8 + 1;
                val_10[(long)val_6] = val_10[val_8];
                val_7 = val_7 - 1;
                val_8 = val_8 & 32767;
                val_11 = this.end & 32767;
                this.end = val_11;
            }
            while(val_7 > 1);
            
            return;
            label_2:
            System.Array.Copy(sourceArray:  this.window, sourceIndex:  val_8, destinationArray:  this.window, destinationIndex:  val_6, length:  val_7);
            int val_8 = this.end;
            val_8 = val_8 + val_7;
            this.end = val_8;
        }
        public int CopyFrom(Unity.IO.Compression.InputBuffer input, int length)
        {
            int val_11;
            var val_12;
            int val_12 = 32768;
            int val_11 = input.start;
            val_11 = input.end - val_11;
            int val_6 = System.Math.Min(val1:  System.Math.Min(val1:  length, val2:  val_12 - this.bytesUsed), val2:  val_11 + (((input.bitsInBuffer < 0) ? (input.bitsInBuffer + 7) : input.bitsInBuffer) >> 3));
            val_11 = this.end;
            int val_7 = val_12 - val_11;
            val_12 = val_6 - val_7;
            if(input.bitsInBuffer <= 0)
            {
                goto label_5;
            }
            
            val_12 = input;
            if((val_12.CopyTo(output:  this.window, offset:  val_11, length:  val_7)) != val_7)
            {
                goto label_8;
            }
            
            val_11 = this.window;
            val_12 = (input.CopyTo(output:  val_11, offset:  0, length:  val_12)) + val_7;
            goto label_8;
            label_5:
            val_12 = input;
            int val_10 = val_12.CopyTo(output:  this.window, offset:  val_11, length:  val_6);
            label_8:
            int val_13 = this.end;
            int val_14 = this.bytesUsed;
            val_13 = val_13 + val_10;
            val_14 = val_14 + val_10;
            val_13 = val_13 & 32767;
            this.end = val_13;
            this.bytesUsed = val_14;
            return val_10;
        }
        public int get_FreeBytes()
        {
            return (int)32768 - this.bytesUsed;
        }
        public int get_AvailableBytes()
        {
            return (int)this.bytesUsed;
        }
        public int CopyTo(byte[] output, int offset, int length)
        {
            int val_4;
            int val_5;
            int val_6;
            int val_7;
            val_4 = this.end;
            int val_4 = this.bytesUsed;
            val_5 = length;
            val_6 = offset;
            if(val_4 < val_5)
            {
                    val_5 = val_4;
            }
            else
            {
                    val_4 = val_5 - val_4;
                val_4 = val_4 + val_4;
                val_4 = val_4 & 32767;
            }
            
            int val_1 = val_5 - val_4;
            if(val_1 > 0)
            {
                    System.Array.Copy(sourceArray:  this.window, sourceIndex:  32768 - val_1, destinationArray:  output, destinationIndex:  val_6, length:  val_1);
                val_6 = val_1 + val_6;
                val_7 = val_4;
            }
            else
            {
                    val_7 = val_5;
            }
            
            System.Array.Copy(sourceArray:  this.window, sourceIndex:  val_4 - val_7, destinationArray:  output, destinationIndex:  val_6, length:  val_7);
            int val_5 = this.bytesUsed;
            val_5 = val_5 - val_5;
            this.bytesUsed = val_5;
            return val_5;
        }
        public OutputWindow()
        {
            this.window = new byte[32768];
        }
    
    }

}
