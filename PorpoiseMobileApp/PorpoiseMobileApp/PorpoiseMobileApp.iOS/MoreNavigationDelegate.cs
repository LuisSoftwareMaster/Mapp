using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using PorpoiseMobileApp.ViewModels;
using MvvmCross.iOS.Views;
using System.Collections.Generic;
using System.Linq;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;

namespace PorpoiseMobileApp.iOS
{

	public class MoreNavigationDelegate : UINavigationControllerDelegate
	{

		public MoreNavigationDelegate ()
		{
			
		}

		public override void WillShowViewController (UINavigationController navigationController, UIViewController viewController, bool animated)
		{
			if (!string.Equals (viewController.Title, "More")) {
				//hide back button when in the more menu
				viewController.NavigationItem.SetHidesBackButton (true, false);
			}
		}
	}

	public class MoreTableViewDelegate : UITableViewDelegate{

		public MoreTableViewDelegate ()
		{
		}

		public MoreTableViewDelegate (UIViewController selected)
		{
		}

		public override void WillDisplay (UITableView tableView, UITableViewCell cell, NSIndexPath indexPath)
		{
		}

		public override void RowSelected (UITableView tableView, NSIndexPath indexPath)
		{
		}
	}

	
}
