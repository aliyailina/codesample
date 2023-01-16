using Microsoft.Extensions.Logging;

using MvvmCross.Navigation;
using MvvmCross.ViewModels;

using Native.CodeSample.Core.ViewModels.Base;
using Native.CodeSample.Core.Services.ToastPresenter;

namespace Native.CodeSample.Core.ViewModels.Second
{
    /// <summary>
    /// View model for first tab in <see cref="SecondViewModel"/>
    /// </summary>
    public sealed class FirstTabViewModel : BaseViewModel, IMvxViewModel<SecondNavigationParameter>
    {
        /// <summary>
        /// Shows <see cref="First.FirstViewModel.FirstText"/>
        /// </summary>
        public string PreviousFirstText { get; private set; }

        /// <summary>
        /// Shows <see cref="First.FirstViewModel.SecondText"/>
        /// </summary>
        public string PreviousSecondText { get; private set; }

        /// <summary>
        /// Initializes a new instance of <see cref="FirstTabViewModel"/> class
        /// </summary>
        public FirstTabViewModel(ILoggerFactory loggerFactory, IMvxNavigationService navigationService,
            IToastPresenter toastPresenter) : base(loggerFactory, navigationService, toastPresenter)
        { }

        public void Prepare(SecondNavigationParameter parameter)
        {
            PreviousFirstText = parameter.FirstText;
            PreviousSecondText = parameter.SecondText;
        }
    }
}
