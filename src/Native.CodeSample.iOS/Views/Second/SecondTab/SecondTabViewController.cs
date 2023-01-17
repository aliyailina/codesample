using UIKit;
using Foundation;

using MvvmCross.Platforms.Ios.Views;
using MvvmCross.Platforms.Ios.Binding;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Presenters.Attributes;

using Native.CodeSample.Core.ViewModels.Second.Tabs;

namespace Native.CodeSample.iOS.Views.Second.SecondTab
{
    [MvxTabPresentation]
    [Register(nameof(SecondTabViewController))]
    public partial class SecondTabViewController : BaseTabViewController<SecondTabViewModel>
    {
        protected override UITableView TableView => ItemsTable;

        protected override void CreateBindings(
            MvxFluentBindingDescriptionSet<IMvxIosView<SecondTabViewModel>, SecondTabViewModel> set)
        {
            base.CreateBindings(set);

            set.Bind(Switch)
                .For(v => v.On)
                .To(vm => vm.ShowIcons);

            set.Bind(AddButton)
                .For(v => v.BindTitle())
                .ToLocalizationId("FirstButtonTitle");

            set.Bind(AddButton)
                .For(v => v.BindTouchUpInside())
                .To(vm => vm.AddItemCommand);

            set.Bind(RemoveFirstButton)
                .For(v => v.BindTitle())
                .ToLocalizationId("SecondButtonTitle");

            set.Bind(RemoveFirstButton)
                .For(v => v.BindTouchUpInside())
                .To(vm => vm.RemoveFirstItemCommand);

            set.Apply();
        }
    }
}

