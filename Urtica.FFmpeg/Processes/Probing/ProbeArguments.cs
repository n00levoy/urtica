namespace Urtica.FFmpeg.Processes.Probing
{
    using System.IO;
    using Urtica.FFmpeg.Exceptions;

    /// <summary>
    /// Arguments for a probe process.
    /// </summary>
    public class ProbeArguments : IProcessArguments
    {
        /// <summary>
        /// Gets a media file path which will be probed.
        /// </summary>
        public string MediaFilePath { get; init; }

        /// <summary>
        /// Gets a value indicating whether a streams info should be output.
        /// </summary>
        public bool OutputStreams { get; init; }

        /// <summary>
        /// Gets a value indicating whether a format info should be output.
        /// </summary>
        public bool OutputFormat { get; init; }

        /// <inheritdoc/>
        public string ToArgumentsList()
        {
            this.ValidateArguments();

            var argumentsBuilder = new ProbeArgumentsBuilder()
                .HideBanner()
                .WithErrorLogLevel()
                .WithOutputFormat(ProbeOutputFormat.Json)
                .SexagesimalForTimeValues();

            if (this.OutputStreams)
            {
                argumentsBuilder.ShowStreams();
            }

            if (this.OutputFormat)
            {
                argumentsBuilder.ShowFormat();
            }

            return argumentsBuilder
                .WithSourceMediaFile(this.MediaFilePath)
                .ToString();
        }

        private void ValidateArguments()
        {
            var hasOutput = this.OutputStreams || this.OutputFormat;
            if (!hasOutput)
            {
                throw new NoInfoToOutputException();
            }

            if (!File.Exists(this.MediaFilePath))
            {
                throw new InputFileNotExistsException(this.MediaFilePath);
            }
        }
    }
}