using Android.OS;
using Android.Views;
using Android.Widget;
using Android.Runtime;

using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Android.Binding;
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
        Title = "Tab 1")]
    [Register(nameof(FirstTabFragment))]
    public sealed class FirstTabFragment : BaseFragment<FirstTabViewModel>
    {
        private TextView _firstTextView;
        private TextView _secondTextView;

        protected override int LayoutId => Resource.Layout.first_tab;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);
            return InitializeView();
        }

        protected override void CreateBindings(
            MvxFluentBindingDescriptionSet<IMvxFragmentView<FirstTabViewModel>, FirstTabViewModel> set)
        {
            set.Bind(_firstTextView)
                .For(v => v.BindText())
                .To(vm => vm.PreviousFirstText);

            set.Bind(_secondTextView)
                .For(v => v.BindText())
                .To(vm => vm.PreviousSecondText);

            set.Apply();
        }

        protected override void FindViews(View view)
        {
            _firstTextView = view.FindViewById<TextView>(Resource.Id.first_text_view);
            _secondTextView = view.FindViewById<TextView>(Resource.Id.second_text_view);
        }
    }
}
