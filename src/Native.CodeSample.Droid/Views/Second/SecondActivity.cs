using Android.OS;
using Android.App;

using MvvmCross.DroidX.RecyclerView;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Android.Views;
using MvvmCross.Platforms.Android.Presenters.Attributes;

using Native.CodeSample.Droid.Views.Base;
using Native.CodeSample.Core.ViewModels.Second;

namespace Native.CodeSample.Droid.Views.Second
{
    [MvxActivityPresentation]
    [Activity(Theme = "@style/AppTheme")]
    public sealed class SecondActivity : BaseActivity<SecondViewModel>
    {
        private MvxRecyclerView _list;

        protected override int LayoutId => Resource.Layout.second;

        protected override async void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            InitializeView();
            await ViewModel.InitTabsCommand.ExecuteAsync();
        }

        protected override void FindViews()
        {
            _list = FindViewById<MvxRecyclerView>(Resource.Id.list);
        }

        protected override void CreateBindings(
            MvxFluentBindingDescriptionSet<IMvxAndroidView<SecondViewModel>, SecondViewModel> set)
        {
            set.Bind(_list)
                .For(v => v.ItemsSource)
                .To(vm => vm.Items)
                .OneWay();

            set.Apply();
        }
    }
}
