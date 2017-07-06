using Android.App;
using Android.OS;
using Android.Views;
using MvvmCross.Droid.Views;
using PorpoiseMobileApp.Client;
using PorpoiseMobileApp.Droid.MvvmCross;
using PorpoiseMobileApp.ViewModels;
using System;
using System.Threading.Tasks;

namespace PorpoiseMobileApp.Droid.Views
{
    [Activity(Label = "Porpoise", Theme = "@style/AppTheme", NoHistory =true)]
    [IntentFilter(new[] { Android.Content.Intent.ActionView },
    DataScheme = "http",
    DataHost = "connect.giving.company",
    DataPath = "/download",
    Categories = new[] { Android.Content.Intent.CategoryDefault, Android.Content.Intent.CategoryBrowsable })]
    public class LoadingView : MvvmAppCompatActivity<LoadingViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            this.Window.AddFlags(WindowManagerFlags.Fullscreen);

			this.SetContentView(Resource.Layout.LoadView);
            ViewModel.AuthenticateEvent += (s, e) =>
            {
                if (!e.Successful)
                {
                    this.Alert(PorpoiseMobileApp.Resource.Error, PorpoiseMobileApp.Resource.ServerConnectionError);
                }
            };
            
            ViewModel.AuthenticateCommand.Execute();

        }
 

    }
}
