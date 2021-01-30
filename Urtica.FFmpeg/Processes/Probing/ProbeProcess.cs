namespace Urtica.FFmpeg.Processes.Probing
{
    using System.Threading.Tasks;
    using Urtica.FFmpeg.Entities.Probing;

    /// <summary>
    /// FFProbe program process.
    /// </summary>
    public class ProbeProcess : BaseProcess
    {
        private readonly string binaryPath;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProbeProcess"/> class.
        /// </summary>
        /// <param name="binaryPath">Path to probe program executable.</param>
        public ProbeProcess(string binaryPath)
        {
            this.binaryPath = binaryPath;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<MediaInfo> ProbeMedia(ProbeParameters parameters)
        {
            var code = await this.Start(this.binaryPath, parameters.ToArgumentsList());
            if (!code.IsSuccess)
            {
                return null;
            }

            return new MediaInfo();
        }
    }
}