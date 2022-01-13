using UnityEngine;

namespace Unity.IO.Compression
{
    internal class Inflater
    {
        // Fields
        private static readonly byte[] extraLengthBits;
        private static readonly int[] lengthBase;
        private static readonly int[] distanceBasePosition;
        private static readonly byte[] codeOrder;
        private static readonly byte[] staticDistanceTreeTable;
        private Unity.IO.Compression.OutputWindow output;
        private Unity.IO.Compression.InputBuffer input;
        private Unity.IO.Compression.HuffmanTree literalLengthTree;
        private Unity.IO.Compression.HuffmanTree distanceTree;
        private Unity.IO.Compression.InflaterState state;
        private bool hasFormatReader;
        private int bfinal;
        private Unity.IO.Compression.BlockType blockType;
        private byte[] blockLengthBuffer;
        private int blockLength;
        private int length;
        private int distanceCode;
        private int extraBits;
        private int loopCounter;
        private int literalLengthCodeCount;
        private int distanceCodeCount;
        private int codeLengthCodeCount;
        private int codeArraySize;
        private int lengthCode;
        private byte[] codeList;
        private byte[] codeLengthTreeCodeLength;
        private Unity.IO.Compression.HuffmanTree codeLengthTree;
        private Unity.IO.Compression.IFileFormatReader formatReader;
        
        // Properties
        public int AvailableOutput { get; }
        
