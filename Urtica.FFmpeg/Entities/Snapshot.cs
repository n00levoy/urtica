namespace Urtica.FFmpeg.Entities
{
    /// <summary>
    /// Snapshot taken from media source.
    /// </summary>
    public class Snapshot
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Snapshot"/> class.
        /// </summary>
        /// <param name="id">Snapshot id.</param>
        /// <param name="rawImage">Snapshot raw image.</param>
        internal Snapshot(string id, RawImage rawImage)
        {
            this.Id = id;
            this.RawImage = rawImage;
        }

        /// <summary>
        /// Gets snapshot id.
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// Gets snapshot raw image.
        /// </summary>
        public RawImage RawImage { get; }
    }
}