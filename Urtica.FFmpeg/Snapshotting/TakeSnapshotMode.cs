namespace Urtica.FFmpeg.Snapshotting
{
    /// <summary>
    /// Describes taking snapshots algorithm
    /// </summary>
    public enum TakeSnapshotMode
    {
        /// <summary>
        /// Takes first frame in set.
        /// </summary>
        FirstInSet,

        /// <summary>
        /// Takes most representative frame in set (FFmpeg decides which one)
        /// </summary>
        MostRepresentative,
    }
}