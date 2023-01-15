using Android.App;

using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Android.Views;

using Native.CodeSample.Core.ViewModels.Second;

namespace Native.CodeSample.Droid.Views
{
    [Activity(Theme = "@style/AppTheme")]
    public sealed class SecondActivity : BaseActivity<SecondViewModel>
    {
        protected override int LayoutId => Resource.Layout.second;

        protected override void CreateBindings(
            MvxFluentBindingDescriptionSet<IMvxAndroidView<SecondViewModel>, SecondViewModel> set)
        { }

        protected override void FindViews()
        { }
    }
}
