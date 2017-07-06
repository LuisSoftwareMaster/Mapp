using System;
using PorpoiseMobileApp.ViewModels;
using MvvmCross.Core.ViewModels;
using System.Diagnostics;
using System.Collections.ObjectModel;
using System.Linq;
using System.Collections.Generic;
using Acr.Settings;
using MvvmCross.Platform;
namespace PorpoiseMobileApp.ViewModels
{
    public class HomeViewModelAndroid: PorpoiseViewModel<HomeViewModelAndroid>
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
		public HomeViewModelAndroid()
		{
			this._settings = Mvx.Resolve<ISettings>();
			menuItems = new ObservableCollection<MenuItemViewModel>() {
				new MenuItemViewModel (() => Resource.Profile) { MenuItem = MenuItem.Profile, Target = typeof(ProfileViewModel) },
                new MenuItemViewModel (() => Resource.First) { MenuItem = MenuItem.FirstViewFragment, Target = typeof(FirstViewModel) },
				new MenuItemViewModel (() => Resource.Activity) { MenuItem = MenuItem.Activity, Target = typeof(ActivityViewModel) },
				new MenuItemViewModel (() => Resource.Post){ MenuItem = MenuItem.LogHours, Target = typeof(LogHoursViewModel) },
				new MenuItemViewModel(()=> Resource.Settings) {MenuItem = MenuItem.AccountSettings, Target=typeof(AccountSettingsViewModel)},
				new MenuItemViewModel (() => Resource.Support) { MenuItem = MenuItem.Intercom, Target = typeof(ProfileViewModel)},
				new MenuItemViewModel (() => Resource.Logout) {
					MenuItem = MenuItem.Logout,
					Action = () => {
						AccountInfo.Logout();
						PerformLogoutEvent (true, "");
						//ShowViewModel<LoginViewModel> ();
					}
				},
				//new MenuItemViewModel(() => Resource.Challenges) { MenuItem = MenuItem.Challenges, Target = typeof(ChallengeLogHourViewModel) }
			};
		}

		private IMvxCommand _logoutCommand;

		public IMvxCommand LogoutCommand
		{
			get
			{
				return _logoutCommand ?? (_logoutCommand = new MvxCommand(Logout));
			}
		}

		public void Logout()
		{
			_settings.Remove(AccountInfo.EMAILID);
			_settings.Remove(AccountInfo.PASSWORDID);
			_settings.Remove(AccountInfo.USERKEY);
			_settings.Remove(AccountInfo.TOKENKEY);
			//good place to add anylitics or segment calls saying the user logged out
			//ShowViewModel<LoginViewModel>();
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
			if (MenuItemClicked != null)
			{
				MenuItemClicked(this, new MenuItemClickEventArgs { MenuItem = item });
			}
			if (item.Target != null)
			{
				if (item.Parameters != null)
				{
					ShowViewModel(item.Target, item.Parameters);
				}
				else
				{
					ShowViewModel(item.Target);
				}
			}
			else if (item.Action != null)
			{
				item.Action();
			}
		}

		public void ShowMenuItem(MenuItemViewModel item, Dictionary<string, string> args = null)
		{
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
			//ShowViewModel<ActivityViewModel>();
		}
    }
}
