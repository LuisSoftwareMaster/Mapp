
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Acr.Settings;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using PorpoiseMobileApp.Client;

namespace PorpoiseMobileApp.ViewModels
{
	public class RequestAccountViewModel : PorpoiseViewModel<RequestAccountViewModel>
	{
		private ISettings _settings;
		private IPorpoiseWebApiClient client;
		private string _fullname;
		private string _workEmail;
		private string _company;
		private string _lastname;
		private IMvxCommand _goConfirmationPage;
		private IMvxCommand _goBack;
		private bool _inFlight;
        private string topImage;

        private string _fullnameLeftImage;

        public string FullnameLeftImage{

            get{

                return "https://s3.amazonaws.com/porpoise-mobile-assets/RequestAccountViewController/avatar+(1).png";

            }
            set{

                _fullnameLeftImage = value;

            }

        }

		public bool EmailValid
		{
			get
			{
                return !string.IsNullOrEmpty(WorkEmail) && Validation.IsEmail(WorkEmail);
			}
		}


        public bool ValidField(string val){

            if(string.IsNullOrEmpty(val)){

                return false;
            }
            return true;

        }


		public string TopImage{

            get{

                return "https://s3.amazonaws.com/porpoise-mobile-assets/Image+1.png";
            }
            set{

                topImage = value;
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
				RaisePropertyChanged(() => RegisterEmployeeCommand);
			}
		}
		public string Company { 
		
			get {

				return _company;
			}
			set {

				_company = value;

				RaisePropertyChanged(() => Company);
			}
		
		}

		public string WorkEmail { 
		
			get {

				return _workEmail;
			
			}
			set {
				_workEmail = value;
				RaisePropertyChanged(() => WorkEmail);
			}
		
		}

		public string Lastname { 
		
			get {

				return _lastname;
			
			}
			set {

				_lastname = value;

				RaisePropertyChanged(() => this.Lastname);

			}
		
		}

		public string Fullname
		{

			get
			{

				return _fullname;

			}
			set
			{

				_fullname = value;

				RaisePropertyChanged(() => Fullname);

			}

		}

		public IMvxCommand RegisterEmployeeCommand
		{
			get
			{
				return _goConfirmationPage ?? (_goConfirmationPage = new MvxCommand(RequestEmployee, () => !InFlight));
			}
		}

		public IMvxCommand GoBack {
		
			get { 
			
				return _goBack ?? (_goBack = new MvxCommand(returnLogin));


			}
		
		}


        private bool _checked;

        public bool Checked { get{

                return _checked;

            }  set{

                _checked = value;

            } }

        private void returnLogin() {

			ShowViewModel<LoginViewModel>();
		
		}

	

		public RequestAccountViewModel(IPorpoiseWebApiClient client)
		{
			this.client = client;
			this._settings = Mvx.Resolve<ISettings>();
		}

        public void presentConfirmationCode(){

			var param = new System.Collections.Generic.Dictionary<string, string>();
            param.Add("email", this.WorkEmail);
            this.ShowViewModel<ConfirmationCodeViewModel>(param);

        }


        public async void RequestEmployee()
        {

            if(isValid())
            {
            try
            {
                this.InFlight = true;

                var result = await this.client.Signup(this.WorkEmail, this.Company, this.Fullname, this.Lastname);

                if (result != null && result.Successful)
                {
                    //Show success view model

                    Debug.WriteLine("Congratulations");

                    this.InFlight = false;

                    var param = new System.Collections.Generic.Dictionary<string, string>();
                    param.Add("email", this.WorkEmail);

                    ShowViewModel<ConfirmationCodeViewModel>(param);

                }
                else
                {
                    //ThrowException
                    throw new Exception();

                }
            }
            catch (Exception ex)
            {
                this.InFlight = false;
                Debug.WriteLine(ex.Message);

            }

        }
		
		}

        private bool isValid()
        {
            if(!string.IsNullOrEmpty(this.Fullname) && !string.IsNullOrEmpty(this.Lastname) && this.EmailValid && !string.IsNullOrEmpty(this.Company) && this.Checked){

                return true;

            }

            return false;
        }
    }
}
