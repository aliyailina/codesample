using System;

using Foundation;

using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Binding;
using MvvmCross.Platforms.Ios.Binding.Views;
using Native.CodeSample.Core.Services.Items;

namespace Native.CodeSample.iOS.Views.Second.ItemCell
{
    /// <summary>
    /// Cell for table in tab view controllers
    /// </summary>
    [Register(nameof(ItemCell))]
    public partial class ItemCell : MvxTableViewCell
    {
        /// <summary>
        /// Item cell name key
        /// </summary>
        public static readonly NSString Key = new(nameof(ItemCell));

        /// <summary>
        /// Initializes a new instance of <see cref="ItemCell"/> class
        /// </summary>
        public ItemCell(IntPtr handle) : base(handle)
        {
            this.DelayBind(() =>
            {
                var set = this.CreateBindingSet<ItemCell, Item>();
                set.Bind(FirstLabel)
                    .For(v => v.BindText())
                    .To(vm => vm.FirstText)
                    .OneWay();

                set.Bind(SecondLabel)
                    .For(v => v.BindText())
                    .To(vm => vm.SecondText)
                    .OneWay();

                set.Bind(Picture)
                    .For(v => v.BindVisible())
                    .To(vm => vm.ShowIcon);

                set.Apply();
            });
        }
    }
}
