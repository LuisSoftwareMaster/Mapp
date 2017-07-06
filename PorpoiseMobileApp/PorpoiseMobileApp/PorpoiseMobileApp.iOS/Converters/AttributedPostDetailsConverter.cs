using System;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using Foundation;
using MvvmCross.Platform.Converters;
using PorpoiseMobileApp.Models;
using UIKit;


namespace PorpoiseMobileApp.iOS
{
	public class AttributedPostDetailsConverter : IMvxValueConverter
	{

		double HourAmount
		{
			get;
			set;
		}

		string OrganisationName
		{
			get;
			set;
		}

		public AttributedPostDetailsConverter()
		{
			
		}

		public static Regex regex = new Regex("(.*){(.*)}(.*){(.*)}(.*){(.*)}(.*)");
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			var hourAmountAttributes = new UIStringAttributes
			{
				ForegroundColor = PorpoiseColors.Orange,


			};


			var hourLog = value as HourLog;

			Debug.WriteLine("GOAL NAME: "+hourLog.GoalName+" ORGANIZATION: "+hourLog.OrganisationName+" CONTRIBUTED AMOUNT: "+hourLog.ContributionAmount+ " POSTER: "+hourLog.EmployeeName+" GOAL METRIC: "+hourLog.GoalMetric);
	

			if ((!string.IsNullOrEmpty(hourLog.GoalMetric) && !hourLog.GoalMetric.ToLower().Equals("none") && !hourLog.GoalMetric.ToLower().Equals("posts")) && (!string.IsNullOrEmpty(hourLog.OrganisationName)))
			{
				var sentence = "{0} TOWARDS {1} WITH {2}!";
				var split = regex.Split(sentence).Where(x => !string.IsNullOrEmpty(x));

				string goalName = hourLog.GoalName.ToUpper();

				string goalMetric = "";


				if (hourLog.GoalMetric.ToLower().Equals("other"))
				{

					goalMetric = hourLog.otherGoalMetricLabel;

				}
				else
				{

					goalMetric = hourLog.GoalMetric;

				}

				Debug.WriteLine("Contribution Amount " + hourLog.ContributionAmount);

				var formatted = string.Format(sentence, (hourLog.ContributionAmount + " " + goalMetric.ToUpper()).ToString(), goalName, hourLog.OrganisationName.ToString().ToUpper());

				var attributed = new NSMutableAttributedString(formatted);

				int index = -1;

				Debug.WriteLine("SPLIT " + split.Count());

				foreach (var fragment in split)
				{
					Debug.WriteLine("FRAGMENT VALUE: " + fragment);

					if (Char.IsDigit(fragment[0]))
					{
						Debug.WriteLine("FRAGMENT VALUE " + fragment);

						var result = string.Format("{" + fragment + "}", (hourLog.ContributionAmount + " " + goalMetric.ToUpper()).ToString(), goalName, hourLog.OrganisationName.ToString().ToUpper());
						index = formatted.IndexOf(result, index + 1);
						attributed.AddAttributes(hourAmountAttributes, new NSRange(index, result.Length));
					}


				}

				Debug.WriteLine("ATTRIBUTED " + attributed);



				return attributed;

			}

