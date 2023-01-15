using Android.Widget;

using Native.CodeSample.Core.Services.ToastPresenter;

using Xamarin.Essentials;

namespace Native.CodeSample.Droid.Services.ToastPresenter
{
    /// <summary>
    /// <see cref="IToastPresenter"/> implementation
    /// </summary>
    public sealed class ToastPresenter : IToastPresenter
    {
        /// <inheritdoc cref="IToastPresenter.Show"/>
        public void Show(string text) =>
            Toast.MakeText(Platform.CurrentActivity, text, ToastLength.Short)!.Show();
    }
}
