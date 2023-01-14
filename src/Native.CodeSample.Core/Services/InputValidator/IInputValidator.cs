namespace Native.CodeSample.Core.Services.InputValidator
{
    /// <summary>
    /// Provides input fields validation
    /// </summary>
    public interface IInputValidator
    {
        /// <summary>
        /// Determines whether <paramref name="text"/> is valid
        /// </summary>
        public bool IsValid(string text);
    }
}
