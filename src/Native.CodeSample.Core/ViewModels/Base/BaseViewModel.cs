using Microsoft.Extensions.Logging;

using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using MvvmCross.Localization;

using Native.CodeSample.Core.Services.ToastPresenter;

namespace Native.CodeSample.Core.ViewModels.Base
{
    /// <summary>
    /// Base class for view models
    /// </summary>
    public abstract class BaseViewModel : MvxNavigationViewModel, IMvxLocalizedTextSourceOwner
    {
        protected readonly IToastPresenter ToastPresenter;

        /// <inheritdoc cref="MvxNavigationViewModel.NavigationService"/>
        protected override IMvxNavigationService NavigationService { get; }

        /// <inheritdoc cref="IMvxLocalizedTextSourceOwner.LocalizedTextSource"/>
        public IMvxLanguageBinder LocalizedTextSource { get; }

        /// <summary>
        /// Initializes a new instance of <see cref="BaseViewModel"/> inheritor
        /// </summary>
        protected BaseViewModel(ILoggerFactory loggerFactory, IMvxNavigationService navigationService,
            IToastPresenter toastPresenter) : base(loggerFactory, navigationService)
        {
            NavigationService = navigationService;
            ToastPresenter = toastPresenter;
            LocalizedTextSource = new MvxLanguageBinder(string.Empty, GetType().Name);
        }
    }
}
