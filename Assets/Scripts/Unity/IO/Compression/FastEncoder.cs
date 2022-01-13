using UnityEngine;

namespace Unity.IO.Compression
{
    internal class FastEncoder
    {
        // Fields
        private Unity.IO.Compression.FastEncoderWindow inputWindow;
        private Unity.IO.Compression.Match currentMatch;
        private double lastCompressionRatio;
        
        // Properties
        internal int BytesInHistory { get; }
        internal Unity.IO.Compression.DeflateInput UnprocessedInput { get; }
        internal double LastCompressionRatio { get; }
        
        // Methods
        public FastEncoder()
        {
            Unity.IO.Compression.FastEncoderWindow val_1 = new Unity.IO.Compression.FastEncoderWindow();
            val_1.ResetWindow();
            this.inputWindow = val_1;
            this.currentMatch = new Unity.IO.Compression.Match();
        }
        internal int get_BytesInHistory()
        {
            return (int)this.inputWindow.bufEnd - this.inputWindow.bufPos;
        }
        internal Unity.IO.Compression.DeflateInput get_UnprocessedInput()
        {
            if(this.inputWindow != null)
            {
                    return this.inputWindow.UnprocessedInput;
            }
            
            return this.inputWindow.UnprocessedInput;
        }
        internal void FlushInput()
        {
            this.inputWindow.ResetWindow();
        }
        internal double get_LastCompressionRatio()
        {
            return (double)this.lastCompressionRatio;
        }
        internal void GetBlock(Unity.IO.Compression.DeflateInput input, Unity.IO.Compression.OutputBuffer output, int maxBytesToCopy)
        {
            Unity.IO.Compression.FastEncoder.WriteDeflatePreamble(output:  output);
            this.GetCompressedOutput(input:  input, output:  output, maxBytesToCopy:  maxBytesToCopy);
            this.WriteEndOfBlock(output:  output);
        }
        internal void GetCompressedData(Unity.IO.Compression.DeflateInput input, Unity.IO.Compression.OutputBuffer output)
        {
            this.GetCompressedOutput(input:  input, output:  output, maxBytesToCopy:  0);
        }
        internal void GetBlockHeader(Unity.IO.Compression.OutputBuffer output)
        {
            Unity.IO.Compression.FastEncoder.WriteDeflatePreamble(output:  output);
        }
        internal void GetBlockFooter(Unity.IO.Compression.OutputBuffer output)
        {
            this.WriteEndOfBlock(output:  output);
        }
        private void GetCompressedOutput(Unity.IO.Compression.DeflateInput input, Unity.IO.Compression.OutputBuffer output, int maxBytesToCopy)
        {
            int val_7;
            var val_8;
            int val_9;
            val_7 = input.count;
            val_8 = 0;
            goto label_4;
            label_16:
            if((val_8 >= maxBytesToCopy) || ((this.InputAvailable(input:  input)) == false))
            {
                goto label_6;
            }
            
            val_7 = input.count;
            label_4:
            int val_6 = this.inputWindow.bufEnd;
            val_6 = 16384 - val_6;
            if(val_7 < val_6)
            {
                    val_9 = input.count;
            }
            else
            {
                    val_9 = 16384 - this.inputWindow.bufEnd;
            }
            
            if(maxBytesToCopy >= 1)
            {
                    val_9 = System.Math.Min(val1:  val_9, val2:  maxBytesToCopy - val_8);
            }
            
            if(val_9 >= 1)
            {
                    System.Array.Copy(sourceArray:  input.buffer, sourceIndex:  input.startIndex, destinationArray:  this.inputWindow.window, destinationIndex:  this.inputWindow.bufEnd, length:  val_9);
                int val_7 = this.inputWindow.bufEnd;
                val_8 = val_9 + val_8;
                val_7 = val_7 + val_9;
                this.inputWindow.bufEnd = val_7;
                int val_9 = input.count;
                int val_8 = input.startIndex;
                val_8 = val_8 + val_9;
                val_9 = val_9 - val_9;
                input.count = val_9;
                input.startIndex = val_8;
            }
            
            this.GetCompressedOutput(output:  output);
            if((this.SafeToWriteTo(output:  output)) == true)
            {
                goto label_16;
            }
            
            label_6:
            int val_5 = output.pos - output.pos;
            if(this.inputWindow == null)
            {
                goto label_18;
            }
            
            if(val_5 == 0)
            {
                    return;
            }
            
            label_20:
            int val_10 = this.inputWindow.bufPos;
            int val_11 = input.count;
            double val_12 = (double)val_5;
            val_10 = this.inputWindow.bufEnd - val_10;
            val_10 = val_10 + val_7;
            val_11 = val_10 - val_11;
            val_11 = val_11 - this.inputWindow.bufEnd;
            val_11 = val_11 + this.inputWindow.bufPos;
            val_12 = val_12 / (double)val_11;
            this.lastCompressionRatio = val_12;
            return;
            label_18:
            if(val_5 != 0)
            {
                goto label_20;
            }
        
        }
        private void GetCompressedOutput(Unity.IO.Compression.OutputBuffer output)
        {
            Unity.IO.Compression.Match val_3;
            int val_4;
            int val_5;
            Unity.IO.Compression.Match val_6;
            goto label_5;
            label_15:
            if((this.SafeToWriteTo(output:  output)) == false)
            {
                    return;
            }
            
            bool val_2 = this.inputWindow.GetNextSymbolOrMatch(match:  this.currentMatch);
            val_3 = this.currentMatch;
            if(val_3 == null)
            {
                goto label_3;
            }
            
            if(this.currentMatch.state != 1)
            {
                goto label_4;
            }
            
            label_7:
            Unity.IO.Compression.FastEncoder.WriteChar(b:  this.currentMatch.symbol, output:  output);
            goto label_5;
            label_3:
            if(this.currentMatch == null)
            {
                goto label_13;
            }
            
            val_3 = this.currentMatch;
            if(this.currentMatch.state == 1)
            {
                goto label_7;
            }
            
            label_4:
            if(this.currentMatch.state != 2)
            {
                goto label_9;
            }
            
            val_4 = this.currentMatch.pos;
            val_5 = this.currentMatch.len;
            goto label_11;
            label_9:
            Unity.IO.Compression.FastEncoder.WriteChar(b:  this.currentMatch.symbol, output:  output);
            val_6 = this.currentMatch;
            if(this.currentMatch != null)
            {
                goto label_12;
            }
            
            val_6 = this.currentMatch;
            if(val_6 == null)
            {
                goto label_13;
            }
            
            label_12:
            val_5 = this.currentMatch.len;
            val_4 = this.currentMatch.pos;
            label_11:
            Unity.IO.Compression.FastEncoder.WriteMatch(matchLen:  val_5, matchPos:  val_4, output:  output);
            label_5:
            int val_3 = this.inputWindow.bufPos;
            val_3 = this.inputWindow.bufEnd - val_3;
            if(val_3 >= 1)
            {
                goto label_15;
            }
            
            return;
            label_13:
        }
        private bool InputAvailable(Unity.IO.Compression.DeflateInput input)
        {
            Unity.IO.Compression.FastEncoderWindow val_2;
            var val_3;
            val_2 = this;
            if(input.count > 0)
            {
                    val_3 = 1;
                return (bool)(val_2 > 0) ? 1 : 0;
            }
            
            val_2 = this.inputWindow;
            int val_2 = this.inputWindow.bufPos;
            val_2 = this.inputWindow.bufEnd - val_2;
            return (bool)(val_2 > 0) ? 1 : 0;
        }
        private bool SafeToWriteTo(Unity.IO.Compression.OutputBuffer output)
        {
            int val_2 = output.pos;
            val_2 = output.byteBuffer.Length - val_2;
            return (bool)(val_2 > 16) ? 1 : 0;
        }
        private void WriteEndOfBlock(Unity.IO.Compression.OutputBuffer output)
        {
            null = null;
            output.WriteBits(n:  (Unity.IO.Compression.FastEncoderStatics.FastEncoderLiteralCodeInfo + 1056) & 31, bits:  (Unity.IO.Compression.FastEncoderStatics.FastEncoderLiteralCodeInfo + 1056) >> 5);
        }
        internal static void WriteMatch(int matchLen, int matchPos, Unity.IO.Compression.OutputBuffer output)
        {
            var val_13;
            uint val_14;
            int val_15;
            var val_16;
            var val_17;
            val_13 = null;
            val_13 = null;
            System.UInt32[] val_2 = Unity.IO.Compression.FastEncoderStatics.FastEncoderLiteralCodeInfo + (((long)(int)((matchLen + 254))) << 2);
            int val_3 = ((Unity.IO.Compression.FastEncoderStatics.FastEncoderLiteralCodeInfo + ((long)(int)((matchLen + 254))) << 2) + 32) & 31;
            if((matchLen + 254) > Unity.IO.Compression.FastEncoderStatics.FastEncoderLiteralCodeInfo.Length)
            {
                    output.WriteBits(n:  16, bits:  (uint)(((Unity.IO.Compression.FastEncoderStatics.FastEncoderLiteralCodeInfo + ((long)(int)((matchLen + 254))) << 2) + 32) >> 5) & 65535);
                val_14 = ((Unity.IO.Compression.FastEncoderStatics.FastEncoderLiteralCodeInfo + ((long)(int)((matchLen + 254))) << 2) + 32) >> 21;
                val_15 = val_3 - 16;
            }
            else
            {
                    val_14 = ((Unity.IO.Compression.FastEncoderStatics.FastEncoderLiteralCodeInfo + ((long)(int)((matchLen + 254))) << 2) + 32) >> 5;
                val_15 = val_3;
            }
            
            output.WriteBits(n:  val_15, bits:  val_14);
            val_16 = null;
            val_16 = null;
            int val_5 = Unity.IO.Compression.FastEncoderStatics.GetSlot(pos:  matchPos);
            System.UInt32[] val_6 = Unity.IO.Compression.FastEncoderStatics.FastEncoderDistanceCodeInfo + (((long)(int)(val_5)) << 2);
            output.WriteBits(n:  ((Unity.IO.Compression.FastEncoderStatics.FastEncoderDistanceCodeInfo + ((long)(int)(val_5)) << 2) + 32) & 15, bits:  ((Unity.IO.Compression.FastEncoderStatics.FastEncoderDistanceCodeInfo + ((long)(int)(val_5)) << 2) + 32) >> 8);
            if(((uint)(((Unity.IO.Compression.FastEncoderStatics.FastEncoderDistanceCodeInfo + ((long)(int)(val_5)) << 2) + 32) >> 4) & 15) == 0)
            {
                    return;
            }
            
            val_17 = null;
            val_17 = null;
            System.UInt32[] val_9 = Unity.IO.Compression.FastEncoderStatics.BitMask + (((uint)(((Unity.IO.Compression.FastEncoderStatics.FastEncoderDistanceCodeInfo + ((long)(int)(val_5)) << 2) + 32>>4) & 0xF)) << 2);
            output.WriteBits(n:  (uint)(((Unity.IO.Compression.FastEncoderStatics.FastEncoderDistanceCodeInfo + ((long)(int)(val_5)) << 2) + 32) >> 4) & 15, bits:  ((Unity.IO.Compression.FastEncoderStatics.BitMask + ((uint)(((Unity.IO.Compression.FastEncoderStatics.FastEncoderDistanceCodeInfo + ((long)(int)(val_5)) << 2) + 32>>4) & 0xF)) << 2) + 32) & matchPos);
        }
        internal static void WriteChar(byte b, Unity.IO.Compression.OutputBuffer output)
        {
            var val_4;
            byte val_4 = b;
            val_4 = null;
            val_4 = null;
            val_4 = val_4 & 255;
            System.UInt32[] val_1 = Unity.IO.Compression.FastEncoderStatics.FastEncoderLiteralCodeInfo + (((b & 255)) << 2);
            output.WriteBits(n:  ((Unity.IO.Compression.FastEncoderStatics.FastEncoderLiteralCodeInfo + ((b & 255)) << 2) + 32) & 31, bits:  ((Unity.IO.Compression.FastEncoderStatics.FastEncoderLiteralCodeInfo + ((b & 255)) << 2) + 32) >> 5);
        }
        internal static void WriteDeflatePreamble(Unity.IO.Compression.OutputBuffer output)
        {
            null = null;
            if(Unity.IO.Compression.FastEncoderStatics.MaxCodeLen == 0)
            {
                goto label_3;
            }
            
            if(output == null)
            {
                goto label_4;
            }
            
            label_6:
            output.WriteBytes(byteArray:  Unity.IO.Compression.FastEncoderStatics.MaxCodeLen, offset:  0, count:  Unity.IO.Compression.FastEncoderStatics.MaxCodeLen + 24);
            goto label_5;
            label_3:
            if(output != null)
            {
                goto label_6;
            }
            
            label_4:
            0.WriteBytes(byteArray:  Unity.IO.Compression.FastEncoderStatics.MaxCodeLen, offset:  0, count:  Unity.IO.Compression.FastEncoderStatics.MaxCodeLen + 24);
            label_5:
            output.WriteBits(n:  9, bits:  34);
        }
    
    }

}
