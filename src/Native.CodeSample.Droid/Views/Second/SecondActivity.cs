using Android.OS;
using Android.App;

using MvvmCross.Platforms.Android.Presenters.Attributes;

using Native.CodeSample.Droid.Views.Base;
using Native.CodeSample.Core.ViewModels.Second;

namespace Native.CodeSample.Droid.Views.Second
{
    [MvxActivityPresentation]
    [Activity(Theme = "@style/AppTheme")]
    public sealed class SecondActivity : BaseActivity<SecondViewModel>
    {
        protected override int LayoutId => Resource.Layout.second;

        protected override async void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            InitializeView();
            await ViewModel.InitTabsCommand.ExecuteAsync();
        }
    }
}
