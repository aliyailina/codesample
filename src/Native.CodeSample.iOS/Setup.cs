using Microsoft.Extensions.Logging;

using MvvmCross.IoC;
using MvvmCross.Platforms.Ios.Core;

using Native.CodeSample.Core;

using Native.CodeSample.iOS.Services.ToastPresenter;
using Native.CodeSample.Core.Services.ToastPresenter;

using Serilog;
using Serilog.Extensions.Logging;

namespace Native.CodeSample.iOS
{
    public class Setup : MvxIosSetup<App>
    {
        protected override ILoggerProvider CreateLogProvider() => new SerilogLoggerProvider();

        protected override ILoggerFactory CreateLogFactory()
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.NSLog()
                .CreateLogger();

            return new SerilogLoggerFactory();
        }

        protected override void InitializeFirstChance(IMvxIoCProvider provider)
        {
            provider.LazyConstructAndRegisterSingleton<IToastPresenter, ToastPresenter>();
        }
    }
}
