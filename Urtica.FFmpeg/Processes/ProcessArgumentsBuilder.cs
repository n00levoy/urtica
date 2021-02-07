namespace Urtica.FFmpeg.Processes
{
    using System.Text;

    /// <summary>
    /// Helps building a process arguments list.
    /// </summary>
    public class ProcessArgumentsBuilder
    {
        private readonly StringBuilder stringBuilder = new();

        private int parametersCount;

        /// <summary>
        /// Adds a key-only element to the arguments list.
        /// </summary>
        /// <param name="key">Key-only argument.</param>
        /// <returns>Returns an instance of this builder with the added argument.</returns>
        public ProcessArgumentsBuilder AddKeyArgument(string key)
        {
            this.AddSeparatorIfNeeded();
            this.stringBuilder.AppendFormat("-{0}", key);

            ++this.parametersCount;
            return this;
        }

        /// <summary>
        /// Add a value-only element to the arguments list.
        /// </summary>
        /// <param name="value">Value-only argument.</param>
        /// <returns>Returns an instance of this builder with the added argument.</returns>
        public ProcessArgumentsBuilder AddValueArgument(string value)
        {
            this.AddSeparatorIfNeeded();
            this.stringBuilder.Append(value);

            ++this.parametersCount;
            return this;
        }

        /// <summary>
        /// Adds a key-value pair element to the arguments list.
        /// </summary>
        /// <param name="key">Argument key.</param>
        /// <param name="value">Argument value.</param>
        /// <returns>Returns an instance of this builder with the added argument.</returns>
        public ProcessArgumentsBuilder AddKeyValuePair(string key, string value)
        {
            this.AddSeparatorIfNeeded();
            this.stringBuilder.AppendFormat("-{0} {1}", key, value);

            ++this.parametersCount;
            return this;
        }

        /// <inheritdoc/>
        public override string ToString() => this.stringBuilder.ToString();

        private void AddSeparatorIfNeeded()
        {
            if (this.parametersCount > 0)
            {
                this.stringBuilder.Append(' ');
            }
        }
    }
}