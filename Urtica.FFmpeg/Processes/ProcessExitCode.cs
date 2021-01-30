namespace Urtica.FFmpeg.Processes
{
    /// <summary>
    /// Describes process exit code / status.
    /// </summary>
    public readonly struct ProcessExitCode
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessExitCode"/> struct.
        /// </summary>
        /// <param name="code">Integer exit code presentation.</param>
        public ProcessExitCode(int code)
        {
            this.Code = code;
        }

        /// <summary>
        /// Gets integer exit code presentation.
        /// </summary>
        public int Code { get; }

        /// <summary>
        /// Gets a value indicating whether process exited successfully.
        /// </summary>
        public bool IsSuccess => this.Code == 0;
    }
}