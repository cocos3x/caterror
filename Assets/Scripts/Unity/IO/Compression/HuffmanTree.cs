using UnityEngine;

namespace Unity.IO.Compression
{
    internal class HuffmanTree
    {
        // Fields
        internal const int MaxLiteralTreeElements = 288;
        internal const int MaxDistTreeElements = 32;
        internal const int EndOfBlockCode = 256;
        internal const int NumberOfCodeLengthTreeElements = 19;
        private int tableBits;
        private short[] table;
        private short[] left;
        private short[] right;
        private byte[] codeLengthArray;
        private int tableMask;
        private static Unity.IO.Compression.HuffmanTree staticLiteralLengthTree;
        private static Unity.IO.Compression.HuffmanTree staticDistanceTree;
        
        // Properties
        public static Unity.IO.Compression.HuffmanTree StaticLiteralLengthTree { get; }
        public static Unity.IO.Compression.HuffmanTree StaticDistanceTree { get; }
        
        // Methods
        private static HuffmanTree()
        {
            Unity.IO.Compression.HuffmanTree.staticLiteralLengthTree = new Unity.IO.Compression.HuffmanTree(codeLengths:  Unity.IO.Compression.HuffmanTree.GetStaticLiteralTreeLength());
            Unity.IO.Compression.HuffmanTree.staticDistanceTree = new Unity.IO.Compression.HuffmanTree(codeLengths:  Unity.IO.Compression.HuffmanTree.GetStaticDistanceTreeLength());
        }
        public static Unity.IO.Compression.HuffmanTree get_StaticLiteralLengthTree()
        {
            null = null;
            return (Unity.IO.Compression.HuffmanTree)Unity.IO.Compression.HuffmanTree.staticLiteralLengthTree;
        }
        public static Unity.IO.Compression.HuffmanTree get_StaticDistanceTree()
        {
            null = null;
            return (Unity.IO.Compression.HuffmanTree)Unity.IO.Compression.HuffmanTree.staticDistanceTree;
        }
        public HuffmanTree(byte[] codeLengths)
        {
            this.codeLengthArray = codeLengths;
            int val_1 = (codeLengths.Length == 288) ? 9 : 7;
            this.tableBits = val_1;
            val_1 = 1 << val_1;
            val_1 = val_1 - 1;
            this.tableMask = val_1;
            this.CreateTable();
        }
        private static byte[] GetStaticLiteralTreeLength()
        {
            byte[] val_1 = new byte[288];
            var val_5 = 0;
            do
            {
                mem2[0] = 8;
                val_5 = val_5 + 1;
            }
            while(val_5 != 144);
            
            var val_6 = 0;
            do
            {
                var val_2 = val_6 + 144;
                mem2[0] = 9;
                val_6 = val_6 + 1;
            }
            while(val_6 != 112);
            
            var val_7 = 0;
            do
            {
                var val_3 = val_7 + 256;
                mem2[0] = 7;
                val_7 = val_7 + 1;
            }
            while(val_7 != 24);
            
            var val_8 = 0;
            do
            {
                var val_4 = val_8 + 280;
                mem2[0] = 8;
                val_8 = val_8 + 1;
            }
            while(val_8 != 8);
            
            return (System.Byte[])val_1;
        }
        private static byte[] GetStaticDistanceTreeLength()
        {
            byte[] val_1 = new byte[32];
            var val_2 = 0;
            do
            {
                mem2[0] = 5;
                val_2 = val_2 + 1;
            }
            while(val_2 != 32);
            
            return (System.Byte[])val_1;
        }
        private uint[] CalculateHuffmanCode()
        {
            var val_7;
            byte val_8;
            var val_9;
            uint[] val_1 = new uint[17];
            val_7 = 0;
            goto label_1;
            label_6:
            byte val_8 = this.codeLengthArray[0];
            uint val_9 = val_1[(this.codeLengthArray[0x0][0]) << 2];
            val_7 = 1;
            val_9 = val_9 + 1;
            val_1[(this.codeLengthArray[0x0][0]) << 2] = val_9;
            label_1:
            if(val_7 < this.codeLengthArray.Length)
            {
                goto label_6;
            }
            
            val_1[0] = 0;
            uint[] val_2 = new uint[17];
            var val_11 = 0;
            uint val_10 = 0;
            do
            {
                var val_3 = val_11 + 1;
                val_10 = val_1[0] + val_10;
                val_10 = val_10 << 1;
                mem2[0] = val_10;
                val_11 = val_11 + 1;
            }
            while(val_11 != 16);
            
            uint[] val_4 = new uint[288];
            val_9 = 0;
            goto label_13;
            label_27:
            val_8 = this.codeLengthArray[0];
            if(val_8 != 0)
            {
                    uint val_12 = val_2[(this.codeLengthArray[0x0][0]) << 2];
                var val_13 = 0;
                byte val_5 = val_8 + 1;
                do
            {
                uint val_6 = val_12 & 1;
                val_5 = val_5 - 1;
                val_6 = val_6 | val_13;
                val_13 = val_6 << 1;
                val_12 = val_12 >> 1;
            }
            while(val_5 > 1);
            
                val_4[0] = val_6 & 2147483647;
                var val_14 = val_2[(this.codeLengthArray[0x0][0]) << 2] + 32;
                val_14 = val_14 + 1;
                mem2[0] = val_14;
            }
            
            val_9 = 1;
            label_13:
            if(val_9 < this.codeLengthArray.Length)
            {
                goto label_27;
            }
            
            return (System.UInt32[])val_4;
        }
        private void CreateTable()
        {
            Unity.IO.Compression.HuffmanTree val_16;
            System.UInt32[] val_17;
            int val_18;
            short val_19;
            var val_20;
            short val_21;
            val_16 = this;
            int val_14 = this.tableBits;
            val_17 = this.CalculateHuffmanCode();
            val_14 = val_14 & 31;
            int val_2 = 1 << val_14;
            this.table = new short[0];
            this.left = new short[0];
            this.right = new short[0];
            val_18 = this.codeLengthArray.Length;
            val_19 = 0;
            goto label_4;
            label_26:
            long val_18 = 0;
            byte val_15 = this.codeLengthArray[val_18];
            if(val_15 == 0)
            {
                goto label_21;
            }
            
            int val_17 = this.tableBits;
            uint val_16 = val_17[0];
            val_20 = val_17 - val_15;
            if(val_19 >= val_1.Length)
            {
                goto label_10;
            }
            
            val_17 = val_17 & 31;
            int val_6 = 1 << val_17;
            val_17 = val_6 - 1;
            label_16:
            val_21 = this.table[(long)val_17 & val_16];
            if(val_21 == 0)
            {
                    val_21 = 0 - val_18;
                val_18 = ((int)val_18 & 65535) + 1;
                mem2[0] = val_21;
            }
            
            if(((int)val_21 & 65535) >= 1)
            {
                goto label_20;
            }
            
            int val_8 = 0 - val_21;
            val_20 = val_20 + 1;
            val_6 = val_6 << 1;
            if(val_20 != 0)
            {
                goto label_16;
            }
            
            val_16 = val_16;
            var val_10 = (((val_6 & val_16) != 0) ? (this.left) : -1038083736) + (((0 - (0 - this.codeLengthArray.Length))) << 1);
            mem2[0] = val_19;
            goto label_19;
            label_10:
            val_18 = 1 << (val_15 & 31);
            if(val_16 >= val_18)
            {
                goto label_20;
            }
            
            int val_12 = val_20 & 31;
            if(val_12 == 31)
            {
                goto label_21;
            }
            
            var val_19 = 0;
            val_20 = 1 << val_12;
            do
            {
                val_19 = val_19 + 1;
                val_16 = val_16 + val_18;
                this.table[(long)val_16] = val_19;
            }
            while(val_19 < val_20);
            
            label_19:
            val_17 = val_17;
            label_21:
            val_19 = 1;
            label_4:
            if(val_19 < this.codeLengthArray.Length)
            {
                goto label_26;
            }
            
            return;
            label_20:
            Unity.IO.Compression.InvalidDataException val_13 = new Unity.IO.Compression.InvalidDataException(message:  "Invalid Huffman data");
        }
        public int GetNextSymbol(Unity.IO.Compression.InputBuffer input)
        {
            var val_7;
            var val_8;
            short val_9;
            System.Int16[] val_10;
            if(input != null)
            {
                    val_7 = input.TryLoad16Bits();
            }
            else
            {
                    val_7 = 0.TryLoad16Bits();
            }
            
            if(input.bitsInBuffer == 0)
            {
                goto label_3;
            }
            
            val_8 = this.tableMask & val_7;
            val_9 = this.table[val_8];
            if((val_9 & 2147483648) == 0)
            {
                goto label_6;
            }
            
            int val_6 = this.tableBits;
            var val_7 = 1;
            val_6 = val_6 & 31;
            int val_3 = val_7 << val_6;
            goto label_13;
            label_10:
            val_10 = this.left;
            if(val_10 != null)
            {
                goto label_11;
            }
            
            goto label_9;
            label_13:
            val_7 = val_3 & val_7;
            val_9 = 0 - (val_9 << );
            if(val_7 == 0)
            {
                goto label_10;
            }
            
            val_10 = this.right;
            if(val_10 != null)
            {
                goto label_11;
            }
            
            label_9:
            label_11:
            val_9 = val_10[val_9];
            val_8 = val_3 << 1;
            if((val_9 & 2147483648) != 0)
            {
                goto label_13;
            }
            
            label_6:
            val_7 = (long)val_9;
            byte val_8 = this.codeLengthArray[val_7];
            if(val_8 == 0)
            {
                goto label_16;
            }
            
            int val_9 = input.bitsInBuffer;
            val_9 = val_9 - val_8;
            if(val_9 >= this.codeLengthArray.Length)
            {
                goto label_18;
            }
            
            label_3:
            val_9 = 0;
            return (int)val_9;
            label_18:
            uint val_10 = input.bitBuffer;
            val_10 = val_10 >> (val_8 & 31);
            input.bitBuffer = val_10;
            input.bitsInBuffer = val_9;
            return (int)val_9;
            label_16:
            Unity.IO.Compression.InvalidDataException val_5 = new Unity.IO.Compression.InvalidDataException(message:  "Invalid Huffman data");
        }
    
    }

}
