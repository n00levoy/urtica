namespace Urtica.FFmpeg.Processes
{
    using System;
    using System.Diagnostics;

    /// <summary>
    /// Base FFMpeg program process.
    /// </summary>
    public class BaseProcess : IDisposable
    {
        private readonly Process process;

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseProcess"/> class.
        /// </summary>
        protected BaseProcess()
        {
            var startInfo = new ProcessStartInfo
            {
                CreateNoWindow = true,
                UseShellExecute = true,
                RedirectStandardError = true,
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
            };

            this.process = new Process
            {
                EnableRaisingEvents = true,
                StartInfo = startInfo,
            };

            this.process.OutputDataReceived += this.OnOutputDataReceived;
            this.process.ErrorDataReceived += this.OnErrorDataReceived;
            this.process.Exited += this.OnProcessExited;
        }

        /// <summary>
        /// Disposes process.
        /// </summary>
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Disposes process if it should be disposed.
        /// </summary>
        /// <param name="disposing">Should process be disposed or not.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.process?.Dispose();
            }
        }

        /// <summary>
        /// Starts process with given args.
        /// </summary>
        /// <param name="fileName">Name of executable file.</param>
        /// <param name="arguments">Arguments to configure the process execution.</param>
        protected void Start(string fileName, string arguments)
        {
            this.process.StartInfo.FileName = fileName;
            this.process.StartInfo.Arguments = arguments;
            this.process.Start();
        }

        private void OnOutputDataReceived(object sender, DataReceivedEventArgs eventArgs)
        {
        }

        private void OnErrorDataReceived(object sender, DataReceivedEventArgs eventArgs)
        {
        }

        private void OnProcessExited(object sender, EventArgs errorCode)
        {
        }
    }
}