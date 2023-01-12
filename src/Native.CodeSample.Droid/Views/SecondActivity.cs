using Android.App;
using MvvmCross.Platforms.Android.Views;
using Native.CodeSample.Core.ViewModels;

namespace Native.CodeSample.Droid.Views
{
    [Activity(Theme = "@style/AppTheme")]
    public sealed class SecondActivity : MvxActivity<SecondViewModel>
    { }
}
