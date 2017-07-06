using System;
using Autofac;
using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Platform;
using MvvmCross.iOS.Views.Presenters;
using MvvmCross.Platform.IoC;
using MvvmCross.Platform.Platform;
using PorpoiseMobileApp.Startup;
using PorpoiseMobileApp.ViewModels;
using UIKit;
using MvvmCross.Platform;
using MvvmCross.iOS.Views;
using MvvmCross.Platform.Exceptions;
using PorpoiseMobileApp.Services;
using PorpoiseMobileApp.iOS.Services;
using MvvmCross.Binding.Bindings.Target.Construction;
using PorpoiseMobileApp.iOS.Bindings;
using Acr.Settings;
using MvvmCross.Platform.Converters;
using MvvmCross.Plugins.Json;
using MvvmCross.Platform.Plugins;

namespace PorpoiseMobileApp.iOS
{
	public class Setup : MvxIosSetup
	{
		public Setup(MvxApplicationDelegate applicationDelegate, UIWindow window)
			: base(applicationDelegate, window)
		{
		}

		public Setup(MvxApplicationDelegate applicationDelegate, IMvxIosViewPresenter presenter)
			: base(applicationDelegate, presenter)
		{
		}

		protected override IMvxApplication CreateApp()
		{
			return new PorpoiseMobileApp.App();
		}

		protected override IMvxTrace CreateDebugTrace()
		{
			return new DebugTrace();
		}

		protected override IMvxIoCProvider CreateIocProvider()
		{
			var cb = new ContainerBuilder();
			cb.RegisterAssemblyTypes(typeof(LoadingViewModel).Assembly)
				.AssignableTo<MvxViewModel>()
				.As<IMvxViewModel, MvxViewModel>()
				.AsSelf();

			cb.RegisterAssemblyTypes(typeof(Setup).Assembly)
			   .Where(x => x.Name.EndsWith("Service"))
			   .AsImplementedInterfaces();
			cb.Register(x => Settings.Local).As<ISettings>().SingleInstance();
			cb.RegisterInstance<IEncryptionService>(new EncryptionService());
			cb.RegisterInstance<IConsoleLogger>(new ConsoleLogger());
			cb.RegisterInstance<IMvxJsonConverter>(new MvxJsonConverter());
			cb.RegisterInstance<IImageService>(new ImageService());
			cb.RegisterInstance<IImageRotateService>(new DummyImageRotator());

			return new AutofacMvxIocProvider(cb.Build());

		}
		protected override void FillValueConverters(IMvxValueConverterRegistry registry)
		{
			base.FillValueConverters(registry);
			registry.AddOrOverwrite("DateToNsDate", new DateToNSDateConverter());
			registry.AddOrOverwrite("UriToImage", new UriToImageConverter());
		}
		protected override IMvxIosViewsContainer CreateIosViewsContainer()
		{
			return new AutofacViewModelStoryboardContainer();
		}

		protected override IMvxIosViewPresenter CreatePresenter()
		{
			var customPresenter = new PorpoiseIosViewPresenter(this.ApplicationDelegate, this.Window);
			return customPresenter;
		}

		protected override void FillTargetFactories(IMvxTargetBindingFactoryRegistry registry)
		{
			base.FillTargetFactories(registry);
			registry.RegisterPropertyInfoBindingFactory(typeof(MvxSegmentedControlSelectedSegmentTargetBinding), typeof(UIKit.UISegmentedControl), "SelectedSegment");
			registry.RegisterPropertyInfoBindingFactory(typeof(MvxActivityIndicatorHiddenTargetBinding), typeof(UIKit.UIActivityIndicatorView), "Hidden");
			//register custom Porpoise TextField and bindings
			registry.RegisterCustomBindingFactory<PorpoiseEditText>("Text", field => new PorpoiseTextEditTargetBinding(field));

		}

		//protected override void AddPluginsLoaders(MvxLoaderPluginRegistry registry)
		//{
		//	registry.Register<MvvmCross.Plugins.File.PluginLoader, MvvmCross.Plugins.File.iOS.Plugin>();
		//	base.AddPluginsLoaders(registry);
		//}


		//protected override void InitializeLastChance()
		//{
		//	MvvmCross.Plugins.DownloadCache.PluginLoader.Instance.EnsureLoaded();
		//	MvvmCross.Plugins.File.PluginLoader.Instance.EnsureLoaded();
		//	MvvmCross.Plugins.Json.PluginLoader.Instance.EnsureLoaded();

		//	base.InitializeLastChance();
		//}
		protected override IMvxPluginManager CreatePluginManager()
		{
			return new MvxFilePluginManager(".iOS", ".dll");
		}
	}

