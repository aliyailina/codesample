using GlobalToast;

using Native.CodeSample.Core.Services.ToastPresenter;

namespace Native.CodeSample.iOS.Services.ToastPresenter
{
    /// <summary>
    /// <see cref="IToastPresenter"/> implementation
    /// </summary>
    public sealed class ToastPresenter : IToastPresenter
    {
        /// <inheritdoc cref="IToastPresenter.Show"/>
        public void Show(string text) =>
            Toast.ShowToast(text);
    }
}
