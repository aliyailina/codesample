using Android.OS;
using Android.Views;
using Android.Widget;
using Android.Runtime;

using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Android.Views;
using MvvmCross.Platforms.Android.Binding;
using MvvmCross.Platforms.Android.Presenters.Attributes;

using Native.CodeSample.Droid.Views.Base;
using Native.CodeSample.Core.ViewModels.Second;
using Native.CodeSample.Core.ViewModels.Second.Tabs;

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
        private Switch _switch;
        private Button _firstButton;
        private Button _secondButton;

        protected override int LayoutId => Resource.Layout.second_tab;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);
            return InitializeView();
        }

        protected override void FindViews(View view)
        {
            _switch = view.FindViewById<Switch>(Resource.Id.switch_control);
            _firstButton = view.FindViewById<Button>(Resource.Id.first_button);
            _secondButton = view.FindViewById<Button>(Resource.Id.second_button);
        }

        protected override void CreateBindings(
            MvxFluentBindingDescriptionSet<IMvxFragmentView<SecondTabViewModel>, SecondTabViewModel> set)
        {
            set.Bind(_switch)
                .For(v => v.BindChecked())
                .To(vm => vm.ShowIcons);

            set.Bind(_firstButton)
                .For(v => v.BindText())
                .ToLocalizationId("FirstButtonTitle");

            set.Bind(_firstButton)
                .For(v => v.BindClick())
                .To(vm => vm.AddItemCommand);

            set.Bind(_secondButton)
                .For(vm => vm.BindText())
                .ToLocalizationId("SecondButtonTitle");

            set.Bind(_secondButton)
                .For(vm => vm.BindClick())
                .To(vm => vm.RemoveFirstItemCommand);

            set.Apply();
        }
    }
}
