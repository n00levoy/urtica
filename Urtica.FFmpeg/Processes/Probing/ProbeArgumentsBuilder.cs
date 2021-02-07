namespace Urtica.FFmpeg.Processes.Probing
{
    using System;

    /// <summary>
    /// Helps build arguments list for probe process.
    /// </summary>
    internal class ProbeArgumentsBuilder : ProcessArgumentsBuilder
    {
        /// <summary>
        /// Excludes banner information output.
        /// </summary>
        /// <returns>Returns instance of this builder with added argument.</returns>
        public ProbeArgumentsBuilder HideBanner()
        {
            this.AddKeyArgument("hide_banner");
            return this;
        }

        /// <summary>
        /// Sets output log level to error, i.e. shows all errors, including ones which can be recovered from.
        /// </summary>
        /// <returns>Returns instance of this builder with added argument.</returns>
        public ProbeArgumentsBuilder WithErrorLogLevel()
        {
            this.AddKeyValuePair("loglevel", "error");
            return this;
        }

        /// <summary>
        /// Sets output format.
        /// </summary>
        /// <param name="format">Expected output <see cref="ProbeOutputFormat">format</see>.</param>
        /// <returns>Returns instance of this builder with added argument.</returns>
        public ProbeArgumentsBuilder WithOutputFormat(ProbeOutputFormat format)
        {
            this.AddKeyValuePair("show_format", format.ToString().ToLowerInvariant());
            return this;
        }

        /// <summary>
        /// Sets sexagesimal format HH:MM:SS.MICROSECONDS for time values.
        /// </summary>
        /// <returns>Returns instance of this builder with added argument.</returns>
        public ProbeArgumentsBuilder SexagesimalForTimeValues()
        {
            this.AddKeyArgument("sexagesimal");
            return this;
        }

        /// <summary>
        /// Show information about each media stream contained in the input multimedia stream.
        /// </summary>
        /// <returns>Returns instance of this builder with added argument.</returns>
        public ProbeArgumentsBuilder ShowStreams()
        {
            this.AddKeyArgument("show_streams");
            return this;
        }

        /// <summary>
        /// Show information about the container format of the input multimedia stream.
        /// </summary>
        /// <returns>Returns instance of this builder with added argument.</returns>
        public ProbeArgumentsBuilder ShowFormat()
        {
            this.AddKeyArgument("show_format");
            return this;
        }

        /// <summary>
        /// Show information about chapters stored in the format.
        /// </summary>
        /// <returns>Returns instance of this builder with added argument.</returns>
        public ProbeArgumentsBuilder ShowChapters()
        {
            this.AddKeyArgument("show_chapters");
            return this;
        }

        /// <summary>
        /// Sets path to output to.
        /// </summary>
        /// <param name="path">Output path to filename or other type of sink.</param>
        /// <exception cref="ArgumentException">Throws if <paramref name="path"/> is null.</exception>
        /// <returns>Returns instance of this builder with added argument.</returns>
        public ProbeArgumentsBuilder WithMediaFileToProcess(string path)
        {
            if (path == null)
            {
                throw new ArgumentException("Probe process requires file to process");
            }

            this.AddValueArgument(path);
            return this;
        }
    }
}