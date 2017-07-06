using System;

using Foundation;
using MvvmCross.Binding.iOS.Views;
using UIKit;

namespace PorpoiseMobileApp.iOS
{
	public partial class EmptyPostItemCellController : MvxTableViewCell
	{


		public EmptyPostItemCellController() : base()
		{
		}

		public EmptyPostItemCellController(IntPtr handle) : base(handle)
		{

		}

		static bool UserInterfaceIdiomIsPhone
		{
			get { return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone; }
		}


	}
}
