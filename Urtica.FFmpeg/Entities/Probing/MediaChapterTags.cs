namespace Urtica.FFmpeg.Entities.Probing
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// Media chapter tags set.
    /// </summary>
    public record MediaChapterTags
    {
        /// <summary>
        /// Gets a chapter title.
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; init; }
    }
}