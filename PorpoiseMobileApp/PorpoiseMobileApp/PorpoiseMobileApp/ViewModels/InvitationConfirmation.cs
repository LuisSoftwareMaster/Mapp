using System;
using MvvmCross.Core.ViewModels;

namespace PorpoiseMobileApp.ViewModels
{
    public class InvitationConfirmationViewModel: PorpoiseViewModel<InvitationConfirmationViewModel>
    {
        public InvitationConfirmationViewModel()
        {
        }

        private IMvxCommand _backCommand;

        public IMvxCommand BackCommand{
            get
            {
                _backCommand = new MvxCommand(Back);
                return _backCommand;
            }
        }

        void Back(){

			ShowViewModel<InviteCoworkerViewModel>();


		}
    }
}
