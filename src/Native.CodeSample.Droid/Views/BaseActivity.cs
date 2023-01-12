using MvvmCross.Platforms.Android.Views;

using Native.CodeSample.Core.ViewModels;

namespace Native.CodeSample.Droid.Views
{
    public abstract class BaseActivity<TViewModel> : MvxActivity<TViewModel>
        where TViewModel : BaseViewModel
    { }
}
