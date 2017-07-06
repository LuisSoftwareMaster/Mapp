

using System;
using Acr.Settings;
using MvvmCross.Platform;

namespace PorpoiseMobileApp.ViewModels
{
	public class AccountSettingsViewModel : PorpoiseViewModel<AccountSettingsViewModel>
	{
		private ISettings _settings;
		public AccountSettingsViewModel()
		{
			this._settings = Mvx.Resolve<ISettings>();
		}
		public void Logout()
		{
			_settings.Remove(AccountInfo.EMAILID);
			_settings.Remove(AccountInfo.PASSWORDID);
			_settings.Remove(AccountInfo.USERKEY);
			_settings.Remove(AccountInfo.TOKENKEY);
			ShowViewModel<LoginViewModel>();
		}

		public string SettingsUrl
		{
			get
			{
				if (AccountInfo.UserId.HasValue)
				{
					return "https://connect.giving.company/"+AccountInfo.UserId.Value+"/settings_app";
				}
				else
				{
					return "https://connect.giving.company/join";
				}

			}
		}

		public void GoBackToProfile()
		{
			ShowViewModel<HomeViewModel>();
		}
	}

}