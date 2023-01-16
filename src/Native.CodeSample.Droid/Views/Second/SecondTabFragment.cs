using Android.OS;
using Android.Views;
using Android.Runtime;

using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Android.Views;
using MvvmCross.Platforms.Android.Presenters.Attributes;

using Native.CodeSample.Droid.Views.Base;
using Native.CodeSample.Core.ViewModels.Second;

namespace Native.CodeSample.Droid.Views.Second
{
    [MvxTabLayoutPresentation(
        TabLayoutResourceId = Resource.Id.tabs,
        ViewPagerResourceId = Resource.Id.pager,
        ActivityHostViewModelType = typeof(SecondViewModel),

        // TODO: must be localized
        Title = "Tab 2")]
    [Register(nameof(SecondTabFragment))]
    public sealed class SecondTabFragment : BaseFragment<SecondTabViewModel>
    {
        protected override int LayoutId => Resource.Layout.second_tab;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);
            return InitializeView();
        }
    }
}
