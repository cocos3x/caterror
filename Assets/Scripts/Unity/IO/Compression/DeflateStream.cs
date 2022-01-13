using UnityEngine;

namespace Unity.IO.Compression
{
    public class DeflateStream : Stream
    {
        // Fields
        internal const int DefaultBufferSize = 8192;
        private System.IO.Stream _stream;
        private Unity.IO.Compression.CompressionMode _mode;
        private bool _leaveOpen;
        private Unity.IO.Compression.Inflater inflater;
        private Unity.IO.Compression.IDeflater deflater;
        private byte[] buffer;
        private int asyncOperations;
        private readonly System.AsyncCallback m_CallBack;
        private readonly Unity.IO.Compression.DeflateStream.AsyncWriteDelegate m_AsyncWriterDelegate;
        private Unity.IO.Compression.IFileFormatWriter formatWriter;
        private bool wroteHeader;
        private bool wroteBytes;
        
        // Properties
        public System.IO.Stream BaseStream { get; }
        public override bool CanRead { get; }
        public override bool CanWrite { get; }
        public override bool CanSeek { get; }
        public override long Length { get; }
        public override long Position { get; set; }
        
        // Methods
        public DeflateStream(System.IO.Stream stream, Unity.IO.Compression.CompressionMode mode)
        {
        
        }
        public DeflateStream(System.IO.Stream stream, Unity.IO.Compression.CompressionMode mode, bool leaveOpen)
        {
            IntPtr val_9;
            var val_10;
            var val_11;
            var val_12;
            string val_14;
            string val_15;
            if(stream == null)
            {
                goto label_3;
            }
            
            if(mode >= 2)
            {
                goto label_4;
            }
            
            this._stream = stream;
            this._mode = mode;
            this._leaveOpen = leaveOpen;
            if(mode == 1)
            {
                goto label_5;
            }
            
            if(mode != 0)
            {
                goto label_6;
            }
            
            if((stream & 1) == 0)
            {
                goto label_9;
            }
            
            this.inflater = new Unity.IO.Compression.Inflater();
            val_9 = 1152921512137137616;
            goto label_10;
            label_5:
            if((stream & 1) == 0)
            {
                goto label_13;
            }
            
            this.deflater = Unity.IO.Compression.DeflateStream.CreateDeflater();
            mem[1152921512137312928] = this;
            mem[1152921512137312936] = System.Void Unity.IO.Compression.DeflateStream::InternalWrite(byte[] array, int offset, int count, bool isAsync);
            mem[1152921512137312912] = System.Void Unity.IO.Compression.DeflateStream::InternalWrite(byte[] array, int offset, int count, bool isAsync);
            this.m_AsyncWriterDelegate = new DeflateStream.AsyncWriteDelegate();
            System.AsyncCallback val_4 = null;
            val_9 = 1152921512137151952;
            label_10:
            val_4 = new System.AsyncCallback(object:  this, method:  val_9);
            this.m_CallBack = val_4;
            label_6:
            this.buffer = new byte[8192];
            return;
            label_3:
            val_10 = 1152921512137226784;
            val_11 = new System.ArgumentNullException(paramName:  "stream");
            goto label_14;
            label_4:
            val_12 = "Argument out of range";
            val_14 = "mode";
            goto label_15;
            label_9:
            val_15 = "Not a readable stream";
            goto label_16;
            label_13:
            val_15 = "Not a writeable stream";
            label_16:
            System.ArgumentException val_7 = null;
            val_14 = "stream";
            label_15:
            val_7 = new System.ArgumentException(message:  val_15, paramName:  val_14);
            val_10 = 1152921512137226784;
            val_11 = val_7;
            label_14:
        }
        private static Unity.IO.Compression.IDeflater CreateDeflater()
        {
            return (Unity.IO.Compression.IDeflater)new Unity.IO.Compression.DeflaterManaged();
        }
        private static Unity.IO.Compression.DeflateStream.WorkerType GetDeflaterType()
        {
            return 0;
        }
        internal void SetFileFormatReader(Unity.IO.Compression.IFileFormatReader reader)
        {
            if(reader == null)
            {
                    return;
            }
            
            this.inflater.formatReader = reader;
            this.inflater.hasFormatReader = true;
            this.inflater.state = 0;
        }
        internal void SetFileFormatWriter(Unity.IO.Compression.IFileFormatWriter writer)
        {
            if(writer == null)
            {
                    return;
            }
            
            this.formatWriter = writer;
        }
        public System.IO.Stream get_BaseStream()
        {
            return (System.IO.Stream)this._stream;
        }
        public override bool get_CanRead()
        {
            if(this._stream == null)
            {
                    return false;
            }
            
            if(this._mode != 0)
            {
                    return false;
            }
        
        }
        public override bool get_CanWrite()
        {
            if(this._stream == null)
            {
                    return false;
            }
            
            if(this._mode != 1)
            {
                    return false;
            }
            
            goto typeof(System.IO.Stream).__il2cppRuntimeField_1C8;
        }
        public override bool get_CanSeek()
        {
            return false;
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
            this.EnsureNotDisposed();
        }
        public override long Seek(long offset, System.IO.SeekOrigin origin)
        {
            System.NotSupportedException val_1 = new System.NotSupportedException(message:  "Not supported");
        }
        public override void SetLength(long value)
        {
            System.NotSupportedException val_1 = new System.NotSupportedException(message:  "Not supported");
        }
        public override int Read(byte[] array, int offset, int count)
        {
            int val_2;
            Unity.IO.Compression.Inflater val_3;
            val_2 = offset;
            this.EnsureDecompressionMode();
            this.ValidateParameters(array:  array, offset:  val_2, count:  count);
            this.EnsureNotDisposed();
            int val_3 = count;
            goto label_8;
            label_12:
            val_3 = this.inflater;
            Unity.IO.Compression.InflaterState val_2 = this.inflater.state;
            val_2 = val_2 - 23;
            if(val_2 < 2)
            {
                goto label_5;
            }
            
            if(this.buffer == null)
            {
                goto label_3;
            }
            
            label_10:
            val_3 = this._stream;
            if(val_3 == null)
            {
                goto label_5;
            }
            
            val_2 = W24 + val_2;
            this.inflater.input.buffer = this.buffer;
            this.inflater.input.start = 0;
            this.inflater.input.end = val_3;
            goto label_8;
            label_3:
            if(this._stream != null)
            {
                goto label_10;
            }
            
            goto label_10;
            label_8:
            int val_1 = this.inflater.Inflate(bytes:  array, offset:  val_2, length:  val_3);
            val_3 = val_3 - val_1;
            if(val_3 != 0)
            {
                goto label_12;
            }
            
            label_5:
            val_1 = count - val_3;
            return (int)val_1;
        }
        private void ValidateParameters(byte[] array, int offset, int count)
        {
            var val_4;
            string val_6;
            var val_7;
            var val_8;
            if(array == null)
            {
                goto label_1;
            }
            
            if((offset & 2147483648) != 0)
            {
                goto label_2;
            }
            
            if((count & 2147483648) != 0)
            {
                goto label_3;
            }
            
            int val_4 = array.Length;
            val_4 = val_4 - offset;
            if(val_4 < count)
            {
                goto label_4;
            }
            
            return;
            label_1:
            System.ArgumentNullException val_1 = null;
            val_4 = val_1;
            val_1 = new System.ArgumentNullException(paramName:  "array");
            goto label_5;
            label_2:
            val_6 = "offset";
            goto label_6;
            label_3:
            System.ArgumentOutOfRangeException val_2 = null;
            val_6 = "count";
            label_6:
            val_4 = val_2;
            val_2 = new System.ArgumentOutOfRangeException(paramName:  val_6);
            label_5:
            val_7 = 1152921512139586672;
            val_8 = val_4;
            goto label_7;
            label_4:
            val_7 = 1152921512139586672;
            val_8 = new System.ArgumentException(message:  "Invalid argument offset count");
            label_7:
        }
        private void EnsureNotDisposed()
        {
            if(this._stream != null)
            {
                    return;
            }
            
            System.ObjectDisposedException val_1 = new System.ObjectDisposedException(objectName:  0, message:  "Object disposed");
        }
        private void EnsureDecompressionMode()
        {
            if(this._mode == 0)
            {
                    return;
            }
            
            System.InvalidOperationException val_1 = new System.InvalidOperationException(message:  "Cannot read from deflate stream");
        }
        private void EnsureCompressionMode()
        {
            if(this._mode == 1)
            {
                    return;
            }
            
            System.InvalidOperationException val_1 = new System.InvalidOperationException(message:  "Cannot write to deflate stream");
        }
        public override System.IAsyncResult BeginRead(byte[] array, int offset, int count, System.AsyncCallback asyncCallback, object asyncState)
        {
            int val_10;
            object val_11;
            System.AsyncCallback val_12;
            var val_13;
            var val_14;
            val_10 = offset;
            val_11 = this;
            this.EnsureDecompressionMode();
            if(this.asyncOperations == 0)
            {
                    this.ValidateParameters(array:  array, offset:  val_10, count:  count);
                this.EnsureNotDisposed();
                int val_2 = System.Threading.Interlocked.Increment(location: ref  1152921512140289776);
                new Unity.IO.Compression.DeflateStreamAsyncResult() = new System.Object();
                .buffer = array;
                .offset = val_10;
                .count = count;
                .m_AsyncObject = val_11;
                .m_AsyncState = asyncState;
                .m_CompletedSynchronously = true;
                .m_AsyncCallback = asyncCallback;
                .isWrite = false;
                int val_4 = this.inflater.Inflate(bytes:  array, offset:  val_10, length:  count);
                if(val_4 != 0)
            {
                    .m_CompletedSynchronously = true;
                new Unity.IO.Compression.DeflateStreamAsyncResult().Complete(result:  val_4);
                return (System.IAsyncResult)new Unity.IO.Compression.DeflateStreamAsyncResult();
            }
            
                Unity.IO.Compression.InflaterState val_10 = this.inflater.state;
                val_10 = val_10 - 23;
                if(val_10 < 2)
            {
                    .m_CompletedSynchronously = true;
                new Unity.IO.Compression.DeflateStreamAsyncResult().Complete(result:  0);
                return (System.IAsyncResult)new Unity.IO.Compression.DeflateStreamAsyncResult();
            }
            
                val_10 = this._stream;
                val_12 = this.m_CallBack;
                bool val_5 = ((Unity.IO.Compression.DeflateStreamAsyncResult)[1152921512140366752].m_CompletedSynchronously == true) ? 1 : 0;
                val_5 = val_5 & (((Unity.IO.Compression.DeflateStreamAsyncResult)[1152921512140366752].m_Completed != 0) ? 1 : 0);
                .m_CompletedSynchronously = val_5;
                return (System.IAsyncResult)new Unity.IO.Compression.DeflateStreamAsyncResult();
            }
            
            System.InvalidOperationException val_7 = null;
            val_13 = val_7;
            val_7 = new System.InvalidOperationException(message:  "Invalid begin call");
            mem[8] = mem[(System.InvalidOperationException)[1152921512140436384]..ctor(message:  "Invalid begin call")];
            val_14 = 8;
        }
        private void ReadCallback(System.IAsyncResult baseStreamResult)
        {
            int val_4;
            System.IO.Stream val_9;
            var val_9 = 0;
            val_9 = val_9 + 1;
            object val_2 = baseStreamResult.AsyncState;
            var val_10 = 0;
            val_10 = val_10 + 1;
            bool val_7 = (0 != 0) ? 1 : 0;
            val_7 = val_7 & baseStreamResult.CompletedSynchronously;
            mem[72] = val_7;
            this.EnsureNotDisposed();
            val_9 = this._stream;
            if(val_9 <= 0)
            {
                goto label_16;
            }
            
            this.inflater.input.buffer = this.buffer;
            this.inflater.input.start = 0;
            this.inflater.input.end = val_9;
            val_9 = 11993091;
            int val_8 = this.inflater.Inflate(bytes:  val_9, offset:  7783104, length:  0);
            if(val_8 != 0)
            {
                goto label_20;
            }
            
            val_9 = this.inflater;
            Unity.IO.Compression.InflaterState val_11 = this.inflater.state;
            val_11 = val_11 - 23;
            if(val_11 >= 2)
            {
                goto label_22;
            }
            
            label_20:
            val_4 = val_8;
            0.Complete(result:  val_4);
            return;
            label_16:
            val_4 = 0;
            0.Complete(result:  val_4);
            return;
            label_22:
            val_9 = this._stream;
        }
        public override int EndRead(System.IAsyncResult asyncResult)
        {
            var val_3;
            this.EnsureDecompressionMode();
            this.CheckEndXxxxLegalStateAndParams(asyncResult:  asyncResult);
            if(asyncResult != null)
            {
                    this.AwaitAsyncResultCompletion(asyncResult:  asyncResult);
                if(this == null)
            {
                    return (int)null;
            }
            
                return (int)null;
            }
            
            this.AwaitAsyncResultCompletion(asyncResult:  0);
            val_3 = 0;
        }
        public override void Write(byte[] array, int offset, int count)
        {
            this.EnsureCompressionMode();
            this.ValidateParameters(array:  array, offset:  offset, count:  count);
            this.EnsureNotDisposed();
            this.InternalWrite(array:  array, offset:  offset, count:  count, isAsync:  false);
        }
        internal void InternalWrite(byte[] array, int offset, int count, bool isAsync)
        {
            this.DoMaintenance(array:  array, offset:  offset, count:  count);
            this.WriteDeflaterOutput(isAsync:  isAsync);
            var val_4 = 0;
            val_4 = val_4 + 1;
            this.deflater.SetInput(inputBuffer:  array, startIndex:  offset, count:  count);
            this.WriteDeflaterOutput(isAsync:  isAsync);
        }
        private void WriteDeflaterOutput(bool isAsync)
        {
            goto label_7;
            label_13:
            var val_5 = 0;
            val_5 = val_5 + 1;
            if(this.deflater >= 1)
            {
                    this.DoWrite(array:  this.buffer, offset:  0, count:  this.deflater, isAsync:  isAsync);
            }
            
            label_7:
            var val_6 = 0;
            val_6 = val_6 + 1;
            if(this.deflater.NeedsInput() == false)
            {
                goto label_13;
            }
        
        }
        private void DoWrite(byte[] array, int offset, int count, bool isAsync)
        {
            System.IO.Stream val_9;
            var val_10;
            var val_11;
            var val_12;
            val_9 = this._stream;
            val_10 = count;
            val_11 = offset;
            val_12 = array;
            if(isAsync != false)
            {
                    val_10 = ???;
                val_12 = ???;
                val_11 = ???;
                val_9 = ???;
            }
        
        }
        private void DoMaintenance(byte[] array, int offset, int count)
        {
            Unity.IO.Compression.IFileFormatWriter val_3;
            if(count < 1)
            {
                    return;
            }
            
            val_3 = this.formatWriter;
            this.wroteBytes = true;
            if(val_3 == null)
            {
                    return;
            }
            
            if(this.wroteHeader != true)
            {
                    var val_4 = 0;
                val_4 = val_4 + 1;
                System.Byte[] val_2 = val_3.GetHeader();
                val_3 = this.formatWriter;
                this.wroteHeader = true;
                if(val_3 == null)
            {
                goto label_15;
            }
            
            }
            
            label_15:
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_3.UpdateWithBytesRead(buffer:  array, offset:  offset, bytesToCopy:  count);
        }
        private void PurgeBuffers(bool disposing)
        {
            var val_3;
            int val_2 = 0;
            if(disposing == false)
            {
                    return;
            }
            
            if(this._stream == null)
            {
                    return;
            }
            
            if(this._mode != 1)
            {
                    return;
            }
            
            if(this.wroteBytes != false)
            {
                    this.WriteDeflaterOutput(isAsync:  false);
                do
            {
                var val_6 = 0;
                val_6 = val_6 + 1;
                val_3 = val_2;
            }
            while((this.deflater.Finish(outputBuffer:  this.buffer, bytesRead: out  val_2)) == false);
            
            }
            
            if(this.formatWriter == null)
            {
                    return;
            }
            
            if(this.wroteHeader == false)
            {
                    return;
            }
            
            var val_7 = 0;
            val_7 = val_7 + 1;
            this = this.formatWriter.GetFooter();
        }
        protected override void Dispose(bool disposing)
        {
            var val_4;
            var val_5;
            var val_6;
            var val_7;
            var val_9;
            val_5 = this;
            disposing = disposing;
            this.PurgeBuffers(disposing:  disposing);
            val_7 = 0;
            if(((disposing != false) && (this._leaveOpen != true)) && (this._stream != null))
            {
                    this._stream.Dispose();
            }
            
            mem2[0] = 86;
            this._stream = 0;
            if(this.deflater != null)
            {
                    var val_5 = 0;
                val_5 = val_5 + 1;
                this.deflater.Dispose();
            }
            
            val_9 = ((long)0 + 1) + 1;
            mem2[0] = 85;
            this.deflater = 0;
            this.Dispose(disposing:  disposing);
            if((val_9 == 1) || ((1152921512142441984 + (((long)(int)((0 + 1)) + 1)) << 2) != 85))
            {
                goto label_10;
            }
            
            if((val_9 & 2147483648) != 0)
            {
                goto label_15;
            }
            
            val_9 = val_9 - 1;
            goto label_13;
            label_10:
            if(val_7 != 0)
            {
                    val_7 = 0;
            }
            
            label_13:
            if(val_9 == 1)
            {
                goto label_14;
            }
            
            if((1152921512142441984 + (((long)(int)((0 + 1)) + 1)) << 2) != 86)
            {
                goto label_15;
            }
            
            if((val_9 & 2147483648) != 0)
            {
                goto label_19;
            }
            
            val_9 = val_9 - 1;
            goto label_18;
            label_14:
            val_9 = 0;
            label_15:
            if(val_7 != 0)
            {
                    val_7 = 0;
            }
            
            label_18:
            if(val_9 != 1)
            {
                    if(87 == 87)
            {
                goto label_21;
            }
            
            }
            
            label_19:
            if(val_7 != 0)
            {
                    val_4 = ???;
                val_7 = ???;
                val_5 = ???;
                val_6 = ???;
            }
            
            label_21:
            var val_4 = val_4 - 48;
        }
        public override System.IAsyncResult BeginWrite(byte[] array, int offset, int count, System.AsyncCallback asyncCallback, object asyncState)
        {
            int val_10;
            var val_11;
            var val_12;
            val_10 = offset;
            this.EnsureCompressionMode();
            if(this.asyncOperations == 0)
            {
                    this.ValidateParameters(array:  array, offset:  val_10, count:  count);
                this.EnsureNotDisposed();
                int val_2 = System.Threading.Interlocked.Increment(location: ref  1152921512142640912);
                new Unity.IO.Compression.DeflateStreamAsyncResult() = new System.Object();
                .buffer = array;
                .offset = val_10;
                .count = count;
                .m_AsyncObject = this;
                .m_AsyncState = asyncState;
                .m_CompletedSynchronously = true;
                .m_AsyncCallback = asyncCallback;
                .isWrite = true;
                System.IAsyncResult val_4 = this.m_AsyncWriterDelegate.BeginInvoke(array:  array, offset:  val_10, count:  count, isAsync:  true, callback:  this.m_CallBack, object:  new Unity.IO.Compression.DeflateStreamAsyncResult());
                bool val_5 = ((Unity.IO.Compression.DeflateStreamAsyncResult)[1152921512142717888].m_CompletedSynchronously == true) ? 1 : 0;
                val_5 = val_5 & (((Unity.IO.Compression.DeflateStreamAsyncResult)[1152921512142717888].m_Completed != 0) ? 1 : 0);
                .m_CompletedSynchronously = val_5;
                return (System.IAsyncResult)new Unity.IO.Compression.DeflateStreamAsyncResult();
            }
            
            System.InvalidOperationException val_7 = null;
            val_11 = val_7;
            val_7 = new System.InvalidOperationException(message:  "Invalid begin call");
            mem[8] = mem[(System.InvalidOperationException)[1152921512142734272]..ctor(message:  "Invalid begin call")];
            val_12 = 8;
        }
        private void WriteCallback(System.IAsyncResult asyncResult)
        {
            var val_8;
            bool val_10;
            var val_9 = 0;
            val_9 = val_9 + 1;
            val_8 = public System.Object System.IAsyncResult::get_AsyncState();
            object val_2 = asyncResult.AsyncState;
            if(val_2 != null)
            {
                    var val_10 = 0;
                val_10 = val_10 + 1;
                mem2[0] = ((W23 != 0) ? 1 : 0) & asyncResult.CompletedSynchronously;
                val_2.Complete(result:  0);
                return;
            }
            
            val_10 = 0;
        }
        public override void EndWrite(System.IAsyncResult asyncResult)
        {
            var val_3;
            this.EnsureCompressionMode();
            this.CheckEndXxxxLegalStateAndParams(asyncResult:  asyncResult);
            if(asyncResult != null)
            {
                    this.AwaitAsyncResultCompletion(asyncResult:  asyncResult);
                if(this == null)
            {
                    return;
            }
            
                return;
            }
            
            this.AwaitAsyncResultCompletion(asyncResult:  0);
            val_3 = 0;
        }
        private void CheckEndXxxxLegalStateAndParams(System.IAsyncResult asyncResult)
        {
            var val_3;
            var val_4;
            if(this.asyncOperations == 1)
            {
                    if(asyncResult != null)
            {
                    this.EnsureNotDisposed();
                return;
            }
            
                val_3 = 1152921512143056416;
                val_4 = new System.ArgumentNullException(paramName:  "asyncResult");
            }
            else
            {
                    val_3 = 1152921512143056416;
                val_4 = new System.InvalidOperationException(message:  "Invalid end call");
            }
        
        }
        private void AwaitAsyncResultCompletion(Unity.IO.Compression.DeflateStreamAsyncResult asyncResult)
        {
            var val_10;
            var val_11;
            val_10 = asyncResult;
            if(asyncResult.m_Completed == 0)
            {
                    System.Threading.WaitHandle val_1 = val_10.AsyncWaitHandle;
            }
            
            val_11 = 0;
            int val_3 = System.Threading.Interlocked.Decrement(location: ref  this.asyncOperations);
            val_10.Close();
            if(0 != 1)
            {
                    return;
            }
            
            if(val_11 == 0)
            {
                    return;
            }
            
            val_10 = ???;
            val_11 = ???;
        }
    
    }

}
