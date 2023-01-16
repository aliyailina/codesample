using Microsoft.Extensions.Logging;

using MvvmCross.Navigation;

using Native.CodeSample.Core.ViewModels.Base;
using Native.CodeSample.Core.Services.Items;
using Native.CodeSample.Core.Services.ToastPresenter;

namespace Native.CodeSample.Core.ViewModels.Second.Tabs
{
    /// <summary>
    /// View model for second tab in <see cref="SecondViewModel"/>
    /// </summary>
    public sealed class SecondTabViewModel : BaseSecondViewModel
    {
        /// <summary>
        /// Initializes a new instance of <see cref="SecondTabViewModel"/> class
        /// </summary>
        public SecondTabViewModel(ILoggerFactory loggerFactory, IMvxNavigationService navigationService,
            IToastPresenter toastPresenter, IItemsCollector itemsCollector) : base(loggerFactory, navigationService,
            toastPresenter, itemsCollector)
        { }
    }
}
