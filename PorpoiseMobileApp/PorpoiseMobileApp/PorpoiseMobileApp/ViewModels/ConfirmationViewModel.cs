using System;
using MvvmCross.Core.ViewModels;
using PorpoiseMobileApp.ViewModels;

namespace PorpoiseMobileApp.ViewModels
{
	public class ConfirmationViewModel : PorpoiseViewModel<ConfirmationViewModel>
	{
		private IMvxCommand _goLogin;
        private string topImage;
		public IMvxCommand GoBack
		{

			get
			{

				return _goLogin ?? (_goLogin = new MvxCommand(returnToLogin));


			}

		}

		public string TopImage
        {

            get
            {

                return "https://s3.amazonaws.com/porpoise-mobile-assets/Image+1.png";
            }
            set
            {

                topImage = value;
            }

        }
		public void returnToLogin() {

			ShowViewModel<LoginViewModel>();
		
		}
		public ConfirmationViewModel()
		{
		}
	}
}
