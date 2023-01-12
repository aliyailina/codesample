using Android.App;
using Android.OS;
using MvvmCross.Platforms.Android.Views;
using Native.CodeSample.Core.ViewModels;

namespace Native.CodeSample.Droid.Views
{
    [Activity(
        NoHistory = true,
        MainLauncher = true,
        Label = "@string/app_name",
        Icon = "@mipmap/ic_launcher")]
    public sealed class FirstActivity : MvxActivity<FirstViewModel>
    { }
}
