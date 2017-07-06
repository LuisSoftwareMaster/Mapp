using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using MvvmCross.Platform.Converters;
using PorpoiseMobileApp.Models;
using UIKit;
namespace PorpoiseMobileApp.iOS
{
	public class GivenWelldoneOrangeImageConverter: IMvxValueConverter, INotifyPropertyChanged
	{
		public GivenWelldoneOrangeImageConverter()
		{
		}

		public event PropertyChangedEventHandler PropertyChanged;

		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			var hourLog = value as Welldones[];

			if (hourLog != null && hourLog.Length > 0)
			{

				foreach (Welldones aux in hourLog) {

					if (aux.UserId.Equals(AccountInfo.UserId.ToString())){

						Debug.WriteLine("RETURNING ORANGE");

						return new UIImage("wellDoneOrange.png");
					
					}
				
				}

			}
			Debug.WriteLine("RETURNING GRAY");
			return new UIImage("wellDoneGray.png");
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{

			Debug.WriteLine("TRYING TO CONVERT BACK");

			throw new NotImplementedException();
		}

		protected void OnPropertyChanged(object o)
		{
			PropertyChangedEventHandler handler = PropertyChanged;
			if (handler != null)
			{
				Debug.WriteLine("PROPERTY CHANGED");
			}
		}

	}
}
