using UnityEngine;

namespace Unity.IO.Compression
{
    internal class GZipFormatter : IFileFormatWriter
    {
        // Fields
        private byte[] headerBytes;
        private uint _crc32;
        private long _inputStreamSizeModulo;
        
        // Methods
        internal GZipFormatter()
        {
        
        }
        internal GZipFormatter(int compressionLevel)
        {
            this.headerBytes = new byte[10] {31, 139, 8, 0, 0, 0, 0, 0, 4, 0};
            if(compressionLevel != 10)
            {
                    return;
            }
            
            this = this.headerBytes;
            this[1] = 2;
        }
        public byte[] GetHeader()
        {
            return (System.Byte[])this.headerBytes;
        }
        public void UpdateWithBytesRead(byte[] buffer, int offset, int bytesToCopy)
        {
            long val_3 = this._inputStreamSizeModulo;
            var val_4 = 0;
            this._crc32 = Unity.IO.Compression.Crc32Helper.UpdateCrc32(crc32:  this._crc32, buffer:  buffer, offset:  offset, length:  bytesToCopy);
            val_3 = val_3 + bytesToCopy;
            val_4 = val_3 + val_4;
            var val_2 = (val_3 < 0) ? (val_4) : (val_3);
            val_2 = val_2 & (-4294967296);
            val_2 = val_3 - val_2;
            val_3 = (val_3 < 4294967296) ? (val_3) : (val_2);
            this._inputStreamSizeModulo = val_3;
        }
        public byte[] GetFooter()
        {
            byte[] val_1 = new byte[8];
            val_1.WriteUInt32(b:  val_1, value:  this._crc32, startIndex:  0);
            val_1.WriteUInt32(b:  val_1, value:  this._inputStreamSizeModulo, startIndex:  4);
            return (System.Byte[])val_1;
        }
        internal void WriteUInt32(byte[] b, uint value, int startIndex)
        {
            b[(long)startIndex] = value;
            b[(long)startIndex + 1] = value >> 8;
            b[(long)startIndex + 2] = value >> 16;
            b[(long)startIndex + 3] = value >> 24;
        }
    
    }

}
