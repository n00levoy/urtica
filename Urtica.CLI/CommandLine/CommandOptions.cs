namespace Urtica.CLI;

using System.IO;

/// <summary>
/// Command arguments set.
/// </summary>
public class CommandOptions
{
    /// <summary>
    /// Gets an input media file path.
    /// </summary>
    public FileInfo[] Input { get; private set; }

    /// <summary>
    /// Gets a directory path to output frames to.
    /// </summary>
    public DirectoryInfo OutputDirectory { get; private set; }

    /// <summary>
    /// Gets an output filename template.
    /// Use placeholder {num} to insert frame sequence number.
    /// Use placeholder {time} to insert frame time value.
    /// </summary>
    public string OutputTemplate { get; private set; }

    /// <summary>
    /// Gets a frame set size to select most meaningful frame from.
    /// Has priority over Interval and TargetFrames option.
    /// </summary>
    public int? FrameSet { get; private set; }

    /// <summary>
    /// Gets a time interval for frames to select most meaningful frame from.
    /// Has priority over TargetFrames option.
    /// </summary>
    public float? Interval { get; private set; }

    /// <summary>
    /// Gets a target frames count.
    /// </summary>
    public int? TargetFrames { get; private set; }

    /// <summary>
    /// Gets a start time point to take frame samples from.
    /// </summary>
    public float? StartOffset { get; private set; }
}