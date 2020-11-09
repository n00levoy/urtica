namespace Urtica.FFmpeg.Snapshotting
{
    using System;

    /// <summary>
    /// Take snapshot operation options
    /// </summary>
    public class TakeSnapshotOptions
    {
        /// <summary>
        /// Gets or sets snapshotting mode.
        /// </summary>
        public TakeSnapshotMode TakeMode { get; set; }

        /// <summary>
        /// Gets or sets interval between frame takes (sample set size).
        /// </summary>
        public DateTime Interval { get; set; }
    }
}