using Android.Content;
using MvvmCross.Droid.Platform;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.Platform;
using MvvmCross.Platform.IoC;
using Autofac;
using PorpoiseMobileApp.ViewModels;
using PorpoiseMobileApp.Services;
using PorpoiseMobileApp.Droid.Services;
using PorpoiseMobileApp.Startup;
using MvvmCross.Plugins.Json;
using MvvmCross.Droid.Views;
using PorpoiseMobileApp.Droid.MvvmCross;
using MvvmCross.Platform;
using MvvmCross.Binding.Bindings.Target.Construction;
using Android.Widget;
using PorpoiseMobileApp.Droid.Bindings;
using Acr.Settings;
using MvvmCross.Droid.Support.V7.AppCompat;
using PorpoiseMobileApp.Droid.Views;
using MvvmCross.Droid.Shared.Fragments;
using MvvmCross.Droid.Support.V7.RecyclerView;
using UniversalImageLoader.Core;

namespace PorpoiseMobileApp.Droid
{
    public class Setup : MvxAndroidSetup
    {
        public Setup(Context applicationContext) : base(applicationContext)
        {
        }

        protected override IMvxApplication CreateApp()
        {// Use default options
            var config = ImageLoaderConfiguration.CreateDefault(this.ApplicationContext);
            // Initialize ImageLoader with configuration.
            ImageLoader.Instance.Init(config);
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

            cb.RegisterAssemblyTypes(typeof(LoadingView).Assembly)
                .AssignableTo<IMvxFragmentView>()
                .As<IMvxFragmentView>()
                .AsSelf();

            cb.RegisterAssemblyTypes(typeof(MvxRecyclerView).Assembly);

            cb.RegisterAssemblyTypes(typeof(Setup).Assembly)
                .Where(x => x.Name.EndsWith("Service"))
                .AsImplementedInterfaces();

            cb.Register(x => Settings.Local).As<ISettings>().SingleInstance();
            cb.RegisterInstance<IEncryptionService>(new EncryptionService());
            cb.RegisterInstance<IConsoleLogger>(new ConsoleLogger());
            cb.RegisterInstance<IMvxJsonConverter>(new MvxJsonConverter());
            cb.RegisterInstance<IImageService>(new ImageService());
            cb.RegisterInstance<IImageRotateService>(new AndroidImageRotationService());
            return new AutofacMvxIocProvider(cb.Build());
        }

        protected override IMvxAndroidViewPresenter CreateViewPresenter()
        {
            var customPresenter = new PorpoiseViewPresenter();
            Mvx.RegisterSingleton<ICustomPresenter>(customPresenter);
            return customPresenter;
        }

        protected override IMvxAndroidViewsContainer CreateViewsContainer(Context applicationContext)
        {
            return new PorpoiseViewsContainer(applicationContext);
        }
      

        protected override void FillTargetFactories(IMvxTargetBindingFactoryRegistry registry)
        {
            MvxAppCompatSetupHelper.FillTargetFactories(registry);
            base.FillTargetFactories(registry);
            registry.RegisterPropertyInfoBindingFactory(typeof(ProgressBarVisibilityTargetBinding), typeof(ProgressBar), "Visibility");
        }
    }
}
