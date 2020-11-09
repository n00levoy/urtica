namespace Urtica.FFmpeg.Entities
{
    using System.Collections.Generic;

    /// <summary>
    /// Collection of generated snapshots.
    /// </summary>
    public class SnapshotCollection
    {
        private readonly List<Snapshot> snapshots = new List<Snapshot>();

        /// <summary>
        /// Gets snapshots list.
        /// </summary>
        public IReadOnlyList<Snapshot> Snapshots => this.snapshots;

        /// <summary>
        /// Adds snapshot to collection.
        /// </summary>
        /// <param name="snapshot">Snapshot to add.</param>
        internal void AddSnapshot(Snapshot snapshot)
        {
            this.snapshots.Add(snapshot);
        }
    }
}