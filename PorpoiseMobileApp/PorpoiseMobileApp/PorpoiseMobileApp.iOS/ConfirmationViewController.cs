using Foundation;
using System;
using UIKit;

namespace PorpoiseMobileApp.iOS
{
   public partial class ConfirmationViewController : MvvmViewController<ViewModels.ConfirmationViewModel>
	{
		public ConfirmationViewController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewWillAppear(bool animated)
		{
			base.ViewWillAppear(animated);

			back.BackgroundColor = PorpoiseColors.lightGrey;

			this.View.BackgroundColor = PorpoiseColors.Turquoise;

			this.contentView.Layer.CornerRadius = 10;
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			Bindings.Bind(back).To(vm => vm.GoBack);

            Bindings.Bind(topImage).For(x => x.Image).To(x => x.TopImage).WithConversion(new UriToImageConverter());

			Bindings.Apply();
		}
	}
}