using System;
using MvvmCross.Core.ViewModels;
using PorpoiseMobileApp.Client;
using Acr.Settings;
using System.Diagnostics;
using System.Net.Http;

namespace PorpoiseMobileApp.ViewModels
{
    public class LoadingViewModel : PorpoiseViewModel<LoadingViewModel>
    {
        private bool _inFlight;
        private IMvxCommand _authenticateCommand;

        public LoadingViewModel(ISettings settings, IPorpoiseWebApiClient client)
        {
            this.client = client;
            this.settings = settings;
        }

        public bool InFlight
        {
            get
            {

                return _inFlight;
            }

            set
            {
                _inFlight = value;
                RaisePropertyChanged(() => InFlight);
                RaisePropertyChanged(() => AuthenticateCommand);

            }

        }

        public IMvxCommand AuthenticateCommand
        {

            get
            {
                return _authenticateCommand ?? (_authenticateCommand = new MvxCommand(PerformAuthentication, () => !InFlight));
            }
        }
        
        bool authenticated = false;
        private ISettings settings;
        private IPorpoiseWebApiClient client;
        private async void PerformAuthentication()
        {

            InFlight = true;
            try
            {
                //if (settings.Contains(AccountInfo.TOKENKEY))
                //{
                //    var token = settings.Get<string>(AccountInfo.TOKENKEY);
                //    AccountInfo.Token = token;
                //    authenticated = string.IsNullOrEmpty(AccountInfo.Token);
                //}
              ShowViewModel<CreateAccountViewModel>();
					InFlight = false;
               
            }
            catch (Exception ex)
            //TODO: ensure to log error
            {
				ShowViewModel<CreateAccountViewModel>();
            }
        }

        private void PerformAuthenticateEvent(bool success, string message = null)
        {
            if (AuthenticateEvent != null)
            {
				AuthenticateEvent(this, new SdkEventArgs(success, message));
            }
        }

        public event EventHandler<SdkEventArgs> AuthenticateEvent;
    }
}

