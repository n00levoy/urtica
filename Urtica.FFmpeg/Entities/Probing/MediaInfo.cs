namespace Urtica.FFmpeg.Entities.Probing
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Media file information.
    /// </summary>
    public record MediaInfo
    {
        /// <summary>
        /// Gets list of streams information.
        /// </summary>
        [JsonPropertyName("streams")]
        public List<MediaStreamInfo> Streams { get; init; }

        /// <summary>
        /// Gets list of chapters information.
        /// </summary>
        [JsonPropertyName("chapters")]
        public List<MediaChapterInfo> Chapters { get; init; }

        /// <summary>
        /// Gets format information.
        /// </summary>
        [JsonPropertyName("format")]
        public MediaFormatInfo Format { get; init; }
    }
}