namespace Urtica.FFmpeg.Exceptions
{
    /// <summary>
    /// Should be thrown when the provided input file wasn't found by the filesystem.
    /// </summary>
    public class InputFileNotExistsException : System.Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InputFileNotExistsException"/> class.
        /// </summary>
        /// <param name="filePath">File path to the input file.</param>
        public InputFileNotExistsException(string filePath)
        {
            this.FilePath = filePath;
        }

        /// <summary>
        /// Gets an input file path.
        /// </summary>
        public string FilePath { get; }
    }
}