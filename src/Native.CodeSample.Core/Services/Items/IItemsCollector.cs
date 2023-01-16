using MvvmCross.ViewModels;

namespace Native.CodeSample.Core.Services.Items
{
    /// <summary>
    /// Collects <see cref="Item"/>
    /// </summary>
    public interface IItemsCollector
    {
        /// <summary>
        /// Collection of <see cref="Item"/>
        /// </summary>
        public MvxObservableCollection<Item> Items { get; }
    }
}
