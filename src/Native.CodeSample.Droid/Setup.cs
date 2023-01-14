using Microsoft.Extensions.Logging;

using MvvmCross.IoC;
using MvvmCross.Platforms.Android.Core;

using Native.CodeSample.Core.Services.ToastPresenter;
using Native.CodeSample.Droid.Services.ToastPresenter;

using Serilog;
using Serilog.Extensions.Logging;

namespace Native.CodeSample.Droid
{
    public class Setup : MvxAndroidSetup<Core.App>
    {
        protected override ILoggerProvider CreateLogProvider() => new SerilogLoggerProvider();

        protected override ILoggerFactory CreateLogFactory()
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.AndroidLog()
                .CreateLogger();

            return new SerilogLoggerFactory();
        }

        protected override void InitializeFirstChance(IMvxIoCProvider provider)
        {
            provider.LazyConstructAndRegisterSingleton<IToastPresenter, ToastPresenter>();
        }
    }
}
