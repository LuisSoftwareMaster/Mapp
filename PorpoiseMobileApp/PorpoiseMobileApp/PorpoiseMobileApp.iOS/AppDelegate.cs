﻿using Foundation;
using UIKit;
using MvvmCross.Platform;
using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Platform;
using System;
using MonoTouch.Dialog;
using System.Threading.Tasks;
using System.Collections;
using System.Json;
using PorpoiseMobileApp.iOS.Utils;
using Amazon;


namespace PorpoiseMobileApp.iOS
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the
	// User Interface of the application, as well as listening (and optionally responding) to application events from iOS.
	[Register("AppDelegate")]
	public class AppDelegate : MvxApplicationDelegate
	{
		public override UIWindow Window
		{
			get;
			set;
		}
		Setup setup;


		public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
		{

			//Localize.SetLocale ();
#if DEBUG
			Xamarin.Calabash.Start();
#endif

			Intercom.SetApiKey("ios_sdk-7149ca11857611fe62c97d3f7643ed3606b7e5f5", "f1xl6ben");

			Intercom.RegisterUnidentifiedUser();

			Window = new UIWindow(UIScreen.MainScreen.Bounds);

			var presenter = new PorpoiseIosViewPresenter(this, Window);
			setup = new Setup(this, presenter);
			setup.Initialize();
			var startup = Mvx.Resolve<IMvxAppStart>();
			startup.Start();

			var navBarLook = UINavigationBar.Appearance;
			navBarLook.SetTitleTextAttributes(new UITextAttributes()
			{
				//TODO:if nav bar is Turquoise, must change this to UIColor.White
				TextColor = UIColor.White
			});
			navBarLook.BarTintColor = PorpoiseColors.Turquoise;
			navBarLook.TintColor = UIColor.White;

			UISegmentedControl.Appearance.TintColor = PorpoiseColors.Turquoise;
			UIActivityIndicatorView.Appearance.TintColor = PorpoiseColors.Turquoise;
			UIActivityIndicatorView.Appearance.Color = PorpoiseColors.Turquoise;
			UISwitch.Appearance.OnTintColor = PorpoiseColors.Turquoise;

			KeyboardManager.Init();
			//UIApplication.SharedApplication.StatusBarStyle

			Window.MakeKeyAndVisible();

			//This method verifies if you have been logged into the app before, and keeps you logged in after you reopen or kill your app.
			//return this.FinishedLaunching(application, launchOptions);
			return true;
		}


		public override bool OpenUrl(UIApplication application, NSUrl url, string sourceApplication, NSObject annotation)
		{
			AccountInfo.OpenAppUrl = url.Host;
			return true;
		}

		public override void OnResignActivation(UIApplication application)
		{
			// Invoked when the application is about to move from active to inactive state.
			// This can occur for certain types of temporary interruptions (such as an incoming phone call or SMS message) 
			// or when the user quits the application and it begins the transition to the background state.
			// Games should use this method to pause the game.
		}

		public override void DidEnterBackground(UIApplication application)
		{
			// Use this method to release shared resources, save user data, invalidate timers and store the application state.
			// If your application supports background exection this method is called instead of WillTerminate when the user quits.
		}

		public override void WillEnterForeground(UIApplication application)
		{
			// Called as part of the transiton from background to active state.
			// Here you can undo many of the changes made on entering the background.
		}

		public override void OnActivated(UIApplication application)
		{
			// Restart any tasks that were paused (or not yet started) while the application was inactive. 
			// If the application was previously in the background, optionally refresh the user interface.
		}

		public override void WillTerminate(UIApplication application)
		{
			// Called when the application is about to terminate. Save data, if needed. See also DidEnterBackground.
		}

		
	}
}


