namespace Urtica.FFmpeg.Entities
{
    using System.Collections.Generic;

    /// <summary>
    /// Raw bytes image representation.
    /// </summary>
    public class RawImage
    {
        private readonly byte[] rawBytes;

        /// <summary>
        /// Initializes a new instance of the <see cref="RawImage"/> class from raw bytes.
        /// </summary>
        /// <param name="rawBytes">Raw bytes of image.</param>
        public RawImage(byte[] rawBytes)
        {
            this.rawBytes = new byte[rawBytes.Length];
            rawBytes.CopyTo(this.rawBytes, 0);
        }

        /// <summary>
        /// Gets collection of image raw bytes.
        /// </summary>
        public IReadOnlyList<byte> RawBytes => this.rawBytes;
    }
}