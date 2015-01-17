using Cirrious.CrossCore.IoC;
using MvvmCrossMenu.Services;
using System.Reflection;

namespace MvvmCrossMenu.Core
{
    public class App : Cirrious.MvvmCross.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
			CreatableTypes(typeof(IMenuService).GetTypeInfo().Assembly)
				.EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();
				
			RegisterAppStart<ViewModels.RootViewModel>();
        }
    }
}