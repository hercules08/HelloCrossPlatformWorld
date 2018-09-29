using MvvmCross.Platform;
using MvvmCross.Platform.IoC;
using Plugin.TextToSpeech;

namespace HelloCrossPlatformWorld.Core
{
    public class App : MvvmCross.Core.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
            Mvx.RegisterSingleton(CrossTextToSpeech.Current);

            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterNavigationServiceAppStart<ViewModels.FirstViewModel>();
        }
    }
}
