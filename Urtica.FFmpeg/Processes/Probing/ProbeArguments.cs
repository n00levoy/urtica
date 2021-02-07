﻿namespace Urtica.FFmpeg.Processes.Probing
{
    using System.IO;
    using Urtica.FFmpeg.Exceptions;

    /// <summary>
    /// Arguments for probe process.
    /// </summary>
    public class ProbeArguments : IProcessArguments
    {
        /// <summary>
        /// Gets media file path.
        /// </summary>
        public string MediaFilePath { get; init; }

        /// <summary>
        /// Gets a value indicating whether streams info should be outputted.
        /// </summary>
        public bool OutputStreams { get; init; }

        /// <summary>
        /// Gets a value indicating whether format info should be outputted.
        /// </summary>
        public bool OutputFormat { get; init; }

        /// <summary>
        /// Gets a value indicating whether chapters info should be outputted.
        /// </summary>
        public bool OutputChapters { get; init; }

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

            if (this.OutputChapters)
            {
                argumentsBuilder.ShowChapters();
            }

            return argumentsBuilder
                .WithMediaFileToProcess(this.MediaFilePath)
                .ToString();
        }

        private void ValidateArguments()
        {
            var hasOutput = this.OutputStreams || this.OutputFormat || this.OutputChapters;
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