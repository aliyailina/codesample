using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using MvvmCross.Localization;

using Native.CodeSample.Core.Services.ToastPresenter;

namespace Native.CodeSample.Core.ViewModels.Base
{
    /// <summary>
    /// Base class for view models
    /// </summary>
    public abstract class BaseViewModel : MvxViewModel, IMvxLocalizedTextSourceOwner
    {
        protected readonly IMvxNavigationService NavigationService;
        protected readonly IToastPresenter ToastPresenter;

        /// <inheritdoc cref="IMvxLocalizedTextSourceOwner.LocalizedTextSource"/>
        public IMvxLanguageBinder LocalizedTextSource { get; }

        /// <summary>
        /// Initializes a new instance of <see cref="BaseViewModel"/> inheritor
        /// </summary>
        protected BaseViewModel(IMvxNavigationService navigationService, IToastPresenter toastPresenter)
        {
            NavigationService = navigationService;
            ToastPresenter = toastPresenter;
            LocalizedTextSource = new MvxLanguageBinder(string.Empty, GetType().Name);
        }
    }
}
