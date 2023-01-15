﻿using Foundation;

using MvvmCross.Platforms.Ios.Core;

using Native.CodeSample.Core;

using UIKit;

namespace Native.CodeSample.iOS
{
    [Register(nameof(AppDelegate))]
    public class AppDelegate : MvxApplicationDelegate<Setup, App>
    {
        public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {
            var result = base.FinishedLaunching(application, launchOptions);

            UIButton.Appearance.BackgroundColor = UIColor.Label;
            UIButton.Appearance.SetTitleColor(UIColor.SystemBackground, UIControlState.Normal);

            UITextField.Appearance.TintColor = UIColor.Label;
            UITextField.Appearance.BackgroundColor = UIColor.SystemBackground;

            return result;
        }
    }
}
