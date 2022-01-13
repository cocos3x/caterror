using UnityEngine;

namespace Unity.IO.Compression
{
    internal interface IDeflater : IDisposable
    {
        // Methods
        public abstract bool NeedsInput(); // 0
        public abstract void SetInput(byte[] inputBuffer, int startIndex, int count); // 0
        public abstract int GetDeflateOutput(byte[] outputBuffer); // 0
        public abstract bool Finish(byte[] outputBuffer, out int bytesRead); // 0
    
    }

}
