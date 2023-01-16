using Microsoft.Extensions.Logging;

using MvvmCross.Navigation;

using Native.CodeSample.Core.ViewModels.Base;
using Native.CodeSample.Core.Services.ToastPresenter;

namespace Native.CodeSample.Core.ViewModels.Second
{
    /// <summary>
    /// View model for second tab in <see cref="SecondViewModel"/>
    /// </summary>
    public sealed class SecondTabViewModel : BaseViewModel
    {
        /// <summary>
        /// Initializes a new instance of <see cref="SecondTabViewModel"/> class
        /// </summary>
        public SecondTabViewModel(ILoggerFactory loggerFactory, IMvxNavigationService navigationService,
            IToastPresenter toastPresenter) : base(loggerFactory, navigationService, toastPresenter)
        { }
    }
}
