using System;
using System.Diagnostics;
using MvvmCross.Core.ViewModels;
using PorpoiseMobileApp.Client;

namespace PorpoiseMobileApp.ViewModels
{
    public class ConfirmationCodeViewModel: PorpoiseViewModel<ConfirmationCodeViewModel>
    {
        IPorpoiseWebApiClient _client;

       

        public ConfirmationCodeViewModel()
        {
        }
		public ConfirmationCodeViewModel(string email)
		{
            Debug.WriteLine("EMAIL " + email);
		}

        public ConfirmationCodeViewModel(IPorpoiseWebApiClient client){

            _client = client;

        }

        private IMvxCommand _backCommand;

        private IMvxCommand _continueCommand;

        private string _email;

        private string generatedCode;

        public string GeneratedCode{

            get{

                return this.generatedCode;

            }
            set{

                this.generatedCode = value;

                RaisePropertyChanged(()=>this.GeneratedCode);

            }

        }


        public IMvxCommand ContinueCommand{

            get{

                _continueCommand = new MvxCommand(Continue);

                return _continueCommand;

            }

        }

        public IMvxCommand BackCommand{

            get{

                _backCommand = new MvxCommand(Back);

                return _backCommand;

            }

        }

        private async void Continue()
        {
            
            try
            {
                var response = await _client.Confirmcode(generatedCode);
                if(response!= null && response.Successful){

                    var param = new System.Collections.Generic.Dictionary<string, string>();
                    param.Add("uid", response.Payload.ToString());
                    ShowViewModel<PasswordConfirmationViewModel>(param);

                }

            }
            catch (Exception ex)
            {

                Debug.WriteLine(ex.ToString());

            }
        }
        private void Back(){

            ShowViewModel<RequestAccountViewModel>();

        }

        public string Email{

            get{

                return _email;

            }set{


                _email = value;

                RaisePropertyChanged(()=>Email);

            }

        }

        private string _code="";

        public string Code{

            get{

                return _code;

            }
            set{

                _code = value;

                RaisePropertyChanged(()=> Code);

            }

        }

      

        protected override void InitFromBundle(MvvmCross.Core.ViewModels.IMvxBundle parameters)
        {
			if (parameters.Data.ContainsKey("email"))
			{
                var mykey1value = parameters.Data["email"];
                this.Email = mykey1value;
                Debug.WriteLine("PARAMETER FOUND");

              
		       }
            base.InitFromBundle(parameters);
        }

		
    }
}
