namespace Urtica.FFmpeg.Processes
{
    using System;
    using System.Diagnostics;
    using System.Threading.Tasks;

    /// <summary>
    /// Base FFmpeg program process.
    /// </summary>
    public abstract class BaseProcess : IDisposable
    {
        private readonly Process process;
        private readonly TaskCompletionSource<ProcessExitCode> executionCompletionSource;

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

            this.executionCompletionSource = new TaskCompletionSource<ProcessExitCode>();
        }

        /// <summary>
        /// Gets a value indicating whether the process execution is started.
        /// </summary>
        public bool Started { get; private set; }

        /// <summary>
        /// Gets a task of the process execution.
        /// </summary>
        public Task<ProcessExitCode> ExecutionTask => this.executionCompletionSource.Task;

        /// <summary>
        /// Disposes the process.
        /// </summary>
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Disposes the process if it should be disposed.
        /// </summary>
        /// <param name="disposing">Should process be disposed or not.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (!disposing || this.process == null)
            {
                return;
            }

            this.process.OutputDataReceived -= this.OnOutputDataReceived;
            this.process.ErrorDataReceived -= this.OnErrorDataReceived;
            this.process.Exited -= this.OnProcessExited;
            this.process.Dispose();
        }

        /// <summary>
        /// Starts the process with the given args.
        /// </summary>
        /// <param name="fileName">Name of the executable file.</param>
        /// <param name="arguments">Arguments to configure the process execution.</param>
        /// <returns>A <see cref="Task"/> representing the process execution.</returns>
        protected Task<ProcessExitCode> Start(string fileName, string arguments)
        {
            if (this.Started)
            {
                return this.ExecutionTask;
            }

            this.Started = true;

            this.process.StartInfo.FileName = fileName;
            this.process.StartInfo.Arguments = arguments;

            this.process.Start();
            this.process.BeginOutputReadLine();
            this.process.BeginErrorReadLine();

            return this.ExecutionTask;
        }

        /// <summary>
        /// Process an output data, received from the running process.
        /// </summary>
        /// <param name="data">Received output data.</param>
        protected virtual void ProcessReceivedOutputData(string data)
        {
        }

        /// <summary>
        /// Process an error string, received from the running process.
        /// </summary>
        /// <param name="data">Received error string.</param>
        protected virtual void ProcessReceivedErrorData(string data)
        {
        }

        /// <summary>
        /// Process the exit of the executed process.
        /// </summary>
        /// <param name="exitCode">Exit code of the executed process.</param>
        protected virtual void ProcessExit(in ProcessExitCode exitCode)
        {
            this.executionCompletionSource.TrySetResult(exitCode);
        }

        private void OnOutputDataReceived(object sender, DataReceivedEventArgs eventArgs)
        {
            if (!this.Started && eventArgs.Data == null)
            {
                return;
            }

            this.ProcessReceivedOutputData(eventArgs.Data);
        }

        private void OnErrorDataReceived(object sender, DataReceivedEventArgs eventArgs)
        {
            if (!this.Started && eventArgs.Data == null)
            {
                return;
            }

            this.ProcessReceivedErrorData(eventArgs.Data);
        }

        private void OnProcessExited(object sender, EventArgs errorCode)
        {
            if (!this.Started || !this.process.HasExited)
            {
                return;
            }

            this.ProcessExit(new ProcessExitCode(this.process.ExitCode));
        }
    }
}