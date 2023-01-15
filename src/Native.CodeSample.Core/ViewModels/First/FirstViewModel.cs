using System.Threading.Tasks;

using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

using Native.CodeSample.Core.ViewModels.Base;
using Native.CodeSample.Core.ViewModels.Second;
using Native.CodeSample.Core.Services.InputValidator;
using Native.CodeSample.Core.Services.ToastPresenter;

namespace Native.CodeSample.Core.ViewModels.First
{
    /// <summary>
    /// The view model for first page
    /// </summary>
    public sealed class FirstViewModel : BaseViewModel
    {
        private readonly IInputValidator _inputValidator;

        /// <summary>
        /// Text from first input field
        /// </summary>
        public string FirstText { get; set; }

        /// <summary>
        /// Text from second input field
        /// </summary>
        public string SecondText { get; set; }

        private MvxInteraction _invalidInputInteraction;
        /// <summary>
        /// Interaction that triggers view to notify use about invalid input
        /// </summary>
        public MvxInteraction InvalidInputInteraction =>
            _invalidInputInteraction ??= new MvxInteraction();

        private IMvxCommand _goToSecondCommand;
        /// <summary>
        /// Navigates user to next page
        /// </summary>
        public IMvxCommand GoCommand => _goToSecondCommand
            ??= new MvxAsyncCommand(GoToSecondCommandExecute);

        /// <summary>
        /// Initializes a new instance of <see cref="FirstViewModel"/> class
        /// </summary>
        public FirstViewModel(IMvxNavigationService navigationService, IToastPresenter toastPresenter,
            IInputValidator inputValidator) : base(navigationService, toastPresenter)
        {
            _inputValidator = inputValidator;
        }

        private async Task GoToSecondCommandExecute()
        {
            var canNavigate = _inputValidator.IsValid(FirstText) && _inputValidator.IsValid(SecondText);
            if (canNavigate)
                await NavigationService.Navigate<SecondViewModel, SecondNavigationParameter>(
                    new SecondNavigationParameter(FirstText, SecondText));
            else
            {
                InvalidInputInteraction.Raise();
                ToastPresenter.Show(LocalizedTextSource.GetText("InputInvalidMessage"));
            }
        }
    }
}
