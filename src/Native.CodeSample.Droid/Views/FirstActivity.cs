using Android.OS;
using Android.App;

using MvvmCross.Platforms.Android.Views;

using Native.CodeSample.Core.ViewModels;

using Xamarin.Essentials;

namespace Native.CodeSample.Droid.Views
{
    [Activity(
        NoHistory = true,
        MainLauncher = true,
        Theme = "@style/AppTheme.Splash",
        Label = "@string/app_name",
        Icon = "@mipmap/ic_launcher")]
    public sealed class FirstActivity : MvxActivity<FirstViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Platform.Init(this, savedInstanceState);
            AndroidX.Core.SplashScreen.SplashScreen.InstallSplashScreen(this);
        }
    }
}