	public class AutofacViewModelLoader : IMvxViewModelLoader
	{
		#region IMvxViewModelLoader implementation
		public IMvxViewModel LoadViewModel(MvxViewModelRequest request, IMvxBundle savedState)
		{
			return Mvx.Resolve(request.ViewModelType) as IMvxViewModel;
		}

		//TODO: look into reloadViewModel
		public IMvxViewModel ReloadViewModel(IMvxViewModel viewModel, MvxViewModelRequest request, IMvxBundle savedState)
		{
			return Mvx.Resolve(request.ViewModelType) as IMvxViewModel;
		}
		#endregion
	}


	public class AutofacViewModelStoryboardContainer : MvxIosViewsContainer
	{
		private readonly UIStoryboard storyboard;

		public AutofacViewModelStoryboardContainer()
		{
			this.storyboard = UIStoryboard.FromName("Main", null);
		}

		protected override IMvxIosView CreateViewOfType(Type viewType, MvxViewModelRequest request)
		{
			// Make sure that the Storyboard IDs match the ViewModel name (eg.  SignUpViewModel = SignUpViewController)
			var name = request.ViewModelType.Name;
			name = name.Substring(0, name.Length - "ViewModel".Length) + "ViewController";

			var ctrl = storyboard.InstantiateViewController(name);

			return ctrl as IMvxIosView;
		}
	}
	public class PorpoiseIosViewPresenter : MvxIosViewPresenter
	{

		public DisplayHint LastHint
		{
			get;
			set;
		}

		public PorpoiseIosViewPresenter(IUIApplicationDelegate applicationDelegate, UIWindow window) : base(applicationDelegate, window)
		{
		}
		public override bool PresentModalViewController(UIViewController viewController, bool animated)
		{

			return base.PresentModalViewController(viewController, animated);

		}
		public override void Show(MvxViewModelRequest request)
		{
			base.Show(request);
			var vm = request.ViewModelType;
			//this is called after the Show(IMvxIosView view)
		}


		public override void Show(IMvxIosView view)
		{

			var viewController = view as UIViewController;
			if (viewController == null)
			{
				throw new MvxException("Passed in IMvxIosView is not a UIViewController");
			}
			var hasHints = viewController is IHasDisplayHint;

			if (MasterNavigationController == null)
			{
				ShowFirstView(viewController);
				if (hasHints)
				{
					var hints = (viewController as IHasDisplayHint).Hint;
					LastHint = hints;

					if (hints.FullScreen)
					{
						viewController.NavigationController.NavigationBarHidden = true;
					}
					else
					{
						viewController.NavigationController.NavigationBarHidden = false;
					}
				}
			}

			else
			{
				if (hasHints)
				{
					var hints = (viewController as IHasDisplayHint).Hint;
					LastHint = hints;

					if (!string.IsNullOrEmpty(hints.BackTitle))
					{
						viewController.NavigationItem.BackBarButtonItem = new UIBarButtonItem(hints.BackTitle, UIBarButtonItemStyle.Plain, null, null);
					}

					if (hints.MakeRoot)
					{
						this.Window.RootViewController = viewController;
						MasterNavigationController = viewController as UINavigationController;
					}
					else
					{

						if (hints.ClearToRoot)
						{
							var root = MasterNavigationController.ViewControllers[0];

							if (root != null && root != viewController)
							{
								MasterNavigationController.SetViewControllers(new UIViewController[] { viewController }, hints.Animate);
							}
							else
							{
								MasterNavigationController.PopToRootViewController(hints.Animate);
							}
							if (hints.FullScreen)
							{
								MasterNavigationController.NavigationBar.Hidden = true;
							}
							else
							{
								MasterNavigationController.NavigationBar.Hidden = false;
							}
						}

						if (hints.Modal)
						{
							MasterNavigationController.PresentModalViewController(viewController, hints.Animate);
						}
						else if (!hints.ClearToRoot)
						{
							MasterNavigationController.PushViewController(viewController, hints.Animate);
						}
					}
					if (viewController.NavigationController != null)
					{
						if (hints.FullScreen)
						{
							viewController.NavigationController.NavigationBar.Hidden = true;
						}
						else
						{
							viewController.NavigationController.NavigationBar.Hidden = false;
						}
					}
				}
				else
				{
					if (LastHint != null)
					{
						if (LastHint.Modal)
						{
							MasterNavigationController.DismissViewController(LastHint.Animate, () =>
							{
							});
							LastHint = null;
						}
						LastHint = null;
					}
					MasterNavigationController.PushViewController(viewController, true /*animated*/);
					if (viewController.NavigationController != null)
					{
						viewController.NavigationController.NavigationBarHidden = false;
					}

				}
			}
		}
	}
}

