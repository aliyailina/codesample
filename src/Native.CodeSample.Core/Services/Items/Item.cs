using MvvmCross.ViewModels;

namespace Native.CodeSample.Core.Services.Items
{
    /// <summary>
    /// Just item
    /// </summary>
    public sealed class Item : MvxNotifyPropertyChanged
    {
        /// <summary>
        /// Item's first text
        /// </summary>
        public string FirstText => "Random text 1";

        /// <summary>
        /// Item's second text
        /// </summary>
        public string SecondText => "Random text 2";

        // TODO: install Fody
        private bool _showIcon;
        /// <summary>
        /// Determines whether to show item's icon
        /// </summary>

        public bool ShowIcon
        {
            get => _showIcon;
            set => SetProperty(ref _showIcon, value);
        }
    }
}
