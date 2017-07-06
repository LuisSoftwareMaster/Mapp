using System;
using System.Diagnostics;
using UIKit;

namespace PorpoiseMobileApp.iOS
{
	public class PorpoiseImagePicker: UIImagePickerController
	{
		public PorpoiseImagePicker()
		{
		}

		public override void TouchesBegan(Foundation.NSSet touches, UIEvent evt)
		{
			base.TouchesBegan(touches, evt);

			Debug.WriteLine("UIIMAGE PICKER TOUCH BEGAN");
		}

		public override void TouchesMoved(Foundation.NSSet touches, UIEvent evt)
		{
			base.TouchesMoved(touches, evt);

			Debug.WriteLine("UIIMAGE PICKER TOUCH MOVED");
		}
	}
}
