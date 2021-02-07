namespace Urtica.FFmpeg.Exceptions
{
    /// <summary>
    /// Should be thrown when provided input file wasn't found by filesystem.
    /// </summary>
    public class InputFileNotExistsException : System.Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InputFileNotExistsException"/> class.
        /// </summary>
        /// <param name="filePath">File path to input file.</param>
        public InputFileNotExistsException(string filePath)
        {
            this.FilePath = filePath;
        }

        /// <summary>
        /// Gets input file path.
        /// </summary>
        public string FilePath { get; }
    }
}