using System.Windows.Input;
using System.Threading.Tasks;

using Microsoft.Extensions.Logging;

using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

using Native.CodeSample.Core.Services.Items;
using Native.CodeSample.Core.ViewModels.Base;
using Native.CodeSample.Core.ViewModels.Second.Tabs;
using Native.CodeSample.Core.Services.ToastPresenter;

namespace Native.CodeSample.Core.ViewModels.Second
{
    /// <summary>
    /// View model for second page
    /// </summary>
    public sealed class SecondViewModel : BaseSecondViewModel, IMvxViewModel<SecondNavigationParameter>
    {
        private SecondNavigationParameter _previousPageTexts;

        private IMvxAsyncCommand _initTabsCommand;
        /// <summary>
        /// Initializes tab subpages
        /// </summary>
        public IMvxAsyncCommand InitTabsCommand => _initTabsCommand
            ??= new MvxAsyncCommand(InitTabsCommandExecute);

        /// <summary>
        /// Initializes a new instance of <see cref="SecondViewModel"/> class
        /// </summary>
        public SecondViewModel(ILoggerFactory loggerFactory, IMvxNavigationService navigationService,
            IToastPresenter toastPresenter, IItemsCollector itemsCollector) : base(loggerFactory, navigationService,
            toastPresenter, itemsCollector)
        { }

        public void Prepare(SecondNavigationParameter parameter) =>
            _previousPageTexts = parameter;

        private async Task InitTabsCommandExecute() =>
            await Task.WhenAll(
                NavigationService.Navigate<FirstTabViewModel, SecondNavigationParameter>(_previousPageTexts),
                NavigationService.Navigate<SecondTabViewModel>());
    }
}
