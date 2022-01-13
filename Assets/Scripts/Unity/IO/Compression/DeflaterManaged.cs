using UnityEngine;

namespace Unity.IO.Compression
{
    internal class DeflaterManaged : IDeflater, IDisposable
    {
        // Fields
        private const int MinBlockSize = 256;
        private const int MaxHeaderFooterGoo = 120;
        private const int CleanCopySize = 8072;
        private const double BadCompressionThreshold = 1;
        private Unity.IO.Compression.FastEncoder deflateEncoder;
        private Unity.IO.Compression.CopyEncoder copyEncoder;
        private Unity.IO.Compression.DeflateInput input;
        private Unity.IO.Compression.OutputBuffer output;
        private Unity.IO.Compression.DeflaterManaged.DeflaterState processingState;
        private Unity.IO.Compression.DeflateInput inputFromHistory;
        
        // Methods
        internal DeflaterManaged()
        {
            this.deflateEncoder = new Unity.IO.Compression.FastEncoder();
            this.copyEncoder = new Unity.IO.Compression.CopyEncoder();
            this.input = new Unity.IO.Compression.DeflateInput();
            this.output = new Unity.IO.Compression.OutputBuffer();
            this.processingState = 0;
        }
        private bool NeedsInput()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            return this.NeedsInput();
        }
        private bool Unity.IO.Compression.IDeflater.NeedsInput()
        {
            Unity.IO.Compression.FastEncoderWindow val_2;
            var val_3;
            val_2 = this;
            if(this.input.count != 0)
            {
                    val_3 = 0;
                return (bool)(this.deflateEncoder.inputWindow.bufEnd == this.deflateEncoder.inputWindow.bufPos) ? 1 : 0;
            }
            
            val_2 = this.deflateEncoder.inputWindow;
            return (bool)(this.deflateEncoder.inputWindow.bufEnd == this.deflateEncoder.inputWindow.bufPos) ? 1 : 0;
        }
        private void Unity.IO.Compression.IDeflater.SetInput(byte[] inputBuffer, int startIndex, int count)
        {
            DeflaterState val_2;
            this.input.buffer = inputBuffer;
            this.input.count = count;
            this.input.startIndex = startIndex;
            if((count - 1) > 254)
            {
                    return;
            }
            
            if(this.processingState == 5)
            {
                goto label_4;
            }
            
            if(this.processingState == 4)
            {
                goto label_5;
            }
            
            if(this.processingState != 0)
            {
                    return;
            }
            
            label_4:
            val_2 = 3;
            goto label_7;
            label_5:
            val_2 = 6;
            label_7:
            this.processingState = val_2;
        }
        private int Unity.IO.Compression.IDeflater.GetDeflateOutput(byte[] outputBuffer)
        {
            Unity.IO.Compression.OutputBuffer val_2 = this.output;
            this.output.byteBuffer = outputBuffer;
            this.output.pos = 0;
            if(this.processingState <= 6)
            {
                    var val_2 = 27001804 + (this.processingState) << 2;
                val_2 = val_2 + 27001804;
            }
            else
            {
                    if(this.output != null)
            {
                    return (int)this.output.pos;
            }
            
                return (int)this.output.pos;
            }
        
        }
        private bool Unity.IO.Compression.IDeflater.Finish(byte[] outputBuffer, out int bytesRead)
        {
            DeflaterState val_1;
            System.Byte[] val_2;
            val_1 = this.processingState;
            val_2 = outputBuffer;
            if(val_1 != 0)
            {
                    this.output.byteBuffer = val_2;
                this.output.pos = 0;
                DeflaterState val_1 = this.processingState;
                if(val_1 <= 6)
            {
                    val_1 = 1 << val_1;
                val_1 = val_1 & 82;
                if(val_1 != 0)
            {
                    val_2 = this.output;
                0.WriteEndOfBlock(output:  val_2);
            }
            
            }
            
                this.WriteFinal();
                val_1 = this.output.pos;
            }
            
            bytesRead = val_1;
            return true;
        }
        private void System.IDisposable.Dispose()
        {
        
        }
        protected void Dispose(bool disposing)
        {
        
        }
        private bool UseCompressed(double ratio)
        {
            return (bool)(ratio <= 1) ? 1 : 0;
        }
        private void FlushInputWindows()
        {
            this.deflateEncoder.FlushInput();
        }
        private void WriteFinal()
        {
            this.copyEncoder.GetBlock(input:  0, output:  this.output, isFinal:  true);
        }
    
    }

}
