using System.Collections.Specialized;
using System.Windows.Input;
using MvvmCross.iOS.Views;
using Foundation;
using UIKit;
using Acr.Settings;
using PorpoiseMobileApp.Services;
using PorpoiseMobileApp.ViewModels;
using PorpoiseMobileApp.Client;

namespace PorpoiseMobileApp.iOS
{
	// This class is never actually executed, but when Xamarin linking is enabled it does ensure types and properties
	// are preserved in the deployed app
    [Preserve  (Conditional = true) ]
  	public class LinkerPleaseInclude
	{
		public void Include(UIButton uiButton)
		{
			uiButton.TouchUpInside += (s, e) =>
									  uiButton.SetTitle(uiButton.Title(UIControlState.Normal), UIControlState.Normal);

			uiButton.TouchDown += (s, e) =>
									  uiButton.SetTitle(uiButton.Title(UIControlState.Normal), UIControlState.Normal);


		
		}

		public void include(NSLayoutConstraint constraint) {

			constraint.Constant = constraint.Constant + 0;
		
		}

		public void Include(UIBarButtonItem barButton)
		{
			barButton.Clicked += (s, e) =>
								 barButton.Title = barButton.Title + "";


		}

		public void Include(UITextField textField)
		{
			textField.Text = textField.Text + "";
			textField.EditingChanged += (sender, args) => { textField.Text = ""; };
		}

		public void Include(UITextView textView)
		{
			textView.Text = textView.Text + "";
			textView.Changed += (sender, args) => { textView.Text = ""; };
		}

		public void Include(UILabel label)
		{
			label.Text = label.Text + "";
			label.AttributedText = new NSAttributedString(label.AttributedText.ToString() + "");
			label.Hidden = label.Hidden;
		
		}

	
		public void Include(UIImageView imageView)
		{
			imageView.Image = new UIImage(imageView.Image.CGImage);
		}

		public void Include(UIDatePicker date)
		{
			date.Date = date.Date.AddSeconds(1);
			date.ValueChanged += (sender, args) => { date.Date = NSDate.DistantFuture; };
		}

		public void Include(UISlider slider)
		{
			slider.Value = slider.Value + 1;
			slider.ValueChanged += (sender, args) => { slider.Value = 1; };
		}

		public void Include(UIProgressView progress)
		{
			progress.Progress = progress.Progress + 1;
		}

		public void Include(UISwitch sw)
		{
			sw.On = !sw.On;
			sw.ValueChanged += (sender, args) => { sw.On = false; };
		}

		public void Include(MvxViewController vc)
		{
			vc.Title = vc.Title + "";
		}

		public void Include(UIStepper s)
		{
			s.Value = s.Value + 1;
			s.ValueChanged += (sender, args) => { s.Value = 0; };
		}

		public void Include(UIPageControl s)
		{
			s.Pages = s.Pages + 1;
			s.ValueChanged += (sender, args) => { s.Pages = 0; };
		}

		public void Include(INotifyCollectionChanged changed)
		{
			changed.CollectionChanged += (s, e) => { var test = ""+e.Action+""+e.NewItems+""+e.NewStartingIndex+""+e.OldItems+""+e.OldStartingIndex+""; };
		}

		public void Include(ICommand command)
		{
			command.CanExecuteChanged += (s, e) => { if (command.CanExecute(null)) command.Execute(null); };
		}

		public void Include(MvvmCross.Platform.IoC.MvxPropertyInjector injector)
		{
			injector = new MvvmCross.Platform.IoC.MvxPropertyInjector();
		}

		public void Include(System.ComponentModel.INotifyPropertyChanged changed)
		{
			changed.PropertyChanged += (sender, e) => { var test = e.PropertyName; };
		}

		//public void Include(ISettings settings)
		//{
		//    var vm = new LoadingViewModel(settings);
		//}

		public void Include(IPorpoiseWebApiClient client)
		{
			ISettings ss = null;
			IEncryptionService es = null;
			IImageRotateService ir = null;
			var vm = new LoginViewModel(client, ss, es);
			var vm1 = new LogHoursViewModel(client);
			var vm2 = new LoadingViewModel(ss, client);
			var vm3 = new Models.HourLog(client, ss);
            var x = new System.ComponentModel.ReferenceConverter(typeof(void));
			//var vm2 = new SignUpViewModel(sdk, ss);
			//var vm3 = new AllowanceViewModel(sdk, ss);
			//var vm4 = new UpdateAllowanceViewModel(sdk, ss);
			//var vm5 = new TermsOfServiceViewModel();
			//var vm6 = new ResetPasswordViewModel(sdk, ss);
			//var vm7 = new AccountHomeViewModel();
			//var vm8 = new AccountInfoViewModel(new SdkServiceImpl("", "", null));
		}


	}
}