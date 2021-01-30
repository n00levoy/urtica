namespace Urtica.FFmpeg.Entities.Probing
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// Media chapter information.
    /// </summary>
    public record MediaChapterInfo
    {
        /// <summary>
        /// Gets chapter start time.
        /// </summary>
        [JsonPropertyName("start_time")]
        public string StartTime { get; init; }

        /// <summary>
        /// Gets chapter end time.
        /// </summary>
        [JsonPropertyName("end_time")]
        public string EndTime { get; init; }

        /// <summary>
        /// Gets tags object.
        /// </summary>
        [JsonPropertyName("tags")]
        public MediaChapterTags Tags { get; init; }
    }
}