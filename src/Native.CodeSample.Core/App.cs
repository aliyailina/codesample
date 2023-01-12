using MvvmCross.IoC;
using MvvmCross.ViewModels;

using Native.CodeSample.Core.ViewModels;

namespace Native.CodeSample.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<FirstViewModel>();
        }
    }
}
