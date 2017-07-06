using System;
using Foundation;
using PorpoiseMobileApp.Models;
using UIKit;

namespace PorpoiseMobileApp.iOS
{
	class GoalTapDelegate : UIGestureRecognizerDelegate
	{
		private Action action;

		public GoalTapDelegate(Action action)
		{
			this.action = action;
		}

		public override bool ShouldBegin(UIGestureRecognizer recognizer)
		{
			action();
			return true;
		}

		public override bool ShouldRecognizeSimultaneously(UIGestureRecognizer gestureRecognizer, UIGestureRecognizer otherGestureRecognizer)
		{
			return true;
		}
	}
}