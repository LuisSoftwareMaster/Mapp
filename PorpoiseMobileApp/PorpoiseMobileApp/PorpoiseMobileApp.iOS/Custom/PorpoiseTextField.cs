using System;
using Foundation;
using UIKit;

namespace PorpoiseMobileApp.iOS
{
    public partial class PorpoiseTextField: UITextField
    {
		public PorpoiseTextField(IntPtr handle) : base (handle)
        {
			//this.WeakDelegate = this;
			
		}

		[Export("textFieldShouldReturn:")]
		public bool TextFieldShouldReturn(UITextField textView)
		{
			Console.WriteLine("SHOULD RETURN");
			textView.ResignFirstResponder();
			return true;
		}

		[Export("textViewDidChange:")]
		public void MyTextViewChanged(UITextView textView)
		{
            Console.WriteLine("Text changed");	
		}
    }
}
