using Foundation;
using System;
using UIKit;
using System.Diagnostics;

namespace PorpoiseMobileApp.iOS
{
	

	public partial class PorpoiseTextView : UITextView
    {
        public PorpoiseTextView (IntPtr handle) : base (handle)
        {
			//this.WeakDelegate = this;
			this.Editable = true;
        }



		public override void TouchesBegan(NSSet touches, UIEvent evt)
		{
			base.TouchesBegan(touches, evt);

			//this.EndEditing(true);
		}



		public override bool ShouldChangeTextInRange(UITextRange inRange, string replacementText)
		{
			if (replacementText.Equals("\n")) {

				this.ResignFirstResponder();
			
			}

			return base.ShouldChangeTextInRange(inRange, replacementText);
		}

        public override bool CanBecomeFirstResponder => true;



    }
}