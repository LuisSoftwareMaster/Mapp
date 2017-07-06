using System;
using System.Diagnostics;
using UIKit;

namespace PorpoiseMobileApp.iOS
{
	public class PorpoiseTextViewDelegate: UITextViewDelegate
	{
		public PorpoiseTextViewDelegate()
		{
		}

		public override bool ShouldBeginEditing(UITextView textView)
		{
			Debug.WriteLine("BEGIN EDITING");

			return base.ShouldBeginEditing(textView);

		}
	}
}
