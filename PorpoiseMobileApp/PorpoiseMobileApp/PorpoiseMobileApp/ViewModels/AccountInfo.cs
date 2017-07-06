using System;
using Acr.Settings;
using MvvmCross.Platform;
using PorpoiseMobileApp.Services;
using System.Collections.Generic;

namespace PorpoiseMobileApp
{
	public static class AccountInfo
	{
		public const string EMAILID = "EmailId";
		public const string PASSWORDID = "PasswordId";
		public const string USERKEY = "UserId";
		public const string COMPANYKEY = "CompanyId";
		public const string TOKENKEY = "auth.token";
		public const string URLKEY = "UrlScheme";
        public static bool show_profile_tutorial;
        public static bool show_posting_tutorial;
		private static ISettings _settings;
		private static IEncryptionService _encryption;

		private static string _password;
		private static string _email;
		private static Guid? _userId;
		private static Guid? _companyId;
		private static Guid? _token;
		private static string _url;

		private static bool isTokenLoaded = false;
		private static bool isPwLoaded = false;
		private static bool isEmailLoaded = false;
		private static bool isUserLoaded = false;
		private static bool isCompanyIdLoaded = false;
		//TODO: Encrypt this
		public static string CompanyName { get; set; }

		static AccountInfo()
		{
			_settings = Mvx.Resolve<ISettings>();
			_encryption = Mvx.Resolve<IEncryptionService>();
		}

		public static Guid? UserId
		{
			get
			{
				//if not loaded and null, get it from settings
				if (!isUserLoaded)
				{
					var usersrc = _settings.Get<string>(USERKEY);
					if (!string.IsNullOrEmpty(usersrc))
					{
						_companyId = Guid.Parse(_encryption.Decrypt(usersrc));
						isUserLoaded = true;
					}
				}
				return _userId;
			}
			set
			{
				//encrypt it
				var encrypted = _encryption.Encrypt(value.ToString());
				//store it
				_settings.Set(USERKEY, encrypted);
				//cache it;
				isUserLoaded = true;
				_userId = value;
			}
		}

		public static Guid? CompanyId
		{
			get
			{
				if (!isCompanyIdLoaded)
				{
					var compsrc = _settings.Get<string>(COMPANYKEY);
					if (!string.IsNullOrEmpty(compsrc))
					{
						_companyId = Guid.Parse(_encryption.Decrypt(compsrc));
						isCompanyIdLoaded = true;
					}
				}
				return _companyId;
			}
			set
			{
				//encrypt it
				var encrypted = _encryption.Encrypt(value.ToString());
				//store it
				_settings.Set(COMPANYKEY, encrypted);
				//cache it;
				isCompanyIdLoaded = true;
				_companyId = value;
			}
		}

		public static Guid? Token
		{
			get
			{
				//if not loaded and null, get it from settings
				if (!isTokenLoaded)
				{
					var tokensrc = _settings.Get<Guid>(TOKENKEY);
					if (!Guid.Equals(Guid.Empty, tokensrc))
					{
						_token = tokensrc;
						isTokenLoaded = true;
					}
				}
				return _token;
			}
			set
			{
				//store it
				_settings.Set(TOKENKEY, value);
				//cache it;
				isTokenLoaded = true;
				_token = value;
			}
		}


		public static string Password
		{
			get
			{
				//if not loaded and null, get it from settings
				if (!isPwLoaded)
				{
					return _encryption.Decrypt(_settings.Get<string>(PASSWORDID));
				}
				return _password;
			}
			set
			{
				//encrypt it
				var encrypted = _encryption.Encrypt(value);
				//store it
				_settings.Set(PASSWORDID, encrypted);
				//cache it;
				isPwLoaded = true;
				_password = value;
			}

		}

		public static string Email
		{
			get
			{
				//if not loaded and null, get it from settings
				if (!isEmailLoaded)
				{
					return _encryption.Decrypt(_settings.Get<string>(EMAILID));
				}
				return _email;
			}
			set
			{
				//encrypt it
				var encrypted = _encryption.Encrypt(value);
				//store it
				_settings.Set(EMAILID, encrypted);
				//cache it;
				isEmailLoaded = true;
				_email = value;
			}
		}

		public static string OpenAppUrl
		{
			get
			{
				return (_settings.Get<string>(URLKEY));
			}
			set
			{
				_settings.Set(URLKEY, value);
				_url = value;
			}
		}

		public static void Logout()
		{
			_settings.Remove(EMAILID);
			_settings.Remove(TOKENKEY);
			_settings.Remove(PASSWORDID);
			_settings.Remove(USERKEY);
			_email = null;
			_password = null;
			_token = null;
			isTokenLoaded = false;
			isPwLoaded = false;
			isEmailLoaded = false;

		}
	}
}

