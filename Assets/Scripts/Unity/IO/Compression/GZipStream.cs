using UnityEngine;

namespace Unity.IO.Compression
{
    public class GZipStream : Stream
    {
        // Fields
        private Unity.IO.Compression.DeflateStream deflateStream;
        
        // Properties
        public override bool CanRead { get; }
        public override bool CanWrite { get; }
        public override bool CanSeek { get; }
        public override long Length { get; }
        public override long Position { get; set; }
        public System.IO.Stream BaseStream { get; }
        
        // Methods
        public GZipStream(System.IO.Stream stream, Unity.IO.Compression.CompressionMode mode)
        {
        
        }
        public GZipStream(System.IO.Stream stream, Unity.IO.Compression.CompressionMode mode, bool leaveOpen)
        {
            Unity.IO.Compression.DeflateStream val_1 = null;
            leaveOpen = leaveOpen;
            val_1 = new Unity.IO.Compression.DeflateStream(stream:  stream, mode:  mode, leaveOpen:  leaveOpen);
            this.deflateStream = val_1;
            this.SetDeflateStreamFileFormatter(mode:  mode);
        }
        private void SetDeflateStreamFileFormatter(Unity.IO.Compression.CompressionMode mode)
        {
            Unity.IO.Compression.DeflateStream val_3;
            if(mode == 1)
            {
                    Unity.IO.Compression.GZipFormatter val_1 = new Unity.IO.Compression.GZipFormatter(compressionLevel:  3);
                val_3 = this.deflateStream;
                if(val_1 == null)
            {
                    return;
            }
            
                this.deflateStream.formatWriter = val_1;
                return;
            }
            
            Unity.IO.Compression.GZipDecoder val_2 = new Unity.IO.Compression.GZipDecoder();
            .gzipHeaderSubstate = 64424509440;
            .expectedCrc32 = 0;
            .expectedOutputStreamSizeModulo = 0;
            val_3 = this.deflateStream;
            if(val_2 == null)
            {
                    return;
            }
            
            val_3 = this.deflateStream.inflater;
            this.deflateStream.inflater.formatReader = val_2;
            this.deflateStream.inflater.hasFormatReader = true;
            this.deflateStream.inflater.state = 0;
        }
        public override bool get_CanRead()
        {
            if(this.deflateStream == null)
            {
                    return (bool)this.deflateStream;
            }
            
            goto typeof(Unity.IO.Compression.DeflateStream).__il2cppRuntimeField_198;
        }
        public override bool get_CanWrite()
        {
            if(this.deflateStream == null)
            {
                    return (bool)this.deflateStream;
            }
            
            goto typeof(Unity.IO.Compression.DeflateStream).__il2cppRuntimeField_1C8;
        }
        public override bool get_CanSeek()
        {
            if(this.deflateStream == null)
            {
                    return (bool)this.deflateStream;
            }
            
            goto typeof(Unity.IO.Compression.DeflateStream).__il2cppRuntimeField_1A8;
        }
        public override long get_Length()
        {
            System.NotSupportedException val_1 = new System.NotSupportedException(message:  "Not supported");
        }
        public override long get_Position()
        {
            System.NotSupportedException val_1 = new System.NotSupportedException(message:  "Not supported");
        }
        public override void set_Position(long value)
        {
            System.NotSupportedException val_1 = new System.NotSupportedException(message:  "Not supported");
        }
        public override void Flush()
        {
            if(this.deflateStream != null)
            {
                
            }
            else
            {
                    System.ObjectDisposedException val_1 = new System.ObjectDisposedException(objectName:  0, message:  "Object disposed");
            }
        
        }
        public override long Seek(long offset, System.IO.SeekOrigin origin)
        {
            System.NotSupportedException val_1 = new System.NotSupportedException(message:  "Not supported");
        }
        public override void SetLength(long value)
        {
            System.NotSupportedException val_1 = new System.NotSupportedException(message:  "Not supported");
        }
        public override System.IAsyncResult BeginRead(byte[] array, int offset, int count, System.AsyncCallback asyncCallback, object asyncState)
        {
            if(this.deflateStream != null)
            {
                
            }
            else
            {
                    System.InvalidOperationException val_1 = new System.InvalidOperationException(message:  "Object disposed");
            }
        
        }
        public override int EndRead(System.IAsyncResult asyncResult)
        {
            if(this.deflateStream != null)
            {
                
            }
            else
            {
                    System.InvalidOperationException val_1 = new System.InvalidOperationException(message:  "Object disposed");
            }
        
        }
        public override System.IAsyncResult BeginWrite(byte[] array, int offset, int count, System.AsyncCallback asyncCallback, object asyncState)
        {
            if(this.deflateStream != null)
            {
                
            }
            else
            {
                    System.InvalidOperationException val_1 = new System.InvalidOperationException(message:  "Object disposed");
            }
        
        }
        public override void EndWrite(System.IAsyncResult asyncResult)
        {
            if(this.deflateStream != null)
            {
                
            }
            else
            {
                    System.InvalidOperationException val_1 = new System.InvalidOperationException(message:  "Object disposed");
            }
        
        }
        public override int Read(byte[] array, int offset, int count)
        {
            if(this.deflateStream != null)
            {
                
            }
            else
            {
                    System.ObjectDisposedException val_1 = new System.ObjectDisposedException(objectName:  0, message:  "Object disposed");
            }
        
        }
        public override void Write(byte[] array, int offset, int count)
        {
            if(this.deflateStream != null)
            {
                
            }
            else
            {
                    System.ObjectDisposedException val_1 = new System.ObjectDisposedException(objectName:  0, message:  "Object disposed");
            }
        
        }
        protected override void Dispose(bool disposing)
        {
            if((disposing != false) && (this.deflateStream != null))
            {
                    this.deflateStream.Dispose();
            }
            
            this.deflateStream = 0;
            this.Dispose(disposing:  disposing);
        }
        public System.IO.Stream get_BaseStream()
        {
            if(this.deflateStream == null)
            {
                    return 0;
            }
            
            return (System.IO.Stream)this.deflateStream._stream;
        }
    
    }

}
