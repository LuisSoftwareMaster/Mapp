using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PorpoiseMobileApp
{
	public class MenuItemClickEventArgs : EventArgs
	{
		public MenuItemViewModel MenuItem { get; set; }
	}

	public class MenuItemViewModel : INotifyPropertyChanged
	{
		private Func<string> title;

		internal MenuItemViewModel(Func<string> title)
		{
			this.title = title;
		}

		public string Title
		{
			get
			{
				return title();
			}
		}

		public MenuItem MenuItem { get; set; }

		public Type Target { get; set; }

		public Action Action { get; set; }

		public object Parameters {
			get;
			set;
		}

		public void Refresh()
		{
			DoPropertyChanged("Title");
		}

		private void DoPropertyChanged([CallerMemberName] string prop = null) {
			if (PropertyChanged != null) {
				PropertyChanged(this, new PropertyChangedEventArgs(prop));
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;
	}

	public enum MenuItem
	{
		Profile, LogHours, Activity, Logout,
		AccountSettings,
		Intercom,Challenges, 
        FirstViewFragment
	}
}

