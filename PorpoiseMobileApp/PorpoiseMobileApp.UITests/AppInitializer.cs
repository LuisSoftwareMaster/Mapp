using System;
using System.IO;
using System.Linq;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace PorpoiseMobileApp.UITests
{
	public class AppInitializer
	{
		public static IApp StartApp(Platform platform)
		{
			/*if (platform == Platform.Android)
			{yo 
				return ConfigureApp
					.Android
					.StartApp();
			}*/

			return ConfigureApp
                .iOS
				.AppBundle("/Users/luis/Documents/BACKUP/porpoise-mobile-app/PorpoiseMobileApp/PorpoiseMobileApp/PorpoiseMobileApp.iOS/bin/iPhoneSimulator/Debug/PorpoiseMobileAppiOS.app")
				.StartApp();
		}
	}
}

