using System;
using UIKit;
using PorpoiseMobileApp.ViewModels;
using MvvmCross.iOS.Views;
using System.Collections.Generic;
using System.Linq;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;

namespace PorpoiseMobileApp.iOS
{
	public class PorpoiseTabNavigationController : UINavigationController, IDirty
	{
		public PorpoiseTabNavigationController(MenuItemViewModel menuItemVM)
		{
			this.MenuItem = menuItemVM.MenuItem;
			this.MenuViewModel = menuItemVM;
		}

		public MenuItemViewModel MenuViewModel { get; private set; }

		public MenuItem MenuItem
		{
			get;
			private set;
		}

		#region IDirty implementation

		public bool IsDirty
		{
			get
			{
				var ctrl = VisibleViewController as IDirty;
				return ctrl != null && ctrl.IsDirty;
			}
		}

		public void Cleanup()
		{
			var ctrl = VisibleViewController as IDirty;
			if (ctrl != null)
			{
				ctrl.Cleanup();
			}
		}

		#endregion
	}

	public class myclass : IMvxIosNavigator
	{
		public void Close(IMvxViewModel toClose)
		{
			throw new NotImplementedException();
		}

		public void NavigateTo(MvxViewModelRequest request)
		{
			throw new NotImplementedException();
		}
	}
}

