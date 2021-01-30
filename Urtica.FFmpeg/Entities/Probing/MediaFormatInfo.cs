namespace Urtica.FFmpeg.Entities.Probing
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// Media file format summary.
    /// </summary>
    public record MediaFormatInfo
    {
        /// <summary>
        /// Gets media file name.
        /// </summary>
        [JsonPropertyName("filename")]
        public string Filename { get; init; }

        /// <summary>
        /// Gets number of streams in media file.
        /// </summary>
        [JsonPropertyName("nb_streams")]
        public int StreamCount { get; init; }

        /// <summary>
        /// Gets format name.
        /// </summary>
        [JsonPropertyName("format_name")]
        public string FormatName { get; init; }

        /// <summary>
        /// Gets long format name.
        /// </summary>
        [JsonPropertyName("format_long_name")]
        public string LongFormatName { get; init; }

        /// <summary>
        /// Gets media file duration.
        /// </summary>
        [JsonPropertyName("duration")]
        public string Duration { get; init; }

        /// <summary>
        /// Gets media file size in bytes.
        /// </summary>
        [JsonPropertyName("size")]
        public long Size { get; init; }

        /// <summary>
        /// Gets media file bitrate.
        /// </summary>
        [JsonPropertyName("bit_rate")]
        public long Bitrate { get; init; }
    }
}