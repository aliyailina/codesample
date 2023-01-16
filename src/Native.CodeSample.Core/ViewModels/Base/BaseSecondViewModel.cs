using Microsoft.Extensions.Logging;

using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

using Native.CodeSample.Core.Services.Items;
using Native.CodeSample.Core.Services.ToastPresenter;

namespace Native.CodeSample.Core.ViewModels.Base
{
    /// <summary>
    /// Base class for second page subpages
    /// </summary>
    public abstract class BaseSecondViewModel : BaseViewModel
    {
        private readonly IItemsCollector _itemsCollector;

        /// <summary>
        /// Collection of <see cref="Item"/>
        /// </summary>
        public MvxObservableCollection<Item> Items => _itemsCollector.Items;

        private bool _showIcons;
        /// <summary>
        /// Determines whether to show icon for items in <see cref="Items"/>
        /// </summary>
        public bool ShowIcons
        {
            get => _showIcons;
            set
            {
                _showIcons = value;
                foreach (var item in Items)
                    item.ShowIcon = _showIcons;
            }
        }

        private IMvxCommand _addItemCommand;
        /// <summary>
        /// Adds <see cref="Item"/> to <see cref="Items"/>
        /// </summary>
        public IMvxCommand AddItemCommand => _addItemCommand
            ??= new MvxCommand(AddItemCommandExecute);

        private IMvxCommand _removeFirstItemCommand;
        /// <summary>
        /// Remove first <see cref="Item"/> from <see cref="Items"/>
        /// </summary>
        public IMvxCommand RemoveFirstItemCommand => _removeFirstItemCommand
            ??= new MvxCommand(RemoveFirstItemCommandExecute);

        /// <summary>
        /// Initializes a new instance of <see cref="BaseSecondViewModel"/> inheritor
        /// </summary>
        protected BaseSecondViewModel(ILoggerFactory loggerFactory, IMvxNavigationService navigationService,
            IToastPresenter toastPresenter, IItemsCollector itemsCollector) : base(loggerFactory, navigationService,
            toastPresenter)
        {
            _itemsCollector = itemsCollector;
        }

        private void AddItemCommandExecute()
        {
            Items.Add(new Item());
            RaisePropertyChanged(() => Items);
        }

        private void RemoveFirstItemCommandExecute()
        {
            var items = Items;
            if(items.Count > 0)
            {
                items.RemoveAt(0);

                // TODO: add Fody
                RaisePropertyChanged(nameof(Items));
            }
        }
    }
}
