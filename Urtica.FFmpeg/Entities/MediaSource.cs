namespace Urtica.FFmpeg.Entities
{
    using System.IO;

    public class MediaSource
    {
        private readonly FileInfo sourceFileInfo;

        /// <summary>
        /// Initializes a new instance of the <see cref="MediaSource"/> class.
        /// </summary>
        /// <param name="fileInfo">File info of media source.</param>
        public MediaSource(FileInfo fileInfo)
        {
            this.sourceFileInfo = fileInfo;
        }
    }
}