using System;
using System.Diagnostics;
using Acr.Settings;
using MvvmCross.Core.ViewModels;
using PorpoiseMobileApp.Client;
using PorpoiseMobileApp.Services;

namespace PorpoiseMobileApp.ViewModels
{
	public class PasswordConfirmationViewModel : PorpoiseViewModel<PasswordConfirmationViewModel>
	{
		private readonly IPorpoiseWebApiClient client;
		private readonly ISettings settings;
		private IEncryptionService encryption;
        private const string TOKEN_KEY = "auth.token";
        private string uid;
        private string _password;
        private IMvxCommand _setPassword;
        private string _passwordConfirmation;

        protected override void InitFromBundle(MvvmCross.Core.ViewModels.IMvxBundle parameters)
        {
            if(parameters.Data.ContainsKey("uid")){

                this.uid = parameters.Data["uid"];

                Debug.WriteLine("UID: "+this.uid);

            }

            base.InitFromBundle(parameters);
        }

        public IMvxCommand SetPassword
        {get
            {
                _setPassword = new MvxCommand(PerformSignIn);

                return _setPassword;

            }

        }

        public string PasswordConfirmation{

            get{

                return _passwordConfirmation;

            }
            set{

                _passwordConfirmation = value;

                RaisePropertyChanged(() => PasswordConfirmation);

            }

        }

        public string Password{

            get{

                return _password;

            }
            set{

                _password = value;

                RaisePropertyChanged(()=> Password);

            }

        }

        public event EventHandler<SdkEventArgs> SignInEvent;

		private void PerformSignInEvent(bool success, string message = null)
		{
			if (SignInEvent != null)
			{
				try
				{
					Debug.WriteLine("MESSAGE IN SIGN IN EVENT " + message);

					SignInEvent(this, new SdkEventArgs(success, message));
				}
				catch (Exception ex)
				{
					SignInEvent(this, new SdkEventArgs(false, ex.Message));
				}
			}
		}

        public PasswordConfirmationViewModel(IPorpoiseWebApiClient client, ISettings settings, IEncryptionService encryption)
        {
            this.client = client;

            this.settings = settings;

            this.encryption = encryption;
        }

        private async void PerformSignIn()
        {

            //InFlight = true;
            if(!string.IsNullOrEmpty(this.Password) && this.Password.Equals(this.PasswordConfirmation))
            {
            try
            {

                var result = await client.SetupNewPassword(this.Password, this.uid);
                Debug.WriteLine("RESULT");
                if (result != null && result.Successful)
                {
                    PerformSignInEvent(true);
                    //AccountInfo.Email = Email;
                    var employee = await client.GetEmployee();
                    AccountInfo.UserId = employee.Payload.UserId;
                    settings.Set(TOKEN_KEY, result.Token);

                    AccountInfo.CompanyName = employee.Payload.CompanyName;

                    Debug.WriteLine("COMPANY NAME " + AccountInfo.CompanyName);

                    ShowViewModel<HomeViewModel>();


                }
                else
                {

                    Debug.WriteLine("ERROR PERFORMING SIGN IN RESULT " + result.Message);
                    //PerformSignInEvent(false, result.Message);
                }
            }
            catch (System.Net.Http.HttpRequestException hre)
            {
                Debug.WriteLine("ERROR PERFORMING SIGN IN HTTPREQUEST");
                //PerformSignInEvent(false, string.IsNullOrEmpty(hre.Message) ? Resource.LoginError : hre.Message);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("ERROR PERFORMING SIGN IN EXCEPTION " + ex.Message);
                ShowViewModel<HomeViewModelAndroid>();
                //PerformSignInEvent(false, string.IsNullOrEmpty(ex.Message) ? Resource.LoginError : ex.Message);
            }

        }
			
		}
    }
}
