using Android.Views;

using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Android.Views;
using MvvmCross.Platforms.Android.Views.Fragments;
using MvvmCross.Platforms.Android.Binding.BindingContext;

using Native.CodeSample.Core.ViewModels.Base;

namespace Native.CodeSample.Droid.Views.Base
{
    /// <summary>
    /// Base class for fragments in app
    /// </summary>
    public abstract class BaseFragment<TViewModel> : MvxFragment<TViewModel>
        where TViewModel : BaseViewModel
    {
        /// <summary>
        /// Id of layout for activity
        /// </summary>
        protected abstract int LayoutId { get; }

        /// <summary>
        /// Creates bindings
        /// </summary>
        protected virtual void CreateBindings(
            MvxFluentBindingDescriptionSet<IMvxFragmentView<TViewModel>, TViewModel> set)
        { }

        /// <summary>
        /// Initializes activity specific view variables
        /// </summary>
        protected virtual void FindViews(View view)
        { }

        /// <summary>
        /// Creates fragment view
        /// </summary>
        /// <remarks>
        /// You should to call it manually, as sometimes some preparations need before or after
        /// </remarks>
        protected View InitializeView()
        {
            var view = this.BindingInflate(LayoutId, null);
            FindViews(view);
            CreateBindings(CreateBindingSet());
            return view;
        }
    }
}
