using MvvmCross.Platforms.Ios.Views;
using Native.CodeSample.Core.ViewModels;

namespace Native.CodeSample.iOS.Views
{
    public abstract class BaseViewController<TViewModel> : MvxViewController<TViewModel>
        where TViewModel : BaseViewModel
    { }
}
