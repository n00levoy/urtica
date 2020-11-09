namespace Urtica.FFmpeg
{
    using System;
    using System.Threading.Tasks;
    using Urtica.FFmpeg.Entities;
    using Urtica.FFmpeg.Snapshotting;

    /// <summary>
    /// FFmpeg program access manager.
    /// </summary>
    internal class MediaManager : IMediaManager
    {
        /// <summary>
        /// Analyzes media file and forms media info.
        /// </summary>
        /// <param name="source">Source of media / media file.</param>
        /// <returns>Media info containing media file description.</returns>
        public Task<MediaInfo> AnalyzeMedia(MediaSource source)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Takes snapshots from given media source with chosen algorithm.
        /// </summary>
        /// <param name="source">Media source to take snapshots from.</param>
        /// <param name="options">Snapshotting operation options.</param>
        /// <returns>A <see cref="Task{TResult}"/> representing collection of snapshots..</returns>
        public Task<SnapshotCollection> TakeSnapshots(MediaSource source, TakeSnapshotOptions options)
        {
            throw new NotImplementedException();
        }
    }
}