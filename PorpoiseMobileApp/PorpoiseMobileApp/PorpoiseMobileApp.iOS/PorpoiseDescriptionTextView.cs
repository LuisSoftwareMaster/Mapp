using Foundation;
using System;
using UIKit;
using System.Diagnostics;

namespace PorpoiseMobileApp.iOS
{
	public partial class PorpoiseDescriptionTextView : UITextView
	{
		public PorpoiseDescriptionTextView(IntPtr handle) : base(handle)
		{

			Debug.WriteLine("PorpoiseDescriptionTextView INSTANTIATED");

	

		}
		[Export("textViewDidChange:")]
		public void MyTextViewChanged(UITextView textView)
		{
			Debug.WriteLine("EDITING TEXT VIEW");

		}

		public override void DidChange(NSString forKey, NSKeyValueSetMutationKind mutationKind, NSSet objects)
		{



			base.DidChange(forKey, mutationKind, objects);

			if(this.Text.Equals("")) {

				this.Text = "Add a description";

				this.TextColor = UIColor.LightGray;
			}
		}




		public override bool ResignFirstResponder()
		{
			if(this.Text.Equals("")) {
	this.Text = "Add a description";

	this.TextColor = UIColor.LightGray;
			}

			return base.ResignFirstResponder();
		}

public override void TouchesBegan(NSSet touches, UIEvent evt)
{
	this.ResignFirstResponder();
}

		public override bool BecomeFirstResponder()
		{
			Debug.WriteLine("IS FIRST RESPONDER "+this.Text);

			if (this.Text.Equals("Add a description")) {

				this.Text = "";

				this.TextColor = UIColor.Black;
			
			}
			else if(this.Text.Equals("")) {

				this.Text = "Add a description";

                this.TextColor = UIColor.LightGray;
			
			}

			return base.BecomeFirstResponder();
		}
	}

}