        // Methods
        public Inflater()
        {
            this.blockLengthBuffer = new byte[4];
            this.output = new Unity.IO.Compression.OutputWindow();
            this.input = new Unity.IO.Compression.InputBuffer();
            this.codeList = new byte[320];
            this.codeLengthTreeCodeLength = new byte[19];
            this.state = (this.hasFormatReader == true) ? 0 : 2;
        }
        internal void SetFileFormatReader(Unity.IO.Compression.IFileFormatReader reader)
        {
            this.formatReader = reader;
            this.hasFormatReader = true;
            this.state = 0;
        }
        private void Reset()
        {
            this.state = (this.hasFormatReader == true) ? 0 : 2;
        }
        public void SetInput(byte[] inputBytes, int offset, int length)
        {
            this.input.buffer = inputBytes;
            this.input.start = offset;
            this.input.end = length + offset;
        }
        public bool Finished()
        {
            Unity.IO.Compression.InflaterState val_2 = this.state;
            val_2 = val_2 - 23;
            return (bool)(val_2 < 2) ? 1 : 0;
        }
        public int get_AvailableOutput()
        {
            if(this.output != null)
            {
                    return (int)this.output.bytesUsed;
            }
            
            return (int)this.output.bytesUsed;
        }
        public bool NeedsInput()
        {
            return (bool)(this.input.start == this.input.end) ? 1 : 0;
        }
        public int Inflate(byte[] bytes, int offset, int length)
        {
            int val_6;
            var val_7;
            Unity.IO.Compression.InflaterState val_9;
            val_6 = length;
            int val_7 = offset;
            val_7 = 0;
            label_11:
            int val_1 = this.output.CopyTo(output:  bytes, offset:  val_7, length:  val_6);
            if(val_1 >= 1)
            {
                    if(this.hasFormatReader != false)
            {
                    var val_6 = 0;
                val_6 = val_6 + 1;
                this.formatReader.UpdateWithBytesRead(buffer:  bytes, offset:  val_7, bytesToCopy:  val_1);
            }
            
                val_7 = val_1 + val_7;
                val_7 = val_1 + val_7;
                val_6 = val_6 - val_1;
            }
            
            if(val_6 == 0)
            {
                goto label_9;
            }
            
            val_9 = this.state;
            if((val_9 - 23) < 2)
            {
                goto label_10;
            }
            
            if(this.Decode() == true)
            {
                goto label_11;
            }
            
            label_9:
            val_9 = this.state;
            label_10:
            if(val_9 != 23)
            {
                    return (int)val_7;
            }
            
            val_6 = this.output;
            if(this.output.bytesUsed != 0)
            {
                    return (int)val_7;
            }
            
            var val_8 = 0;
            val_8 = val_8 + 1;
            this.formatReader.Validate();
            return (int)val_7;
        }
        private bool Decode()
        {
            Unity.IO.Compression.InflaterState val_18;
            bool val_19;
            Unity.IO.Compression.InputBuffer val_20;
            Unity.IO.Compression.InputBuffer val_21;
            int val_23;
            var val_25;
            Unity.IO.Compression.InflaterState val_26;
            bool val_13 = false;
            val_18 = this.state;
            if((val_18 - 23) < 2)
            {
                goto label_1;
            }
            
            val_19 = this.hasFormatReader;
            if(val_19 == false)
            {
                goto label_2;
            }
            
            if(val_18 > 20)
            {
                goto label_3;
            }
            
            if(val_18 == 0)
            {
                goto label_4;
            }
            
            label_2:
            if(val_18 == 2)
            {
                goto label_5;
            }
            
            if(val_18 != 3)
            {
                goto label_8;
            }
            
            val_20 = this.input;
            goto label_7;
            label_3:
            if((val_18 - 21) >= 2)
            {
                goto label_8;
            }
            
            val_21 = this.input;
            var val_20 = 0;
            val_20 = val_20 + 1;
            goto label_13;
            label_5:
            val_20 = this.input;
            label_51:
            if((mem[this.input].EnsureBitsAvailable(count:  1)) == false)
            {
                goto label_50;
            }
            
            if((mem[this.input].EnsureBitsAvailable(count:  1)) == false)
            {
                goto label_17;
            }
            
            val_19 = (mem[this.input] + 32 + 4) - 1;
            val_23 = (mem[this.input] + 32) & 1;
            mem2[0] = (mem[this.input] + 32) >> 1;
            mem2[0] = val_19;
            goto label_18;
            label_8:
            val_21 = this.blockType;
            goto label_19;
            label_4:
            val_21 = this.formatReader;
            var val_21 = 0;
            val_21 = val_21 + 1;
            goto label_24;
            label_17:
            val_23 = 0;
            label_18:
            this.bfinal = val_23;
            this.state = 3;
            label_7:
            if((mem[this.input].EnsureBitsAvailable(count:  2)) == false)
            {
                goto label_26;
            }
            
            if((mem[this.input].EnsureBitsAvailable(count:  2)) == false)
            {
                goto label_28;
            }
            
            Unity.IO.Compression.BlockType val_23 = mem[this.input] + 32;
            var val_22 = mem[this.input] + 32 + 4;
            val_21 = this;
            val_22 = val_22 - 2;
            val_23 = val_23 & 3;
            mem2[0] = val_23 >> 2;
            mem2[0] = val_22;
            this.blockType = val_23;
            if(val_23 == 0)
            {
                goto label_29;
            }
            
            if(val_23 == 1)
            {
                goto label_30;
            }
            
            if(val_23 != 2)
            {
                goto label_41;
            }
            
            val_18 = 4;
            goto label_36;
            label_26:
            val_25 = 0;
            val_26 = 3;
            goto label_48;
            label_13:
            if((this.formatReader.ReadFooter(input:  val_21)) == false)
            {
                goto label_50;
            }
            
            this.state = 23;
            label_1:
            val_25 = 1;
            goto label_49;
            label_29:
            val_18 = 15;
            goto label_36;
            label_30:
            this.literalLengthTree = Unity.IO.Compression.HuffmanTree.StaticLiteralLengthTree;
            val_18 = 10;
            this.distanceTree = Unity.IO.Compression.HuffmanTree.StaticDistanceTree;
            label_36:
            this.state = 10;
            label_19:
            if(this.blockType == 0)
            {
                goto label_39;
            }
            
            if(this.blockType == 1)
            {
                goto label_40;
            }
            
            if(this.blockType != 2)
            {
                goto label_41;
            }
            
            if(10 <= 9)
            {
                goto label_42;
            }
            
            label_40:
            val_25 = this;
            bool val_14 = this.DecodeBlock(end_of_block_code_seen: out  val_13);
            goto label_44;
            label_39:
            val_25 = this;
            bool val_15 = this.DecodeUncompressedBlock(end_of_block: out  val_13);
            goto label_44;
            label_42:
            val_25 = this;
            bool val_16 = this.DecodeDynamicBlockHeader();
            label_44:
            if((val_13 == 0) || (this.bfinal == 0))
            {
                goto label_49;
            }
            
            if(this.hasFormatReader != false)
            {
                    val_26 = 21;
            }
            else
            {
                    val_26 = 24;
            }
            
            label_48:
            this.state = val_26;
            goto label_49;
            label_24:
            if((val_21.ReadHeader(input:  this.input)) == false)
            {
                goto label_50;
            }
            
            this.state = 2;
            goto label_51;
            label_50:
            val_25 = 0;
            label_49:
            val_25 = val_25 & 1;
            return (bool)val_25;
            label_28:
            this.blockType = 0;
            label_41:
            Unity.IO.Compression.InvalidDataException val_19 = new Unity.IO.Compression.InvalidDataException(message:  "Unknown block type");
        }
        private bool DecodeUncompressedBlock(out bool end_of_block)
        {
            Unity.IO.Compression.OutputWindow val_11;
            Unity.IO.Compression.InflaterState val_12;
            Unity.IO.Compression.InputBuffer val_13;
            Unity.IO.Compression.InflaterState val_14;
            bool val_15;
            string val_16;
            val_11 = 1152921512161084752;
            end_of_block = false;
            val_12 = this.state;
            goto label_1;
            label_19:
            if(val_12 != 15)
            {
                goto label_2;
            }
            
            int val_11 = this.input.bitsInBuffer;
            int val_2 = (val_11 < 0) ? (val_11 + 7) : (val_11);
            val_2 = val_2 & 4294967288;
            val_11 = val_11 - val_2;
            val_11 = val_11 & 31;
            val_11 = this.input.bitBuffer >> val_11;
            this.input.bitBuffer = val_11;
            this.input.bitsInBuffer = val_2;
            this.state = 16;
            label_18:
            val_13 = this.input;
            if((val_13.EnsureBitsAvailable(count:  8)) == false)
            {
                goto label_5;
            }
            
            int val_12 = this.input.bitsInBuffer;
            val_12 = val_12 - 8;
            this.input.bitBuffer = this.input.bitBuffer >> 8;
            this.input.bitsInBuffer = val_12;
            this.blockLengthBuffer[(long)this.state - 16] = this.input.bitBuffer;
            val_14 = this.state;
            if(val_14 != 19)
            {
                goto label_8;
            }
            
            byte val_14 = this.blockLengthBuffer[0];
            this.blockLength = this.blockLengthBuffer[0];
            byte val_16 = this.blockLengthBuffer[0];
            if(this.blockLength != this.blockLengthBuffer[0] ^ 65535)
            {
                goto label_17;
            }
            
            val_14 = this.state;
            label_8:
            val_12 = val_14 + 1;
            this.state = val_12;
            label_1:
            if((val_12 - 16) < 4)
            {
                goto label_18;
            }
            
            if(val_12 != 20)
            {
                goto label_19;
            }
            
            val_13 = this.output;
            int val_17 = this.blockLength;
            val_17 = val_17 - (val_13.CopyFrom(input:  this.input, length:  this.blockLength));
            this.blockLength = val_17;
            if(val_17 != 0)
            {
                    val_11 = this.output;
                var val_9 = (this.output.bytesUsed == 32768) ? 1 : 0;
                return (bool)val_15;
            }
            
            val_15 = true;
            this.state = 2;
            end_of_block = val_15;
            return (bool)val_15;
            label_5:
            val_15 = 0;
            return (bool)val_15;
            label_2:
            val_16 = "Unknown state";
            goto label_25;
            label_17:
            val_16 = "Invalid block length";
            label_25:
            Unity.IO.Compression.InvalidDataException val_10 = new Unity.IO.Compression.InvalidDataException(message:  val_16);
        }
        private bool DecodeBlock(out bool end_of_block_code_seen)
        {
            Unity.IO.Compression.OutputWindow val_19;
            bool val_31;
            string val_32;
            end_of_block_code_seen = false;
            val_19 = this.output;
            if((32768 - this.output.bytesUsed) < 259)
            {
                goto label_2;
            }
            
            Unity.IO.Compression.InflaterState val_15 = this.state;
            val_15 = val_15 - 10;
            if(val_15 > 3)
            {
                goto label_3;
            }
            
            var val_16 = 27001916 + ((this.state - 10)) << 2;
            val_16 = val_16 + 27001916;
            goto (27001916 + ((this.state - 10)) << 2 + 27001916);
            label_2:
            val_31 = 1;
            return (bool);
            label_3:
            val_32 = "Unknown state";
            Unity.IO.Compression.InvalidDataException val_14 = new Unity.IO.Compression.InvalidDataException(message:  null);
        }
        private bool DecodeDynamicBlockHeader()
        {
            Unity.IO.Compression.InputBuffer val_36;
            int val_40;
            var val_41;
            var val_43;
            var val_44;
            var val_46;
            var val_47;
            int val_48;
            var val_49;
            var val_50;
            var val_51;
            int val_52;
            var val_53;
            int val_54;
            var val_55;
            int val_56;
            var val_57;
            var val_58;
            var val_59;
            if((this.state - 4) > 5)
            {
                goto label_1;
            }
            
            var val_36 = 27001892 + ((this.state - 4)) << 2;
            val_36 = val_36 + 27001892;
            goto (27001892 + ((this.state - 4)) << 2 + 27001892);
            label_20:
            if((this.input.EnsureBitsAvailable(count:  3)) == false)
            {
                goto label_40;
            }
            
            uint val_44 = this.input.bitBuffer;
            int val_43 = this.input.bitsInBuffer;
            val_43 = val_43 - 3;
            this.input.bitBuffer = val_44 >> 3;
            this.input.bitsInBuffer = val_43;
            val_43 = null;
            val_43 = null;
            val_44 = val_44 & 7;
            var val_10 = mem[this.codeLengthTreeCodeLength] + (Unity.IO.Compression.Inflater.codeOrder.Length + 32);
            mem2[0] = val_44;
            this.loopCounter = 1;
            val_40 = ;
            if(1 < val_40)
            {
                goto label_20;
            }
            
            goto label_25;
            label_35:
            val_46 = null;
            val_46 = null;
            System.Byte[] val_11 = Unity.IO.Compression.Inflater.codeOrder + (long);
            val_41 = mem[(Unity.IO.Compression.Inflater.codeOrder + (long)(int)(((mem[this.input] + 32 & 15) + 4))) + 32];
            val_41 = (Unity.IO.Compression.Inflater.codeOrder + (long)(int)(((mem[this.input] + 32 & 15) + 4))) + 32;
            var val_12 = mem[this.input] + val_41;
            val_40 =  + 1;
            mem2[0] = 0;
            label_25:
            val_47 = null;
            val_47 = null;
            if(val_40 < Unity.IO.Compression.Inflater.codeOrder.Length)
            {
                goto label_35;
            }
            
            Unity.IO.Compression.HuffmanTree val_13 = null;
            val_36 = val_13;
            val_13 = new Unity.IO.Compression.HuffmanTree(codeLengths:  mem[this.codeLengthTreeCodeLength]);
            int val_45 = this.literalLengthCodeCount;
            this.codeLengthTree = val_36;
            val_45 = this.distanceCodeCount + val_45;
            this.codeArraySize = val_45;
            this.loopCounter = 0;
            this.state = 8;
            if(this.loopCounter >= this.codeArraySize)
            {
                goto label_36;
            }
            
            label_77:
            if(8 != 8)
            {
                goto label_37;
            }
            
            val_36 = this.input;
            val_48 = this.codeLengthTree.GetNextSymbol(input:  val_36);
            this.lengthCode = val_48;
            if((val_48 & 2147483648) == 0)
            {
                goto label_39;
            }
            
            goto label_40;
            label_37:
            val_48 = this.lengthCode;
            label_39:
            if(val_48 <= 15)
            {
                goto label_41;
            }
            
            if((this.input.EnsureBitsAvailable(count:  7)) == false)
            {
                goto label_43;
            }
            
            if(this.lengthCode != 16)
            {
                goto label_44;
            }
            
            if(this.loopCounter == 0)
            {
                goto label_80;
            }
            
            if((this.input.EnsureBitsAvailable(count:  2)) == false)
            {
                goto label_49;
            }
            
            int val_47 = this.input.bitsInBuffer;
            val_47 = val_47 - 2;
            val_49 = this.input.bitBuffer & 3;
            this.input.bitBuffer = this.input.bitBuffer >> 2;
            this.input.bitsInBuffer = val_47;
            goto label_50;
            label_41:
            this.loopCounter = this.loopCounter + 1;
            this.codeList[this.loopCounter] = val_48;
            goto label_71;
            label_44:
            if(this.lengthCode != 17)
            {
                goto label_55;
            }
            
            if((this.input.EnsureBitsAvailable(count:  3)) == false)
            {
                goto label_56;
            }
            
            int val_48 = this.input.bitsInBuffer;
            val_48 = val_48 - 3;
            val_50 = this.input.bitBuffer & 7;
            this.input.bitBuffer = this.input.bitBuffer >> 3;
            this.input.bitsInBuffer = val_48;
            goto label_57;
            label_55:
            if((this.input.EnsureBitsAvailable(count:  7)) == false)
            {
                goto label_58;
            }
            
            int val_49 = this.input.bitsInBuffer;
            val_49 = val_49 - 7;
            val_51 = this.input.bitBuffer & 127;
            this.input.bitBuffer = this.input.bitBuffer >> 7;
            this.input.bitsInBuffer = val_49;
            goto label_59;
            label_49:
            val_49 = 0;
            label_50:
            val_52 = this.loopCounter;
            var val_24 = val_49 + 3;
            val_49 = val_24 + val_52;
            if(val_49 > this.codeArraySize)
            {
                goto label_80;
            }
            
            val_53 = 1;
            goto label_61;
            label_64:
            val_52 = this.loopCounter;
            val_53 = 2;
            label_61:
            this.loopCounter = val_52 + 1;
            this.codeList[(long)val_52] = this.codeList[(long)this.loopCounter - 1];
            if(val_53 < val_24)
            {
                goto label_64;
            }
            
            goto label_71;
            label_56:
            val_50 = 0;
            label_57:
            val_54 = this.loopCounter;
            var val_26 = val_50 + 3;
            val_50 = val_26 + val_54;
            if(val_50 > this.codeArraySize)
            {
                goto label_80;
            }
            
            val_55 = 1;
            goto label_67;
            label_70:
            val_54 = this.loopCounter;
            val_55 = 2;
            label_67:
            this.loopCounter = val_54 + 1;
            this.codeList[(long)val_54] = 0;
            if(val_55 < val_26)
            {
                goto label_70;
            }
            
            goto label_71;
            label_58:
            val_51 = 0;
            label_59:
            val_56 = this.loopCounter;
            var val_28 = val_51 + 11;
            val_51 = val_28 + val_56;
            if(val_51 > this.codeArraySize)
            {
                goto label_80;
            }
            
            val_57 = 1;
            goto label_73;
            label_76:
            val_56 = this.loopCounter;
            val_57 = 2;
            label_73:
            this.loopCounter = val_56 + 1;
            this.codeList[(long)val_56] = 0;
            if(val_57 < val_28)
            {
                goto label_76;
            }
            
            label_71:
            this.state = 8;
            if(this.loopCounter < this.codeArraySize)
            {
                goto label_77;
            }
            
            label_36:
            byte[] val_30 = new byte[288];
            byte[] val_31 = new byte[32];
            System.Array.Copy(sourceArray:  this.codeList, destinationArray:  val_30, length:  this.literalLengthCodeCount);
            System.Array.Copy(sourceArray:  this.codeList, sourceIndex:  this.literalLengthCodeCount, destinationArray:  val_31, destinationIndex:  0, length:  this.distanceCodeCount);
            if(val_30[32] == 0)
            {
                goto label_80;
            }
            
            val_40 = 1152921504969039872;
            this.literalLengthTree = new Unity.IO.Compression.HuffmanTree(codeLengths:  val_30);
            Unity.IO.Compression.HuffmanTree val_33 = null;
            val_36 = val_33;
            val_33 = new Unity.IO.Compression.HuffmanTree(codeLengths:  val_31);
            this.distanceTree = val_36;
            this.state = 10;
            val_44 = 1;
            return (bool)val_44;
            label_40:
            val_44 = 0;
            return (bool)val_44;
            label_43:
            val_44 = 0;
            this.state = 9;
            return (bool)val_44;
            label_80:
            val_58 = 1152921512161915648;
            val_59 = new Unity.IO.Compression.InvalidDataException();
            goto label_83;
            label_1:
            val_58 = 1152921512161915648;
            val_59 = new Unity.IO.Compression.InvalidDataException(message:  "Unknown state");
            label_83:
        }
        private static Inflater()
        {
            Unity.IO.Compression.Inflater.extraLengthBits = new byte[29] {0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 2, 2, 2, 2, 3, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5, 0};
            Unity.IO.Compression.Inflater.lengthBase = new int[29] {3, 4, 5, 6, 7, 8, 9, 10, 11, 13, 15, 17, 19, 23, 27, 31, 35, 43, 51, 59, 67, 83, 99, 115, 131, 163, 195, 227, 258};
            Unity.IO.Compression.Inflater.distanceBasePosition = new int[32] {1, 2, 3, 4, 5, 7, 9, 13, 17, 25, 33, 49, 65, 97, 129, 193, 257, 385, 513, 769, 1025, 1537, 2049, 3073, 4097, 6145, 8193, 12289, 16385, 24577, 0, 0};
            Unity.IO.Compression.Inflater.codeOrder = new byte[19] {16, 17, 18, 0, 8, 7, 9, 6, 10, 5, 11, 4, 12, 3, 13, 2, 14, 1, 15};
            Unity.IO.Compression.Inflater.staticDistanceTreeTable = new byte[32] {0, 16, 8, 24, 4, 20, 12, 28, 2, 18, 10, 26, 6, 22, 14, 30, 1, 17, 9, 25, 5, 21, 13, 29, 3, 19, 11, 27, 7, 23, 15, 31};
        }
    
    }

}
