using System;

using Foundation;

using MvvmCross.ViewModels;
using MvvmCross.Platforms.Ios.Views;
using MvvmCross.Platforms.Ios.Binding;
using MvvmCross.Binding.BindingContext;

using Native.CodeSample.Core.ViewModels.First;

namespace Native.CodeSample.iOS.Views.First
{
    [Register(nameof(FirstViewController))]
    public sealed partial class FirstViewController : BaseViewController<FirstViewModel>
    {
        private MvxInteraction _invalidInputInteraction;
        public MvxInteraction InvalidInputInteraction
        {
            get => _invalidInputInteraction;
            set
            {
                if (_invalidInputInteraction != null)
                    _invalidInputInteraction.Requested -= OnInvalidInput;

                _invalidInputInteraction = value;
                _invalidInputInteraction.Requested += OnInvalidInput;
            }
        }

        protected override void CreateBindings(
            MvxFluentBindingDescriptionSet<IMvxIosView<FirstViewModel>, FirstViewModel> set)
        {
            set.Bind(FirstTextField)
                .For(v => v.BindText())
                .To(vm => vm.FirstText);

            set.Bind(SecondTextField)
                .For(v => v.BindText())
                .To(vm => vm.SecondText);

            set.Bind(Button)
                .For(v => v.BindTouchUpInside())
                .To(vm => vm.GoCommand);

            set.Bind(Button)
                .For(v => v.BindTitle())
                .ToLocalizationId("ButtonTitle");

            set.Bind(this)
                .For(v => v.InvalidInputInteraction)
                .To(vm => vm.InvalidInputInteraction)
                .OneWay();

            set.Apply();
        }

        private void OnInvalidInput(object sender, EventArgs e)
        {
            // TODO: trigger input shake animation
        }
    }
}