			else if ((!string.IsNullOrEmpty(hourLog.GoalMetric) && !hourLog.GoalMetric.ToLower().Equals("none") && !hourLog.GoalMetric.ToLower().Equals("posts")) && (string.IsNullOrEmpty(hourLog.OrganisationName)))
			{

				string goalMetric = "";


				if (hourLog.GoalMetric.ToLower().Equals("other"))
				{

					goalMetric = hourLog.otherGoalMetricLabel;

				}
				else {

					goalMetric = hourLog.GoalMetric;
				
				}

				Debug.WriteLine("VALID METRIC AND NO ORGANIZATION");

				var sentence = "{0} TOWARDS {1}!";

				var split = regex.Split(sentence).Where(x => !string.IsNullOrEmpty(x));

				string goalName = hourLog.GoalName.ToUpper();

				Debug.WriteLine("Contribution Amount " + hourLog.ContributionAmount);

				var formatted = string.Format(sentence, (hourLog.ContributionAmount + " " + goalMetric.ToUpper()).ToString(), goalName);

				var attributed = new NSMutableAttributedString(formatted);

				int index = -1;

				Debug.WriteLine("SPLIT " + split.Count());

				foreach (var fragment in split)
				{
					Debug.WriteLine("FRAGMENT VALUE: " + fragment);

					if (Char.IsDigit(fragment[0]))
					{
						Debug.WriteLine("FRAGMENT VALUE " + fragment);

						var result = string.Format("{" + fragment + "}", (hourLog.ContributionAmount + " " + goalMetric.ToUpper()).ToString(), goalName);
						index = formatted.IndexOf(result, index + 1);
						attributed.AddAttributes(hourAmountAttributes, new NSRange(index, result.Length));
					}


				}

				Debug.WriteLine("ATTRIBUTED " + attributed);



				return attributed;

			}


			else if ((string.IsNullOrEmpty(hourLog.GoalMetric) || hourLog.GoalMetric.ToLower().Equals("none") || hourLog.GoalMetric.ToLower().Equals("posts")) && (!string.IsNullOrEmpty(hourLog.OrganisationName)))
			{

				Debug.WriteLine("NO METRIC AND VALID ORGANIZATION");

				var sentence = "POSTED TOWARDS {0} WITH {1}!";

				var split = regex.Split(sentence).Where(x => !string.IsNullOrEmpty(x));

				string goalName = hourLog.GoalName.ToUpper();



				var formatted = string.Format(sentence, goalName, hourLog.OrganisationName);

				var attributed = new NSMutableAttributedString(formatted);

				int index = -1;

				Debug.WriteLine("SPLIT " + split.Count());

				foreach (var fragment in split)
				{
					Debug.WriteLine("FRAGMENT VALUE: " + fragment);

					if (Char.IsDigit(fragment[0]))
					{
						Debug.WriteLine("FRAGMENT VALUE " + fragment);

						var result = string.Format("{" + fragment + "}", goalName, hourLog.OrganisationName);
						index = formatted.IndexOf(result, index + 1);
						attributed.AddAttributes(hourAmountAttributes, new NSRange(index, result.Length));
					}


				}

				Debug.WriteLine("ATTRIBUTED " + attributed);





				return attributed;


			}
			else if ((string.IsNullOrEmpty(hourLog.GoalMetric) || hourLog.GoalMetric.ToLower().Equals("none") || hourLog.GoalMetric.ToLower().Equals("posts")) && (string.IsNullOrEmpty(hourLog.OrganisationName))) { 
			
				Debug.WriteLine("NO METRIC AND VALID ORGANIZATION");

				var sentence = "POSTED TOWARDS {0}!";

				var split = regex.Split(sentence).Where(x => !string.IsNullOrEmpty(x));

				string goalName = hourLog.GoalName.ToUpper();



				var formatted = string.Format(sentence, goalName);

				var attributed = new NSMutableAttributedString(formatted);

				int index = -1;

				Debug.WriteLine("SPLIT " + split.Count());

				foreach (var fragment in split)
				{
					Debug.WriteLine("FRAGMENT VALUE: " + fragment);

					if (Char.IsDigit(fragment[0]))
					{
						Debug.WriteLine("FRAGMENT VALUE " + fragment);

						var result = string.Format("{" + fragment + "}", goalName);
						index = formatted.IndexOf(result, index + 1);
						attributed.AddAttributes(hourAmountAttributes, new NSRange(index, result.Length));
					}


				}

				Debug.WriteLine("ATTRIBUTED " + attributed);





				return attributed;

			
			}
		

			return null;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}