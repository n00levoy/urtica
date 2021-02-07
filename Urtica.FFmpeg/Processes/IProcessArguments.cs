namespace Urtica.FFmpeg.Processes
{
    /// <summary>
    /// Common process parameters contract.
    /// </summary>
    public interface IProcessArguments
    {
        /// <summary>
        /// Yields list of arguments in form of string to pass for process execution.
        /// </summary>
        /// <returns>List of arguments as string.</returns>
        string ToArgumentsList();
    }
}