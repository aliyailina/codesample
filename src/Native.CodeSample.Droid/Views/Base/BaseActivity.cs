using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Android.Views;

using Native.CodeSample.Core.ViewModels.Base;

namespace Native.CodeSample.Droid.Views.Base
{
    /// <summary>
    /// Base activity for app
    /// </summary>
    public abstract class BaseActivity<TViewModel> : MvxActivity<TViewModel>
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
            MvxFluentBindingDescriptionSet<IMvxAndroidView<TViewModel>, TViewModel> set)
        { }

        /// <summary>
        /// Initializes activity specific view variables
        /// </summary>
        protected virtual void FindViews()
        { }

        /// <summary>
        /// Initializes view
        /// </summary>
        /// <remarks>
        /// You should to call it manually, as sometimes some preparations need before or after
        /// </remarks>
        protected void InitializeView()
        {
            SetContentView(LayoutId);
            FindViews();
            CreateBindings(CreateBindingSet());
        }
    }
}
