namespace Urtica.FFmpeg.Processes.Probing
{
    /// <summary>
    /// Describes a probe process output format.
    /// </summary>
    public enum ProbeOutputFormat
    {
        /// <summary>
        /// Default output format. Similar to bb-codes.
        /// Print each section in the form:
        /// <code>
        /// [SECTION]
        /// key1=val1
        ///    ...
        /// keyN=valN
        /// [/SECTION]
        /// </code>
        /// </summary>
        Default,

        /// <summary>
        /// Compact output format. Each section is printed on a single line. The output has the form:
        /// <code>section|key1=val1| ... |keyN=valN</code>
        /// </summary>
        Compact,

        /// <summary>
        /// Csv output format. Each section is printed on a single line. The output has the form:
        /// <code>section,key1=val1, ... ,keyN=valN</code>
        /// </summary>
        Csv,

        /// <summary>
        /// Flat output format. A free-form output where each line contains an explicit key=value,
        /// such as "streams.stream.3.tags.foo=bar".
        /// </summary>
        Flat,

        /// <summary>
        /// ini output format.
        /// </summary>
        Ini,

        /// <summary>
        /// JSON output format.
        /// </summary>
        Json,

        /// <summary>
        /// XML output format.
        /// </summary>
        Xml,
    }
}