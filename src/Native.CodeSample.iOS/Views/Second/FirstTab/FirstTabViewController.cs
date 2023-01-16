using UIKit;
using Foundation;

using MvvmCross.Platforms.Ios.Views;
using MvvmCross.Platforms.Ios.Binding;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Presenters.Attributes;

using Native.CodeSample.Core.ViewModels.Second;

namespace Native.CodeSample.iOS.Views.Second.FirstTab
{
    [MvxTabPresentation(TabName = "Tab 1")]
    [Register(nameof(FirstTabViewController))]
    public partial class FirstTabViewController : BaseTabViewController<FirstTabViewModel>
    {
        protected override UITableView TableView => ItemsTable;

        protected override void CreateBindings(
            MvxFluentBindingDescriptionSet<IMvxIosView<FirstTabViewModel>, FirstTabViewModel> set)
        {
            base.CreateBindings(set);

            set.Bind(FirstLabel)
                .For(v => v.BindText())
                .To(vm => vm.PreviousFirstText)
                .OneWay();

            set.Bind(SecondLabel)
                .For(v => v.BindText())
                .To(vm => vm.PreviousSecondText)
                .OneWay();

            set.Apply();
        }
    }
}

