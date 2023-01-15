using MvvmCross;
using MvvmCross.IoC;
using MvvmCross.Plugin;
using MvvmCross.ViewModels;
using MvvmCross.Localization;
using MvvmCross.Plugin.ResxLocalization;

using Native.CodeSample.Core.Localization;
using Native.CodeSample.Core.ViewModels.First;

using Native.CodeSample.Core.Services.InputValidator;

namespace Native.CodeSample.Core
{
    public class App : MvxApplication
    {
        private IMvxIoCProvider _provider;
        private IMvxIoCProvider Provider => _provider
            ??= Mvx.IoCProvider;

        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            Provider.LazyConstructAndRegisterSingleton<IInputValidator, InputValidator>();

            RegisterAppStart<FirstViewModel>();
        }

        public override void LoadPlugins(IMvxPluginManager pluginManager)
        {
            Provider.RegisterSingleton<IMvxTextProvider>(new MvxResxTextProvider(Resources.ResourceManager));

            base.LoadPlugins(pluginManager);
        }
    }
}
