using System.Windows.Input;
using System.Threading.Tasks;

using Microsoft.Extensions.Logging;

using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

using Native.CodeSample.Core.ViewModels.Base;
using Native.CodeSample.Core.Services.ToastPresenter;

namespace Native.CodeSample.Core.ViewModels.Second
{
    /// <summary>
    /// View model for second page
    /// </summary>
    public sealed class SecondViewModel : BaseViewModel, IMvxViewModel<SecondNavigationParameter>
    {
        private SecondNavigationParameter _previousPageTexts;

        private ICommand _initTabsCommand;
        /// <summary>
        /// Initializes tab subpages
        /// </summary>
        public ICommand InitTabsCommand => _initTabsCommand
            ??= new MvxAsyncCommand(InitTabsCommandExecute);

        /// <summary>
        /// Initializes a new instance of <see cref="SecondViewModel"/> class
        /// </summary>
        public SecondViewModel(ILoggerFactory loggerFactory, IMvxNavigationService navigationService,
            IToastPresenter toastPresenter) : base(loggerFactory, navigationService, toastPresenter)
        { }

        public void Prepare(SecondNavigationParameter parameter) =>
            _previousPageTexts = parameter;

        private async Task InitTabsCommandExecute() =>
            await Task.WhenAll(
                NavigationService.Navigate<FirstTabViewModel, SecondNavigationParameter>(_previousPageTexts),
                NavigationService.Navigate<SecondTabViewModel>());
    }
}
