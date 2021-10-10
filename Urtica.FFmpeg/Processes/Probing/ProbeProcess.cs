namespace Urtica.FFmpeg.Processes.Probing
{
    using System.Text;
    using System.Text.Json;
    using System.Threading.Tasks;
    using Urtica.FFmpeg.Entities.Probing;

    /// <summary>
    /// FFProbe program process.
    /// </summary>
    public class ProbeProcess : BaseProcess
    {
        private readonly string binaryPath;
        private readonly StringBuilder receivedDataBuilder = new();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProbeProcess"/> class.
        /// </summary>
        /// <param name="binaryPath">The path to the probe program executable.</param>
        public ProbeProcess(string binaryPath)
        {
            this.binaryPath = binaryPath;
        }

        /// <summary>
        /// Extracts a requested metadata from the media file.
        /// </summary>
        /// <param name="arguments">Probe process parameters.</param>
        /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
        public async Task<MediaInfo> ProbeFile(ProbeArguments arguments)
        {
            var code = await this.Start(this.binaryPath, arguments.ToArgumentsList());
            if (!code.Success)
            {
                return null;
            }

            var receivedData = this.receivedDataBuilder.ToString();
            if (string.IsNullOrEmpty(receivedData))
            {
                return null;
            }

            return JsonSerializer.Deserialize<MediaInfo>(receivedData);
        }

        /// <inheritdoc/>
        protected override void ProcessReceivedOutputData(string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                return;
            }

            this.receivedDataBuilder.Append(data);
        }
    }
}