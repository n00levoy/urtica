namespace Urtica.FFmpeg.Processes
{
    /// <summary>
    /// Common process parameters contract.
    /// </summary>
    public interface IProcessArguments
    {
        /// <summary>
        /// Yields a list of the arguments in the form of a string to pass for the process execution.
        /// </summary>
        /// <returns>List of the arguments as a string.</returns>
        string ToArgumentsList();
    }
}