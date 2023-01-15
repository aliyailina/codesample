using Microsoft.Extensions.Logging;

using MvvmCross.Navigation;
using MvvmCross.ViewModels;

using Native.CodeSample.Core.ViewModels.Base;
using Native.CodeSample.Core.Services.ToastPresenter;

namespace Native.CodeSample.Core.ViewModels.Second
{
    public sealed class SecondViewModel : BaseViewModel, IMvxViewModel<SecondNavigationParameter>
    {
        private string _previousPageFirstText;
        private string _previousPageSecondText;

        public SecondViewModel(ILoggerFactory loggerFactory, IMvxNavigationService navigationService,
            IToastPresenter toastPresenter) : base(loggerFactory, navigationService, toastPresenter)
        { }

        public void Prepare(SecondNavigationParameter parameter)
        {
            _previousPageFirstText = parameter.FirstText;
            _previousPageSecondText = parameter.SecondText;
        }
    }
}
