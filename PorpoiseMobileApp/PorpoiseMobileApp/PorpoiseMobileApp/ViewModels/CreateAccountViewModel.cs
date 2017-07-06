using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PorpoiseMobileApp.ViewModels
{
   public class CreateAccountViewModel:PorpoiseViewModel<CreateAccountViewModel>
    {

        IMvxCommand registrate;

        public IMvxCommand Registrate {

            get {

                registrate = new MvxCommand(()=> {

                    ShowViewModel<RegistrationViewModel>();

                });

                return registrate;
            }

        }


    }
}
