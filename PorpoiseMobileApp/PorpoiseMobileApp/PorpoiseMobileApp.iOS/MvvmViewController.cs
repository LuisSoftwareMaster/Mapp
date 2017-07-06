using System;
using MvvmCross.iOS.Views;
using MvvmCross.Core.ViewModels;
using System.Collections.Generic;
using UIKit;
using MvvmCross.Platform;
using Foundation;
using CoreGraphics;
using MvvmCross.Binding.BindingContext;

namespace PorpoiseMobileApp.iOS
{
	public delegate void InjectParametersDelegate(IDictionary<string, string> parms);

	public abstract class MvvmViewController<TViewModel> : MvxViewController<TViewModel>, IDirty where TViewModel : MvxViewModel
	{
		private MvxFluentBindingDescriptionSet<MvvmViewController<TViewModel>, TViewModel> bindingSet;

		protected MvvmViewController(IntPtr handle) : base(handle)
		{
			Initialize();
		}

		protected MvvmViewController(string nibName, NSBundle bundle) : base(nibName, bundle)
		{
			Initialize();
		}

		protected MvvmViewController()
		{
			Initialize();
		}

		void Initialize()
		{
			this.bindingSet = this.CreateBindingSet<MvvmViewController<TViewModel>, TViewModel>();
		}

		public MvxFluentBindingDescriptionSet<MvvmViewController<TViewModel>, TViewModel> Bindings
		{
			get
			{
				return bindingSet;
			}
		}

		public override void ViewDidLoad()
		{
			if (this.Request == null)
			{
				this.Request = new MvxViewModelRequest<TViewModel>(null, null, new MvxRequestedBy());
			}

			if (OnInjectParameters != null)
			{
				if (this.Request.ParameterValues == null)
				{
					this.Request.ParameterValues = new Dictionary<string, string>();
				}
				OnInjectParameters(this.Request.ParameterValues);
			}

			base.ViewDidLoad();
			if (RespondToViewModelChanges)
			{

				base.ViewModel.PropertyChanged += HandleDirty;
			}
		}

		public event InjectParametersDelegate OnInjectParameters;

		bool _respondsToVMchanges;

		protected virtual bool RespondToViewModelChanges
		{
			get
			{
				return true;
			}
			set
			{
				_respondsToVMchanges = value;
			}
		}

		protected virtual void HandleDirty(object sender, System.ComponentModel.PropertyChangedEventArgs e)
		{
			this.IsDirty = true;
		}

		private Dictionary<string, Action<UIStoryboardSegue>> segueSetups = new Dictionary<string, Action<UIStoryboardSegue>>();

		protected void AddSegue<TTargetViewModel>(string name, Action<TTargetViewModel> setup) where TTargetViewModel : class, IMvxViewModel
		{
			if (!Mvx.CanResolve<TTargetViewModel>())
			{
				throw new ArgumentException("Unknown ViewModel", typeof(TTargetViewModel).FullName);
			}

			Action<UIStoryboardSegue> segueSetup = segue =>
			{
				var nextCtrl = segue.DestinationViewController as MvxViewController;
				if (nextCtrl != null)
				{
					var viewModel = Mvx.Resolve<TTargetViewModel>();
					setup(viewModel);
					nextCtrl.Request = new MvxViewModelInstanceRequest(viewModel);
				}
			};

			segueSetups.Add(name, segueSetup);
		}

		public override void PrepareForSegue(UIStoryboardSegue segue, Foundation.NSObject sender)
		{
			if (!string.IsNullOrEmpty(segue.Identifier) && segueSetups.ContainsKey(segue.Identifier))
			{
				segueSetups[segue.Identifier](segue);
			}
		}

		protected UIButton MakeInputErrorInfo(Func<string> errorMessage)
		{
			var errorInfoButton = new UIButton(UIButtonType.DetailDisclosure);
			errorInfoButton.Frame = new CGRect(0f, 0f, errorInfoButton.Frame.Size.Width + 10, errorInfoButton.Frame.Size.Height);
			errorInfoButton.ContentMode = UIViewContentMode.Left;
			errorInfoButton.TintColor = UIColor.Red;
			errorInfoButton.TouchUpInside += (sender, e) => this.Alert("Input Error", errorMessage(), null, null);
			return errorInfoButton;
		}

		#region IDirty implementation

		public virtual bool IsDirty
		{
			get;
			protected set;
		}

		void IDirty.Cleanup()
		{
			this.Cleanup();
			IsDirty = false;
		}

		public virtual void Cleanup()
		{
		}

		#endregion
	}
}

