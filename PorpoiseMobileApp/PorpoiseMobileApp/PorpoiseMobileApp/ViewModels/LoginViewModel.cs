using System;
using MvvmCross.Core.ViewModels;
using PorpoiseMobileApp.Client;
using Acr.Settings;
using PorpoiseMobileApp.Services;
using System.Net.Http;
using System.Threading.Tasks;
using System.Diagnostics;

namespace PorpoiseMobileApp.ViewModels
{
	public class LoginViewModel : PorpoiseViewModel<LoginViewModel>
	{
		private string _email;
		private bool _inFlight;
		private string _password;
		private bool _firstTimeUser = false;
		private readonly IPorpoiseWebApiClient client;
		private readonly ISettings settings;
		private IEncryptionService encryption;
		private IMvxCommand _signInCommand;

		private const string TOKEN_KEY = "auth.token";

		public LoginViewModel(IPorpoiseWebApiClient client, ISettings settings, IEncryptionService encryption)
		{
			this.client = client;
			this.settings = settings;
			this.encryption = encryption;
		}


		public string Email
		{
			get
			{
				return _email;
			}
			set
			{
				_email = value;
				RaisePropertyChanged(() => Email);
				RaisePropertyChanged(() => SignInCommand);
			}
		}

		public bool EmailValid
		{
			get
			{
				return !string.IsNullOrEmpty(Email) && Validation.IsEmail(Email);
			}
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
				RaisePropertyChanged(() => SignInCommand);
			}
		}

		public string Password
		{
			get
			{
				return _password;
			}
			set
			{
				_password = value;
				RaisePropertyChanged(() => Password);
				RaisePropertyChanged(() => SignInCommand);
			}
		}

		public bool PasswordValid
		{
			get
			{
				return Validation.IsPassword(Password);
			}
		}


		public IMvxCommand SignInCommand
		{
			get
			{
				_signInCommand = new MvxCommand(PerformSignIn, () => !InFlight);
				return _signInCommand;
			}
		}

		public void navigateRequestEmployeeViewController()
		{

			ShowViewModel<ViewModels.RequestAccountViewModel>();

		}

		private async void  PerformSignIn()
		{
			if (EmailValid && PasswordValid)
			{
				InFlight = true;
				try
				{
					Debug.WriteLine(Email+" "+Password);
					var result = await client.PerformSignIn(Email, Password);
					Debug.WriteLine("RESULT");
					if (result != null && result.Successful)
					{
						PerformSignInEvent(true);
						AccountInfo.Email = Email;
						var employee = await client.GetEmployee();
						AccountInfo.UserId = employee.Payload.UserId; 
						settings.Set(TOKEN_KEY, result.Token);

						AccountInfo.CompanyName = employee.Payload.CompanyName;

                        Debug.WriteLine("SHOW PROFILE TUTORIAL: "+result.Payload.show_profile_tutorial);

                        AccountInfo.show_posting_tutorial = result.Payload.show_posting_tutorial;

                        AccountInfo.show_profile_tutorial = result.Payload.show_profile_tutorial;

						Debug.WriteLine("COMPANY NAME " + AccountInfo.CompanyName);

						ShowViewModel<HomeViewModel>();


					}
					else {

						Debug.WriteLine("ERROR PERFORMING SIGN IN RESULT "+result.Message);
						PerformSignInEvent(false, result.Message);
					}
				}
				catch (HttpRequestException hre)
				{
					Debug.WriteLine("ERROR PERFORMING SIGN IN HTTPREQUEST");
					PerformSignInEvent(false, string.IsNullOrEmpty(hre.Message) ? Resource.LoginError : hre.Message);
				}
				catch (Exception ex)
				{
					Debug.WriteLine("ERROR PERFORMING SIGN IN EXCEPTION "+ex.Message);
                    ShowViewModel<HomeViewModelAndroid>();
					//PerformSignInEvent(false, string.IsNullOrEmpty(ex.Message) ? Resource.LoginError : ex.Message);
				}
				InFlight = false;
			}
			else {
				RaisePropertyChanged(() => Email);
				RaisePropertyChanged(() => Password);
				Debug.WriteLine("ERROR PERFORMING SIGN IN WRONG EMAIL AND PASSWORD");
				PerformSignInEvent(false, Resource.LoginError);
			}
		}

		private void PerformSignInEvent(bool success, string message = null)
		{
			if (SignInEvent != null)
			{
				try
				{
					Debug.WriteLine("MESSAGE IN SIGN IN EVENT "+message);

					SignInEvent(this, new SdkEventArgs(success, message));
				}
				catch (Exception ex)
				{
					SignInEvent(this, new SdkEventArgs(false, ex.Message));
				}
			}
		}

		public event EventHandler<SdkEventArgs> SignInEvent;

		public string ForgotPasswordURL
		{
			get
			{
				return "https://connect.giving.company/forgotpassword_app";
			}

		}

		public string JoinURL
		{
			get { return "https://connect.giving.company/join"; }
		}
	}
}

