using MvvmCross.ViewModels;

namespace Native.CodeSample.Core.Services.Items
{
    /// <summary>
    /// <see cref="IItemsCollector"/> implementation
    /// </summary>
    public sealed class ItemsCollector : IItemsCollector
    {
        /// <inheritdoc cref="IItemsCollector.Items"/>
        public MvxObservableCollection<Item> Items { get; } = new();
    }
}
