using UnityEngine;

namespace Unity.IO.Compression
{
    internal class GZipDecoder : IFileFormatReader
    {
        // Fields
        private Unity.IO.Compression.GZipDecoder.GzipHeaderState gzipHeaderSubstate;
        private Unity.IO.Compression.GZipDecoder.GzipHeaderState gzipFooterSubstate;
        private int gzip_header_flag;
        private int gzip_header_xlen;
        private uint expectedCrc32;
        private uint expectedOutputStreamSizeModulo;
        private int loopCounter;
        private uint actualCrc32;
        private long actualStreamSizeModulo;
        
        // Methods
        public GZipDecoder()
        {
            this.gzipHeaderSubstate = 64424509440;
            this.expectedCrc32 = 0;
            this.expectedOutputStreamSizeModulo = 0;
        }
        public void Reset()
        {
            this.gzipHeaderSubstate = 64424509440;
            this.expectedCrc32 = 0;
            this.expectedOutputStreamSizeModulo = 0;
        }
        public bool ReadHeader(Unity.IO.Compression.InputBuffer input)
        {
            GzipHeaderState val_24;
            int val_25;
            int val_26;
            var val_27;
            if(this.gzipHeaderSubstate > 14)
            {
                goto label_1;
            }
            
            var val_24 = 27001832 + (this.gzipHeaderSubstate) << 2;
            val_24 = val_24 + 27001832;
            goto (27001832 + (this.gzipHeaderSubstate) << 2 + 27001832);
            label_21:
            if((input.EnsureBitsAvailable(count:  8)) == false)
            {
                goto label_54;
            }
            
            uint val_33 = input.bitBuffer;
            int val_34 = input.bitsInBuffer;
            val_33 = val_33 >> 8;
            val_34 = val_34 - 8;
            input.bitBuffer = val_33;
            input.bitsInBuffer = val_34;
            this.loopCounter = 1;
            if(1 < 4)
            {
                goto label_21;
            }
            
            this.gzipHeaderSubstate = 5;
            this.loopCounter = 0;
            if((input.EnsureBitsAvailable(count:  8)) == false)
            {
                goto label_54;
            }
            
            uint val_35 = input.bitBuffer;
            int val_36 = input.bitsInBuffer;
            val_35 = val_35 >> 8;
            val_36 = val_36 - 8;
            input.bitBuffer = val_35;
            input.bitsInBuffer = val_36;
            this.gzipHeaderSubstate = 6;
            if((input.EnsureBitsAvailable(count:  8)) == false)
            {
                goto label_54;
            }
            
            uint val_37 = input.bitBuffer;
            val_37 = val_37 >> 8;
            val_25 = input.bitsInBuffer - 8;
            input.bitBuffer = val_37;
            input.bitsInBuffer = val_25;
            this.gzipHeaderSubstate = 7;
            if((this.gzip_header_flag & 4) == 0)
            {
                goto label_27;
            }
            
            val_24 = 8;
            if((input.EnsureBitsAvailable(count:  8)) == false)
            {
                goto label_54;
            }
            
            uint val_39 = input.bitBuffer;
            int val_38 = input.bitsInBuffer;
            val_38 = val_38 - 8;
            val_39 = val_39 & 255;
            input.bitBuffer = val_39 >> 8;
            input.bitsInBuffer = val_38;
            this.gzip_header_xlen = val_39;
            this.gzipHeaderSubstate = val_24;
            if((input.EnsureBitsAvailable(count:  8)) == false)
            {
                goto label_54;
            }
            
            int val_40 = input.bitsInBuffer;
            val_26 = 0;
            val_40 = val_40 - 8;
            input.bitBuffer = input.bitBuffer >> 8;
            input.bitsInBuffer = val_40;
            val_25 = this.gzip_header_xlen | input.bitBuffer;
            this.gzipHeaderSubstate = 9;
            this.gzip_header_xlen = val_25;
            this.loopCounter = 0;
            goto label_34;
            label_37:
            if((input.EnsureBitsAvailable(count:  8)) == false)
            {
                goto label_54;
            }
            
            uint val_41 = input.bitBuffer;
            int val_42 = input.bitsInBuffer;
            val_41 = val_41 >> 8;
            val_42 = val_42 - 8;
            input.bitBuffer = val_41;
            input.bitsInBuffer = val_42;
            val_26 = 1;
            this.loopCounter = val_26;
            val_25 = this.gzip_header_xlen;
            label_34:
            if(val_26 < val_25)
            {
                goto label_37;
            }
            
            this.gzipHeaderSubstate = 10;
            this.loopCounter = 0;
            label_27:
            val_24 = this;
            if((this.gzip_header_flag & 8) == 0)
            {
                goto label_38;
            }
            
            label_41:
            if((input.EnsureBitsAvailable(count:  8)) == false)
            {
                goto label_54;
            }
            
            uint val_43 = input.bitBuffer;
            val_25 = input.bitsInBuffer - 8;
            val_43 = val_43 & 255;
            input.bitBuffer = val_43 >> 8;
            input.bitsInBuffer = val_25;
            if(val_43 != 0)
            {
                goto label_41;
            }
            
            label_38:
            this.gzipHeaderSubstate = 11;
            if(( & 16) == 0)
            {
                goto label_43;
            }
            
            label_46:
            if((input.EnsureBitsAvailable(count:  8)) == false)
            {
                goto label_54;
            }
            
            uint val_44 = input.bitBuffer;
            val_25 = input.bitsInBuffer - 8;
            val_44 = val_44 & 255;
            input.bitBuffer = val_44 >> 8;
            input.bitsInBuffer = val_25;
            if(val_44 != 0)
            {
                goto label_46;
            }
            
            label_43:
            this.gzipHeaderSubstate = 12;
            if(( & 2) != 0)
            {
                goto label_48;
            }
            
            this.gzipHeaderSubstate = 14;
            goto label_49;
            label_48:
            if((input.EnsureBitsAvailable(count:  8)) == false)
            {
                goto label_54;
            }
            
            uint val_45 = input.bitBuffer;
            int val_46 = input.bitsInBuffer;
            val_45 = val_45 >> 8;
            val_46 = val_46 - 8;
            input.bitBuffer = val_45;
            input.bitsInBuffer = val_46;
            this.gzipHeaderSubstate = 13;
            if((input.EnsureBitsAvailable(count:  8)) == false)
            {
                goto label_54;
            }
            
            uint val_47 = input.bitBuffer;
            int val_48 = input.bitsInBuffer;
            val_47 = val_47 >> 8;
            val_48 = val_48 - 8;
            input.bitBuffer = val_47;
            input.bitsInBuffer = val_48;
            this.gzipHeaderSubstate = 14;
            label_49:
            val_27 = 1;
            return (bool)val_27;
            label_54:
            val_27 = 0;
            return (bool)val_27;
            label_1:
            label_57:
            Unity.IO.Compression.InvalidDataException val_23 = new Unity.IO.Compression.InvalidDataException(message:  "Unknown state");
            goto label_57;
        }
        public bool ReadFooter(Unity.IO.Compression.InputBuffer input)
        {
            uint val_7;
            var val_8;
            var val_9;
            val_7 = input.bitBuffer;
            int val_7 = input.bitsInBuffer;
            int val_2 = (val_7 < 0) ? (val_7 + 7) : (val_7);
            val_2 = val_2 & 4294967288;
            val_7 = val_7 - val_2;
            val_7 = val_7 & 31;
            val_7 = val_7 >> val_7;
            input.bitBuffer = val_7;
            input.bitsInBuffer = val_2;
            if(this.gzipFooterSubstate == 16)
            {
                goto label_1;
            }
            
            if(this.gzipFooterSubstate != 15)
            {
                goto label_9;
            }
            
            val_8 = this;
            if(this.loopCounter > 3)
            {
                goto label_3;
            }
            
            label_5:
            if((input.EnsureBitsAvailable(count:  8)) == false)
            {
                goto label_10;
            }
            
            uint val_9 = input.bitBuffer;
            int val_8 = input.bitsInBuffer;
            val_8 = val_8 - 8;
            input.bitBuffer = val_9 >> 8;
            input.bitsInBuffer = val_8;
            val_9 = val_9 & 255;
            val_7 = this.loopCounter + 1;
            val_9 = val_9 << W11;
            val_9 = val_9 | this.expectedCrc32;
            this.expectedCrc32 = val_9;
            this.loopCounter = val_7;
            if(val_7 < 4)
            {
                goto label_5;
            }
            
            label_3:
            this.gzipFooterSubstate = 16;
            this.loopCounter = 0;
            goto label_7;
            label_1:
            val_8 = this;
            if(this.loopCounter == 0)
            {
                goto label_7;
            }
            
            if(this.loopCounter <= 3)
            {
                goto label_11;
            }
            
            goto label_9;
            label_7:
            this.expectedOutputStreamSizeModulo = 0;
            label_11:
            if((input.EnsureBitsAvailable(count:  8)) == false)
            {
                goto label_10;
            }
            
            uint val_11 = input.bitBuffer;
            int val_10 = input.bitsInBuffer;
            val_10 = val_10 - 8;
            input.bitBuffer = val_11 >> 8;
            input.bitsInBuffer = val_10;
            val_11 = val_11 & 255;
            val_11 = val_11 << W11;
            val_11 = val_11 | this.expectedOutputStreamSizeModulo;
            this.expectedOutputStreamSizeModulo = val_11;
            this.loopCounter = 1;
            if(1 < 4)
            {
                goto label_11;
            }
            
            label_9:
            val_9 = 1;
            return (bool)val_9;
            label_10:
            val_9 = 0;
            return (bool)val_9;
        }
        public void UpdateWithBytesRead(byte[] buffer, int offset, int copied)
        {
            long val_3 = this.actualStreamSizeModulo;
            var val_4 = 0;
            this.actualCrc32 = Unity.IO.Compression.Crc32Helper.UpdateCrc32(crc32:  this.actualCrc32, buffer:  buffer, offset:  offset, length:  copied);
            val_3 = val_3 + copied;
            val_4 = val_3 + val_4;
            var val_2 = (val_3 < 0) ? (val_4) : (val_3);
            val_2 = val_2 & (-4294967296);
            val_2 = val_3 - val_2;
            val_3 = (val_3 < 4294967296) ? (val_3) : (val_2);
            this.actualStreamSizeModulo = val_3;
        }
        public void Validate()
        {
            string val_2;
            if(this.expectedCrc32 != this.actualCrc32)
            {
                goto label_1;
            }
            
            if(this.actualStreamSizeModulo != this.expectedOutputStreamSizeModulo)
            {
                goto label_2;
            }
            
            return;
            label_1:
            val_2 = "Invalid CRC";
            goto label_3;
            label_2:
            val_2 = "Invalid stream size";
            label_3:
            Unity.IO.Compression.InvalidDataException val_1 = new Unity.IO.Compression.InvalidDataException(message:  val_2);
        }
    
    }

}
