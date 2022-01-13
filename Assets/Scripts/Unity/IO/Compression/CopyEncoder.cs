using UnityEngine;

namespace Unity.IO.Compression
{
    internal class CopyEncoder
    {
        // Fields
        private const int PaddingSize = 5;
        private const int MaxUncompressedBlockSize = 65536;
        
        // Methods
        public void GetBlock(Unity.IO.Compression.DeflateInput input, Unity.IO.Compression.OutputBuffer output, bool isFinal)
        {
            System.Byte[] val_5;
            bool val_6;
            int val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            val_5 = isFinal;
            val_6 = true;
            if(input == null)
            {
                goto label_1;
            }
            
            int val_6 = input.count;
            val_7 = output.byteBuffer.Length;
            var val_5 = 5;
            val_5 = val_5 - output.pos;
            val_5 = val_5 + val_7;
            int val_4 = System.Math.Min(val1:  val_6, val2:  val_5 - (((output.bitCount < 0) ? (output.bitCount + 7) : output.bitCount) >> 3));
            val_6 = 65531;
            val_8 = 0;
            val_6 = (val_4 < 65531) ? (val_4) : 65531;
            if(val_5 == false)
            {
                goto label_15;
            }
            
            label_14:
            val_10 = 3;
            val_11 = 1;
            goto label_7;
            label_1:
            if(output == null)
            {
                goto label_8;
            }
            
            val_8 = 0;
            val_9 = 0;
            if(val_5 == true)
            {
                goto label_14;
            }
            
            label_15:
            val_10 = 3;
            val_11 = 0;
            label_7:
            output.WriteBits(n:  3, bits:  0);
            output.FlushBits();
            output.WriteLenNLen(len:  0, output:  output);
            if(val_9 < 1)
            {
                    return;
            }
            
            if(input == null)
            {
                    return;
            }
            
            val_5 = input.buffer;
            val_7 = input.startIndex;
            output.WriteBytes(byteArray:  val_5, offset:  val_7, count:  0);
            int val_8 = input.count;
            int val_7 = input.startIndex;
            val_7 = val_7 + val_9;
            val_8 = val_8 - val_9;
            input.count = val_8;
            input.startIndex = val_7;
            return;
            label_8:
            if(val_5 == true)
            {
                goto label_14;
            }
            
            goto label_15;
        }
        private void WriteLenNLen(ushort len, Unity.IO.Compression.OutputBuffer output)
        {
            if(output != null)
            {
                    output.WriteUInt16(value:  len);
            }
            else
            {
                    0.WriteUInt16(value:  len);
            }
            
            output.WriteUInt16(value:  ~len);
        }
        public CopyEncoder()
        {
        
        }
    
    }

}
