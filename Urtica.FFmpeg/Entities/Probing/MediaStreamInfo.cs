namespace Urtica.FFmpeg.Entities.Probing
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// Media stream information.
    /// </summary>
    public record MediaStreamInfo
    {
        /// <summary>
        /// Gets stream id.
        /// </summary>
        [JsonPropertyName("index")]
        public int Id { get; init; }

        /// <summary>
        /// Gets codec name.
        /// </summary>
        [JsonPropertyName("codec_name")]
        public string CodecName { get; init; }

        /// <summary>
        /// Gets long codec name.
        /// </summary>
        [JsonPropertyName("codec_long_name")]
        public string LongCodecName { get; init; }

        /// <summary>
        /// Gets codec type.
        /// </summary>
        [JsonPropertyName("codec_type")]
        public string CodecType { get; init; }

        /// <summary>
        /// Gets video stream profile.
        /// </summary>
        [JsonPropertyName("profile")]
        public string Profile { get; init; }

        /// <summary>
        /// Gets video stream width.
        /// </summary>
        [JsonPropertyName("width")]
        public int Width { get; init; }

        /// <summary>
        /// Gets video stream height.
        /// </summary>
        [JsonPropertyName("height")]
        public int Height { get; init; }

        /// <summary>
        /// Gets display aspect ration of video stream.
        /// </summary>
        [JsonPropertyName("display_aspect_ratio")]
        public string DisplayAspectRatio { get; init; }

        /// <summary>
        /// Gets pixel format of video stream.
        /// </summary>
        [JsonPropertyName("pix_fmt")]
        public string PixelFormat { get; init; }

        /// <summary>
        /// Gets frame rate of video stream.
        /// </summary>
        [JsonPropertyName("r_frame_rate")]
        public string FrameRate { get; init; }

        /// <summary>
        /// Gets average frame rate of video stream.
        /// </summary>
        [JsonPropertyName("avg_frame_rate")]
        public string AverageFrameRate { get; init; }

        /// <summary>
        /// Gets stream duration.
        /// </summary>
        [JsonPropertyName("duration")]
        public string Duration { get; init; }

        /// <summary>
        /// Gets stream frame count.
        /// </summary>
        [JsonPropertyName("nb_frames")]
        public long FrameCount { get; init; }
    }
}