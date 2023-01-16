using Foundation;

using MvvmCross.Platforms.Ios.Views;
using MvvmCross.Platforms.Ios.Presenters.Attributes;

using Native.CodeSample.Core.ViewModels.Second;

namespace Native.CodeSample.iOS.Views.Second
{
    [MvxRootPresentation]
    [Register(nameof(SecondViewController))]
    public sealed class SecondViewController : MvxTabBarViewController<SecondViewModel>
    {
        private bool _tabsInitialized;

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            NavigationItem.SetHidesBackButton(true, false);
        }

        public override async void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            if (!_tabsInitialized)
            {
                await ViewModel.InitTabsCommand.ExecuteAsync();
                _tabsInitialized = true;
            }
        }
    }
}
