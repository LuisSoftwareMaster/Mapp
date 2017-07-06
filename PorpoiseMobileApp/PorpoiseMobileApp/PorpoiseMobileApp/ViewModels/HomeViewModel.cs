using System;
using PorpoiseMobileApp.ViewModels;
using MvvmCross.Core.ViewModels;
using System.Diagnostics;
using System.Collections.ObjectModel;
using System.Linq;
using System.Collections.Generic;
using Acr.Settings;
using MvvmCross.Platform;
using System.Collections;
using PorpoiseMobileApp.Client;

namespace PorpoiseMobileApp.ViewModels
{
	public class HomeViewModel : PorpoiseViewModel<HomeViewModel>
	{
		private ObservableCollection<MenuItemViewModel> menuItems;
		private ISettings _settings;

      

		public ObservableCollection<MenuItemViewModel> MenuItems
		{
			get
			{
				return menuItems;
			}
		}
        IPorpoiseWebApiClient client;
        public HomeViewModel(IPorpoiseWebApiClient client)
		{
			this._settings = Mvx.Resolve<ISettings>();
            this.client = client;
			menuItems = new ObservableCollection<MenuItemViewModel>() {
				new MenuItemViewModel (() => Resource.Profile) { MenuItem = MenuItem.Profile, Target = typeof(ProfileViewModel) },
                new MenuItemViewModel (() => Resource.First) { MenuItem = MenuItem.FirstViewFragment, Target = typeof(FirstViewModel) },
				new MenuItemViewModel (() => Resource.Activity) { MenuItem = MenuItem.Activity, Target = typeof(ActivityViewModel) },
                new MenuItemViewModel (() => Resource.Post){ MenuItem = MenuItem.LogHours },
				new MenuItemViewModel(()=> Resource.Settings) {MenuItem = MenuItem.AccountSettings, Target=typeof(AccountSettingsViewModel)},
				new MenuItemViewModel (() => Resource.Support) { MenuItem = MenuItem.Intercom, Target = typeof(ProfileViewModel)},
				new MenuItemViewModel (() => Resource.Logout) {
					MenuItem = MenuItem.Logout,
					Action = () => {
						AccountInfo.Logout();
						PerformLogoutEvent (true, "");
						ShowViewModel<LoginViewModel> ();
					}
				}

				};


		}

		public async void FlagTutorial()
		{
            

			Debug.WriteLine("Flagging tutorial in ViewModel");

			var employee = await client.GetEmployee();

			if (employee != null && employee.Successful)
			{

				Guid employeeUid = employee.Payload.EmployeeUid;

				var result = await client.FlagTutorial(employeeUid, "posting");

				if (result != null && result.Successful)
				{

					Debug.WriteLine("Tutorial flagged");

				}
			}

		}

        public void createPost(){

            ShowViewModel<ChallengeLogHourViewModel>();

        }


        public void inviteCoworker(){

            ShowViewModel<InviteCoworkerViewModel>();

        }

		private IMvxCommand _logoutCommand;

		public IMvxCommand LogoutCommand
		{
			get
			{
				return _logoutCommand ?? (_logoutCommand = new MvxCommand(Logout));
			}
		}


        public void showChallengesViewController(){

            this._settings = Mvx.Resolve<ISettings>();

            IDictionary dict = new Dictionary<string, string>();

            dict.Add("goal","14256372");

			MenuItemViewModel item =   new MenuItemViewModel(() => Resource.Post)
			{
				MenuItem = MenuItem.LogHours,
                Target = typeof(ChallengeLogHourViewModel),			
                Parameters = dict
			};

            this.menuItems[2] = item;

        }

		public void Logout()
		{
			_settings.Remove(AccountInfo.EMAILID);
			_settings.Remove(AccountInfo.PASSWORDID);
			_settings.Remove(AccountInfo.USERKEY);
			_settings.Remove(AccountInfo.TOKENKEY);
			//good place to add anylitics or segment calls saying the user logged out
			ShowViewModel<LoginViewModel>();
		}

		public event EventHandler<SdkEventArgs> LogoutEvent;
		public void PerformLogoutEvent(bool success, string message)
		{
			if (LogoutEvent != null)
			{
				try
				{
					LogoutEvent(this, new SdkEventArgs(success, message));
				}
				catch (Exception ex)
				{
					LogoutEvent(this, new SdkEventArgs(false, ex.Message));
				}
			}
		}

		public event EventHandler<SdkEventArgs> OpenAccountSettingsEvent;
		public void PerformOpenSettingsWebviewEvent(bool success)
		{
			if (OpenAccountSettingsEvent != null)
			{
				try
				{

					OpenAccountSettingsEvent(this, new SdkEventArgs(success));
				}

				catch (Exception ex)
				{
					OpenAccountSettingsEvent(this, new SdkEventArgs(false, ex.Message));
				}
			}
		}


		private IMvxCommand _selectMenuItemCommand;

		public IMvxCommand SelectMenuItemCommand
		{
			get
			{
				return _selectMenuItemCommand ?? (_selectMenuItemCommand = new MvxCommand<MenuItemViewModel>(SelectMenuItem));
			}
		}

		private void SelectMenuItem(MenuItemViewModel item)
		{
			Debug.WriteLine("REDICTERING SelectMenuItem");
			//LogPost.clear();
			if (MenuItemClicked != null)
			{
				MenuItemClicked(this, new MenuItemClickEventArgs { MenuItem = item });
			}
			if (item.Target != null)
			{
				if (item.Parameters != null)
				{
                    Debug.WriteLine("PARAMETERS IS NOT NULL");
					ShowViewModel(item.Target, item.Parameters);
				}
				else {
					ShowViewModel(item.Target);
				}
			}
			else if (item.Action != null)
			{
				item.Action();
			}
		}

		public void ShowMenuItem(MenuItemViewModel item, Dictionary<string, string> args = null)
		{Debug.WriteLine("REDICTERING ShowMenuItem");
			if (args != null)
			{
				ShowViewModel(item.Target, new MvxBundle(args));
			}
			else
			{
				ShowViewModel(item.Target);

			}
		}

		public event EventHandler<MenuItemClickEventArgs> MenuItemClicked;

		public MenuItemViewModel GetMenuItemForViewModelType(Type type)
		{
			var result = MenuItems.FirstOrDefault(x => x.Target == type);
			return result;
		}

		public void GoToHome()
		{
			ShowViewModel<ActivityViewModel>();
		}
	}
}

