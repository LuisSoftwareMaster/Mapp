using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PorpoiseMobileApp
{
	public static class Validation
	{
		private static Regex regex = new Regex(@"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
					@"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$", RegexOptions.CultureInvariant | RegexOptions.IgnoreCase);

		public static bool IsEmail(string email)
		{
			return regex.IsMatch(email);
		}

		public static bool IsPassword(string password)
		{
			return !string.IsNullOrEmpty(password) && password.Length >= 8;
		}

		public static bool IsNumeric(string text)
		{
			if (string.IsNullOrEmpty(text))
			{
				return false;
			}
			double number = 0;
			return double.TryParse(text, out number) && number > 0;
		}

		//TODO: Check if iOS version has removed the Add(-1.0) and test.
		public static bool IsValidDate(string dateString)
		{
			if (string.IsNullOrEmpty(dateString))
			{
				return false;
			}
			var input = DateTime.Parse(dateString);
			//is the date earlier than last year or greater than today
			if (input < DateTime.Today.AddYears(-1).AddDays(-1.0) || input > DateTime.Today.AddDays(1.0))
			{
				return false;
			}
			return true;
		}
	}
}
