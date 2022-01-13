using UnityEngine;

namespace Unity.IO.Compression
{
    internal interface IFileFormatReader
    {
        // Methods
        public abstract bool ReadHeader(Unity.IO.Compression.InputBuffer input); // 0
        public abstract bool ReadFooter(Unity.IO.Compression.InputBuffer input); // 0
        public abstract void UpdateWithBytesRead(byte[] buffer, int offset, int bytesToCopy); // 0
        public abstract void Validate(); // 0
    
    }

}
