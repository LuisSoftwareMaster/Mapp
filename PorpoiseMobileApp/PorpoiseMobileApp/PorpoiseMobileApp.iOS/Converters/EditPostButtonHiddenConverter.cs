using System;
using System.Globalization;
using System.Threading.Tasks;
using MvvmCross.Platform.Converters;
using PorpoiseMobileApp.Client;

namespace PorpoiseMobileApp.iOS
{
	public class EditPostButtonHiddenConverter : IMvxValueConverter
	{
		private string userID;
		public EditPostButtonHiddenConverter(string userID)
		{

			this.userID = userID;


		}

		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			string posterId = value.ToString();

				//if posterId equals logged in user; hidden = false
			if (posterId.Equals(userID))
				{
					return false;
				}
				else
				{
					//hidden = true;
					return true;
				}
			

		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}

