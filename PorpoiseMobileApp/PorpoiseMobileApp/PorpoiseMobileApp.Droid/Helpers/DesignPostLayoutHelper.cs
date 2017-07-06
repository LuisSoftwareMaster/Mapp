using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Text;
using System.Text.RegularExpressions;
using Android.Text.Style;
using PorpoiseMobileApp.Models;
using Android.Graphics;

namespace PorpoiseMobileApp.Droid.Helpers
{
	public static class DesignPostLayoutHelper
	{
		public static Regex regex = new Regex("(.*){(.*)}(.*){(.*)}(.*){(.*)}(.*)", RegexOptions.CultureInvariant | RegexOptions.Compiled);
		public static string sentenceStr = "";


		public static void SetupDetailsTextView(Context context, TextView details, HourLog post)
		{
			SpannableFactory factory = new SpannableFactory();
			if (post.NumberOfHours == 1)
			{
				sentenceStr = "Posted {0} hour towards {1} with {2}!";
			}
			else
			{
				sentenceStr = "Posted {0} hours towards {1} with {2}!";
			}
			var split = regex.Split(sentenceStr).Where(x => !string.IsNullOrEmpty(x));

			var formatted = string.Format(sentenceStr, post.NumberOfHours, post.GoalName, post.OrganisationName);

			ISpannable spanned = factory.NewSpannable(formatted);

			int index = -1;

			foreach (var fragment in split)
			{
				if (Char.IsDigit(fragment[0]))
				{
					Console.WriteLine("FRAGMENT INSIDE IF " + fragment);
					var result = string.Format("{" + fragment + "}", post.NumberOfHours, post.GoalName, post.OrganisationName);
					index = formatted.IndexOf(result, index + 1);
					//spanned.SetSpan(new ForegroundColorSpan(Color.Blue), index, index + result.Length, SpanTypes.ExclusiveExclusive);

				}
				else
				{

					Console.WriteLine("FRAGMENT INSIDE ELSE " + fragment);

				}

				//spanned.SetSpan(new ForegroundColorSpan(Color.Blue), index, index + fragment.Length, SpanTypes.ExclusiveExclusive);

			}

            spanned.SetSpan(new ForegroundColorSpan(context.Resources.GetColor(Resource.Color.post_orange)), 0, spanned.ToString().Length, SpanTypes.ExclusiveExclusive);
			spanned.SetSpan(new ForegroundColorSpan(context.Resources.GetColor(Resource.Color.post_gray)), spanned.ToString().IndexOf("towards"), spanned.ToString().IndexOf("towards") + "towards".Length, SpanTypes.ExclusiveExclusive);
           
            spanned.SetSpan(new ForegroundColorSpan(context.Resources.GetColor(Resource.Color.post_gray)), spanned.ToString().IndexOf("with"), spanned.ToString().IndexOf("with") + "with".Length, SpanTypes.ExclusiveExclusive);
            if (post.GoalName != null)
            {
                spanned.SetSpan(new ForegroundColorSpan(context.Resources.GetColor(Resource.Color.post_orange)), spanned.ToString().IndexOf(post.GoalName), spanned.ToString().IndexOf(post.GoalName) + post.GoalName.Length, SpanTypes.ExclusiveExclusive);
            }
                if (post.OrganisationName != null)
            {
                spanned.SetSpan(new ForegroundColorSpan(context.Resources.GetColor(Resource.Color.post_orange)), spanned.ToString().IndexOf(post.OrganisationName+"!"), spanned.ToString().IndexOf(post.OrganisationName+"!") + post.OrganisationName.Length, SpanTypes.ExclusiveExclusive);
            }

           // 
			spanned.SetSpan(new ForegroundColorSpan(context.Resources.GetColor(Resource.Color.post_gray)), spanned.ToString().IndexOf("!"), spanned.ToString().IndexOf("!") + "!".Length, SpanTypes.ExclusiveExclusive);

			//Pattern url = Pattern("(https?)://[-a-zA-Z0-9+&@#/%?=~_|!:,.;]*[-a-zA-Z0-9+&@#/%=~_|]");
			//Matcher matcher = url.matcher(urlString.toLowerCase());

			string aux = spanned.ToString();

			SpannableString formattedSpan = new SpannableString(aux);
			string pat = "(https?)://[-a-zA-Z0-9+&@#/%?=~_|!:,.;]*[-a-zA-Z0-9+&@#/%=~_|]";

			// Instantiate the regular expression object.
			Regex r = new Regex(pat, RegexOptions.IgnoreCase);
			Match matcher = r.Match(aux.ToLower());


			//Here you save the string in upper case
			SpannableString stringUpperCase = new SpannableString(formatted.ToString().ToUpper());

			foreach (Match ItemMatch in r.Matches(aux.ToLower()))
			{

				Console.WriteLine(ItemMatch);

			}

			details.SetText(toUpperCase(spanned), Android.Widget.TextView.BufferType.Spannable);

			//details.Text = details.Text.ToUpper();
		}

		private static ISpannable toUpperCase(ISpannable s)
		{
			Java.Lang.Object[] spans = s.GetSpans(0, s.Length(), Java.Lang.Class.FromType(typeof(Java.Lang.Object)));

			SpannableString spannableString = new SpannableString(s.ToString().ToUpper());

			// reapply the spans to the now uppercase string
			foreach (Java.Lang.Object span in spans)
			{
				spannableString.SetSpan(span,s.GetSpanStart(span),s.GetSpanEnd(span),0);
			}

			return spannableString;

		}
	}

}