using System;
using System.Diagnostics;
using MvvmCross.Core.ViewModels;
using PorpoiseMobileApp.Client;

namespace PorpoiseMobileApp.ViewModels
{
    public class InviteCoworkerViewModel : PorpoiseViewModel<InviteCoworkerViewModel>
    {
        IMvxCommand _cancel;

        IMvxCommand _confirmCommand;

        IMvxCommand _addEmployee;

        private string name;

        private string email;

        private bool _throwError = false;

        private string apiMessage;

        public string ApiMessage{

            get{

                return apiMessage;

            }

            set{

                apiMessage = value;

            }

        }

        public bool ThrowError{

            get{

                return _throwError;

            }
            set{

                _throwError = value;

                RaisePropertyChanged(()=> ThrowError);

            }

        }

        IPorpoiseWebApiClient client;

        Guid employeeUid;

        public IMvxCommand AddEmployee{

            get{

				_addEmployee = new MvxCommand(() =>
			{
                    if (!string.IsNullOrEmpty(this.Name) && !string.IsNullOrEmpty(this.Email))
                {

                    InviteCoworkerList.addEmployee(this.employeeUid, this.Name, this.Email);

                    this.Name = "";

                    this.Email = "";

                    Debug.WriteLine("Employee added: " + InviteCoworkerList.CoworkerList.Count);

                    ThrowError = false;
                }
                    else{

                    ThrowError = true;

                    }
			});
                return _addEmployee;
            }

        }

        public IMvxCommand ConfirmCommand
        {

            get
            {

                _confirmCommand = new MvxCommand(Confirm);

                return _confirmCommand;

            }

        }

        private async void Confirm(){


            if (this.employeeUid != Guid.Empty && InviteCoworkerList.CoworkerList != null && InviteCoworkerList.CoworkerList.Count>0)
                {
                for (int i = 0; i < InviteCoworkerList.CoworkerList.Count; i++){

					var result = await client.InviteCoWorker(InviteCoworkerList.CoworkerList[i].employeeUid, InviteCoworkerList.CoworkerList[i].name, InviteCoworkerList.CoworkerList[i].email);

                    if(i == InviteCoworkerList.CoworkerList.Count-1){

                        ShowViewModel<InvitationConfirmationViewModel>();

                    }

                }


                   

            }
            else if(this.employeeUid != Guid.Empty && !string.IsNullOrEmpty(this.Name) && !string.IsNullOrEmpty(this.Email)){

                var result = await client.InviteCoWorker(this.employeeUid, this.Name, this.Email);
                if(result != null && result.Successful)
                {
                    ShowViewModel<InvitationConfirmationViewModel>();

                }
                else{

                    apiMessage = result.Message;
                    ThrowError = true;
                }

			}
            else{

                ThrowError = true;

            }

            }

        public string Name
        {

            get
            {

                return name;

            }
            set
            {

                name = value;

                RaisePropertyChanged(() => Name);

            }
        }

		public bool EmailValid
		{
			get
			{
				return !string.IsNullOrEmpty(Email) && Validation.IsEmail(Email);
			}
		}

        public string Email{

            get{

                return email;

            }
            set{

                email = value;

                RaisePropertyChanged(()=>Email);

            }

        }

        public  InviteCoworkerViewModel(IPorpoiseWebApiClient client)
        {
            this.client = client;

            InviteCoworkerList.clearList();

        }

		public async void Init(EditParameters editParams)
		{
            var employee = await client.GetEmployee();

            if(employee!= null && employee.Successful){

                this.employeeUid = employee.Payload.EmployeeUid;

				Debug.WriteLine("EMPLOYEE UID: " + this.employeeUid.ToString());

			}

			
		}


		public IMvxCommand CancelCommand{

            get{

                _cancel = new MvxCommand(Cancel);
                return _cancel;
            }

        }

        private void Cancel(){

            ShowViewModel<HomeViewModel>();

        }
    }
}
