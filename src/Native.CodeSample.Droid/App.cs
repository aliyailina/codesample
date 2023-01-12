using System;

using Android.App;
using Android.Runtime;

using MvvmCross.Platforms.Android.Views;

namespace Native.CodeSample.Droid
{
    #if DEBUG
    [Application(Debuggable = true)]
#else
    [Application(Debuggable = false)]
#endif
        public class App : MvxAndroidApplication<Setup, Core.App>
    {
        public App(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }
    }
}
