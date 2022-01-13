using UnityEngine;

namespace Unity.IO.Compression
{
    internal interface IFileFormatWriter
    {
        // Methods
        public abstract byte[] GetHeader(); // 0
        public abstract void UpdateWithBytesRead(byte[] buffer, int offset, int bytesToCopy); // 0
        public abstract byte[] GetFooter(); // 0
    
    }

}
