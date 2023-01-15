namespace Native.CodeSample.Core.ViewModels.Second
{
    /// <summary>
    /// Navigation parameter for <see cref="SecondNavigationParameter"/>
    /// </summary>
    public struct SecondNavigationParameter
    {
        /// <summary>
        /// First field text from <see cref="First.FirstViewModel"/>
        /// </summary>
        public string FirstText { get; }

        /// <summary>
        /// Second field text from <see cref="First.FirstViewModel"/>
        /// </summary>
        public string SecondText { get; }

        /// <summary>
        /// Public initializes instance of <see cref="SecondNavigationParameter"/>
        /// </summary>
        public SecondNavigationParameter(string firstText, string secondText)
        {
            FirstText = firstText;
            SecondText = secondText;
        }
    }
}
