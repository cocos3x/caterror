using UnityEngine;

namespace Unity.IO.Compression
{
    internal class FastEncoderWindow
    {
        // Fields
        private byte[] window;
        private int bufPos;
        private int bufEnd;
        private const int FastEncoderHashShift = 4;
        private const int FastEncoderHashtableSize = 2048;
        private const int FastEncoderHashMask = 2047;
        private const int FastEncoderWindowSize = 8192;
        private const int FastEncoderWindowMask = 8191;
        private const int FastEncoderMatch3DistThreshold = 16384;
        internal const int MaxMatch = 258;
        internal const int MinMatch = 3;
        private const int SearchDepth = 32;
        private const int GoodLength = 4;
        private const int NiceLength = 32;
        private const int LazyMatchThreshold = 6;
        private ushort[] prev;
        private ushort[] lookup;
        
        // Properties
        public int BytesAvailable { get; }
        public Unity.IO.Compression.DeflateInput UnprocessedInput { get; }
        public int FreeWindowSpace { get; }
        
        // Methods
        public FastEncoderWindow()
        {
            this.ResetWindow();
        }
        public int get_BytesAvailable()
        {
            return (int)this.bufEnd - this.bufPos;
        }
        public Unity.IO.Compression.DeflateInput get_UnprocessedInput()
        {
            int val_3;
            int val_4;
            Unity.IO.Compression.DeflateInput val_1 = new Unity.IO.Compression.DeflateInput();
            if(val_1 != null)
            {
                    .buffer = this.window;
                .startIndex = this.bufPos;
                val_4 = this.bufPos;
                val_3 = this.bufEnd;
            }
            else
            {
                    mem[16] = this.window;
                .startIndex = this.bufPos;
                val_4 = this.bufPos;
                val_3 = this.bufEnd;
            }
            
            .count = val_3 - val_4;
            return val_1;
        }
        public void FlushWindow()
        {
            this.ResetWindow();
        }
        private void ResetWindow()
        {
            this.window = new byte[16646];
            this.prev = new ushort[8450];
            this.lookup = new ushort[2048];
            this.bufPos = 35184372097024;
            this.bufEnd = 8192;
        }
        public int get_FreeWindowSpace()
        {
            return (int)16384 - this.bufEnd;
        }
        public void CopyBytes(byte[] inputBuffer, int startIndex, int count)
        {
            System.Array.Copy(sourceArray:  inputBuffer, sourceIndex:  startIndex, destinationArray:  this.window, destinationIndex:  this.bufEnd, length:  count);
            int val_1 = this.bufEnd;
            val_1 = val_1 + count;
            this.bufEnd = val_1;
        }
        public void MoveWindows()
        {
            ushort val_4;
            ushort val_5;
            System.Array.Copy(sourceArray:  this.window, sourceIndex:  this.bufPos - 8192, destinationArray:  this.window, destinationIndex:  0, length:  8192);
            var val_5 = 16;
            label_7:
            ushort val_4 = this.lookup[0];
            if(val_4 <= 8192)
            {
                goto label_3;
            }
            
            val_4 = val_4 + 57344;
            if((val_5 - 16) < this.lookup.Length)
            {
                goto label_5;
            }
            
            goto label_5;
            label_3:
            val_4 = 0;
            label_5:
            this.lookup[0] = val_4;
            val_5 = val_5 + 1;
            if(val_5 != 2064)
            {
                goto label_7;
            }
            
            var val_7 = 16;
            label_15:
            ushort val_6 = this.prev[0];
            if(val_6 <= 8192)
            {
                goto label_11;
            }
            
            val_5 = val_6 + 57344;
            if((val_7 - 16) < this.prev.Length)
            {
                goto label_13;
            }
            
            goto label_13;
            label_11:
            val_5 = 0;
            label_13:
            this.prev[0] = val_5;
            val_7 = val_7 + 1;
            if(val_7 != 8208)
            {
                goto label_15;
            }
            
            this.bufPos = 35184372097024;
            this.bufEnd = 8192;
        }
        private uint HashValue(uint hash, byte b)
        {
            return (uint)(b & 255) ^ (hash << 4);
        }
        private uint InsertString(ref uint hash)
        {
            System.Byte[] val_3 = this.window;
            val_3 = (val_3[(long)this.bufPos + 2]) ^ (hash << 4);
            hash = val_3;
            val_3 = val_3 & 2047;
            byte val_5 = hash;
            ushort val_4 = this.lookup[val_3];
            val_5 = val_5 & 2047;
            this.lookup[val_5] = this.bufPos;
            int val_6 = this.bufPos;
            val_6 = val_6 & 8191;
            this.prev[val_6] = val_4;
            return (uint)val_4;
        }
        private void InsertStrings(ref uint hash, int matchLen)
        {
            int val_6 = this.bufPos;
            int val_4 = this.bufEnd;
            int val_1 = matchLen - 1;
            val_4 = val_4 - val_6;
            if(val_4 > matchLen)
            {
                    if(val_1 < 1)
            {
                    return;
            }
            
                do
            {
                uint val_3 = this.InsertString(hash: ref  1152921512150826256);
                int val_5 = this.bufPos;
                val_1 = val_1 - 1;
                val_5 = val_5 + 1;
                this.bufPos = val_5;
            }
            while(val_1 > 0);
            
                return;
            }
            
            val_6 = val_1 + val_6;
            this.bufPos = val_6;
        }
        internal bool GetNextSymbolOrMatch(Unity.IO.Compression.Match match)
        {
            int val_15;
            int val_16;
            byte val_13 = this.window[this.bufPos];
            System.Byte[] val_21 = this.window;
            byte val_14 = val_21[(long)this.bufPos + 1];
            val_14 = val_14 ^ (val_13 << 4);
            int val_4 = 0;
            byte val_2 = val_14;
            int val_15 = this.bufPos;
            val_15 = this.bufEnd - val_15;
            if(val_15 < 4)
            {
                goto label_6;
            }
            
            uint val_3 = this.InsertString(hash: ref  val_2);
            if(val_3 == 0)
            {
                goto label_6;
            }
            
            int val_5 = this.FindMatch(search:  val_3, matchPos: out  val_4, searchDepth:  32, niceLength:  0);
            int val_16 = this.bufPos;
            val_13 = ((val_16 + val_5) > this.bufEnd) ? (this.bufEnd - val_16) : (val_5);
            if(val_13 <= 2)
            {
                goto label_6;
            }
            
            val_16 = val_16 + 1;
            this.bufPos = val_16;
            if(val_13 <= 6)
            {
                goto label_7;
            }
            
            if(match == null)
            {
                goto label_8;
            }
            
            match.state = 2;
            match.pos = 0;
            goto label_9;
            label_6:
            match.state = 1;
            match.symbol = this.window[this.bufPos];
            int val_18 = this.bufPos;
            val_18 = val_18 + 1;
            this.bufPos = val_18;
            label_25:
            if(val_18 != 16384)
            {
                    return true;
            }
            
            this.MoveWindows();
            return true;
            label_7:
            uint val_8 = this.InsertString(hash: ref  val_2);
            if(val_8 == 0)
            {
                goto label_14;
            }
            
            var val_19 = 32;
            int val_11 = this.FindMatch(search:  val_8, matchPos: out  0, searchDepth:  (val_13 < 4) ? (val_19) : 8, niceLength:  0);
            int val_20 = this.bufPos;
            val_19 = val_20 + val_11;
            val_20 = this.bufEnd - val_20;
            val_21 = (val_19 > this.bufEnd) ? (val_20) : (val_11);
            if(match != null)
            {
                goto label_23;
            }
            
            label_24:
            label_23:
            if(val_21 <= val_13)
            {
                goto label_16;
            }
            
            match.state = 3;
            val_15 = val_21;
            match.symbol = this.window[(long)this.bufPos - 1];
            match.pos = 0;
            match.len = val_21;
            val_16 = this.bufPos;
            goto label_19;
            label_16:
            match.state = 2;
            if(match == null)
            {
                goto label_20;
            }
            
            match.pos = 0;
            goto label_21;
            label_8:
            mem[16] = 2;
            mem[20] = val_4;
            label_9:
            val_15 = val_13;
            match.len = val_13;
            goto label_22;
            label_14:
            if(match != null)
            {
                goto label_23;
            }
            
            goto label_24;
            label_20:
            mem[20] = val_4;
            label_21:
            match.len = val_13;
            val_16 = this.bufPos;
            val_15 = val_13 - 1;
            label_19:
            val_16 = val_16 + 1;
            this.bufPos = val_16;
            label_22:
            this.InsertStrings(hash: ref  val_2, matchLen:  val_15);
            goto label_25;
        }
        private int FindMatch(int search, out int matchPos, int searchDepth, int niceLength)
        {
            System.Byte[] val_7;
            var val_8;
            System.Byte[] val_9;
            int val_10;
            var val_11;
            System.Byte[] val_12;
            var val_13;
            val_7 = this.window;
            val_8 = searchDepth;
            val_9 = 1152921512151582592;
            val_10 = search;
            int val_1 = this.bufPos - 8192;
            if(val_1 >= val_10)
            {
                goto label_2;
            }
            
            val_7 = val_7[this.bufPos];
            val_11 = 0;
            label_20:
            val_12 = this.window;
            val_10 = val_10;
            val_9 = (long)val_10 + val_11;
            if(val_12[val_9] != val_7)
            {
                goto label_13;
            }
            
            val_12 = 0;
            label_11:
            val_9 = this.window;
            if((this.window[(long)val_12 + this.bufPos]) != (val_9[(long)val_10 + val_12]))
            {
                goto label_10;
            }
            
            val_13 = val_12 + 1;
            val_12 = val_13;
            if(val_12 < 257)
            {
                goto label_11;
            }
            
            goto label_12;
            label_10:
            val_13 = val_12;
            label_12:
            if(val_13 <= val_11)
            {
                goto label_13;
            }
            
            if(val_13 >= 33)
            {
                goto label_14;
            }
            
            val_9 = (long)this.bufPos + val_13;
            val_7 = this.window[val_9];
            val_11 = val_13;
            label_13:
            val_8 = val_8 - 1;
            if(val_8 == 0)
            {
                goto label_17;
            }
            
            val_12 = this.prev;
            val_9 = val_10 & 8191;
            val_10 = val_12[val_9];
            if(val_1 < val_10)
            {
                goto label_20;
            }
            
            label_17:
            int val_9 = this.bufPos;
            val_9 = val_9 - val_10;
            val_9 = val_9 - 1;
            matchPos = val_9;
            if(val_11 != 3)
            {
                    return (int)val_11;
            }
            
            if(val_9 >= 16384)
            {
                    return (int)val_11;
            }
            
            val_11 = 3;
            return (int)val_11;
            label_2:
            int val_10 = this.bufPos;
            val_11 = 0;
            val_10 = val_10 - 1;
            matchPos = val_10;
            return (int)val_11;
            label_14:
            int val_11 = this.bufPos;
            val_11 = val_11 + (~val_10);
            matchPos = val_11;
            return (int)val_11;
        }
        private void VerifyHashes()
        {
            System.UInt16[] val_2;
            var val_5 = 0;
            label_7:
            val_2 = this.lookup;
            ushort val_2 = val_2[val_5];
            label_6:
            ushort val_1 = val_2 & 65535;
            if(val_1 == 0)
            {
                goto label_3;
            }
            
            val_2 = this.bufPos - val_2;
            if(val_2 >= 8192)
            {
                goto label_3;
            }
            
            val_2 = this.prev;
            val_1 = val_1 & 8191;
            int val_4 = this.bufPos;
            val_4 = val_4 - val_2[val_1];
            if(val_4 < 8192)
            {
                goto label_6;
            }
            
            label_3:
            val_5 = val_5 + 1;
            if(val_5 != 2048)
            {
                goto label_7;
            }
        
        }
        private uint RecalculateHash(int position)
        {
            byte val_3 = (this.window[(long)position + 1]) << 4;
            val_3 = val_3 ^ (this.window[(long)position] << 8);
            val_3 = val_3 & 2032;
            return (uint)val_3 ^ (this.window[(long)position + 2]);
        }
    
    }

}
