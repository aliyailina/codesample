namespace Native.CodeSample.Core.Services.InputValidator
{
    /// <summary>
    /// <see cref="IInputValidator"/> implementation
    /// </summary>
    public sealed class InputValidator : IInputValidator
    {
        /// <inheritdoc cref="IInputValidator.IsValid"/>
        public bool IsValid(string text) =>
            !string.IsNullOrWhiteSpace(text);
    }
}
