using MvvmCross;
using MvvmCross.IoC;
using MvvmCross.ViewModels;

using Native.CodeSample.Core.ViewModels;

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
    }
}
