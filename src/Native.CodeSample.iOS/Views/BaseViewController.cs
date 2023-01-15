using MvvmCross.Platforms.Ios.Views;
using MvvmCross.Binding.BindingContext;

using Native.CodeSample.Core.ViewModels.Base;

namespace Native.CodeSample.iOS.Views
{
    public abstract class BaseViewController<TViewModel> : MvxViewController<TViewModel>
        where TViewModel : BaseViewModel
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            NavigationItem.SetHidesBackButton(true, false);
            CreateBindings(CreateBindingSet());
        }

        protected abstract void CreateBindings(MvxFluentBindingDescriptionSet<IMvxIosView<TViewModel>, TViewModel> set);
    }
}
