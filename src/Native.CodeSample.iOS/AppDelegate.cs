using Foundation;

using MvvmCross.Platforms.Ios.Core;

using Native.CodeSample.Core;

namespace Native.CodeSample.iOS
{
    [Register(nameof(AppDelegate))]
    public class AppDelegate : MvxApplicationDelegate<Setup, App>
    { }
}
