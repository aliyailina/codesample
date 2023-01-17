using MvvmCross.Platforms.Ios.Views;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Binding.Views;

using Native.CodeSample.Core.ViewModels.Base;

using UIKit;

namespace Native.CodeSample.iOS.Views.Second
{
    /// <summary>
    /// Base class for tabs view controllers
    /// </summary>
    public abstract class BaseTabViewController<TViewModel> : BaseViewController<TViewModel>
        where TViewModel : BaseSecondViewModel
    {
        private MvxSimpleTableViewSource _source;

        /// <summary>
        /// Table view in tab
        /// </summary>
        protected abstract UITableView TableView { get; }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            NavigationItem.SetHidesBackButton(true, false);
            InitTable();
        }

        protected override void CreateBindings(MvxFluentBindingDescriptionSet<IMvxIosView<TViewModel>, TViewModel> set)
        {
            _source = new MvxSimpleTableViewSource(TableView, ItemCell.ItemCell.Key, ItemCell.ItemCell.Key);
            set.Bind(_source)
                .For(v => v.ItemsSource)
                .To(vm => vm.Items);

            set.Bind(this)
                .For(v => v.Title)
                .ToLocalizationId("TabTitle");
        }

        private void InitTable()
        {
            TableView.Source = _source;
            TableView.ReloadData();
        }
    }
}
