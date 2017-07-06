using Acr.Settings;
using Autofac;
using MvvmCross.Platform;
using MvvmCross.Platform.IoC;
using PorpoiseMobileApp.Client;
using PorpoiseMobileApp.Startup;
using System;
using System.Linq;
using System.Reflection;
using PorpoiseMobileApp.Services;

namespace PorpoiseMobileApp
{
	public class App : MvvmCross.Core.ViewModels.MvxApplication
	{
		public override void Initialize()
		{
			CreatableTypes()
				.EndingWith("Service")
				.AsInterfaces()
				.RegisterAsLazySingleton();
			Mvx.RegisterSingleton<IPorpoiseWebApiClient>(new PorpoiseWebApiClient());
			Mvx.RegisterSingleton(Settings.Local);
			Mvx.RegisterType<IImageService, ImageService>();
			RegisterAppStart<ViewModels.LoadingViewModel>();

		}




	}
}
