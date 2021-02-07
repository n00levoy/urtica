namespace Urtica.FFmpeg.Entities.Probing
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// Media stream tags set.
    /// </summary>
    public class MediaStreamTags
    {
        /// <summary>
        /// Gets stream title.
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; init; }

        /// <summary>
        /// Gets stream language.
        /// </summary>
        [JsonPropertyName("language")]
        public string Language { get; init; }

        /// <summary>
        /// Gets stream duration.
        /// </summary>
        [JsonPropertyName("DURATION-eng")]
        public string Duration { get; init; }

        /// <summary>
        /// Gets stream frame count.
        /// </summary>
        [JsonPropertyName("NUMBER_OF_FRAMES-eng")]
        public long FrameCount { get; init; }
    }
}