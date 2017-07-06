
using Android.App;
using Android.Content;
using Android.OS;
using Android.Views;
using Android.Widget;
using PorpoiseMobileApp.ViewModels;
using PorpoiseMobileApp.Droid.MvvmCross;
using Android.Support.Design.Widget;
using Android.Content.PM;
using Android.Text.Method;
using Android.Text;


namespace PorpoiseMobileApp.Droid.Views
{
	[Activity(Label = "LoginView", NoHistory = true,
		Theme = "@style/AppTheme", Icon = "@drawable/Icon", WindowSoftInputMode = SoftInput.AdjustPan | SoftInput.StateVisible,
	  ConfigurationChanges = ConfigChanges.KeyboardHidden | ConfigChanges.Orientation | ConfigChanges.ScreenSize,
	  ScreenOrientation = ScreenOrientation.Portrait)]
	public class LoginView : MvvmAppCompatActivity<LoginViewModel>
	{
		private LinearLayout rootLayout;



		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			this.Window.AddFlags(WindowManagerFlags.Fullscreen);
			if (this.ActionBar != null)
			{
				this.ActionBar.Hide();
			}
           this.SetContentView(Resource.Layout.LoginView);
			this.rootLayout = this.FindViewById<LinearLayout>(Resource.Id.root_layout);
			var registerUrl = "Don't have an account? Click <a href=\"{ViewModel.JoinURL}\">here</a> to register!";
			TextView registerTextView = FindViewById<TextView>(Resource.Id.registerTextView);
			registerTextView.LinksClickable = true;
			registerTextView.SetLinkTextColor(Resources.GetColor(Resource.Color.porpoise_pink_light));
			registerTextView.MovementMethod = LinkMovementMethod.Instance;
			registerTextView.TextAlignment = TextAlignment.Center;
			registerTextView.SetText(Html.FromHtml(registerUrl), Android.Widget.TextView.BufferType.Normal);

			var forgotPw = "<a href=\"{ViewModel.ForgotPasswordURL}\">Forgot Password</a>";
			TextView forgotPwTextView = FindViewById<TextView>(Resource.Id.forgotPwTextView);
			forgotPwTextView.LinksClickable = true;
			forgotPwTextView.SetLinkTextColor(Resources.GetColor(Resource.Color.porpoise_pink_light));
			forgotPwTextView.MovementMethod = LinkMovementMethod.Instance;
			forgotPwTextView.SetText(Html.FromHtml(forgotPw), Android.Widget.TextView.BufferType.Normal);

			var login = this.FindViewById<Button>(Resource.Id.login_button);
			var txtEmail = this.FindViewById<EditText>(Resource.Id.email);
			var emailInputLayout = this.FindViewById<TextInputLayout>(Resource.Id.emailInputLayout);
			var txtPassword = this.FindViewById<EditText>(Resource.Id.password);
			var pwInputLayout = this.FindViewById<TextInputLayout>(Resource.Id.pwInputLayout);
			var waiting = this.FindViewById<ProgressBar>(Resource.Id.waiting);

			ShowSoftKeyboard(txtEmail);

			ViewModel.SignInEvent += (s, e) =>
			{
				if (!e.Successful)
				{
					this.Alert(PorpoiseMobileApp.Droid.Extensions.AlertType.Error, PorpoiseMobileApp.Resource.LoginFailedTitle, e.Message, null, Resource.Style.PorpoiseDialogTheme);

				}
			};
			var emailErrorMsg = Resources.GetString(Resource.String.email_invalid);
			var passwordErrorMsg = Resources.GetString(Resource.String.password_invalid);

			txtPassword.FocusChange += (s, e) =>
			{
				if (!txtPassword.HasFocus && !ViewModel.PasswordValid)
				{
					pwInputLayout.Error = passwordErrorMsg;
					if (ViewModel.PasswordValid)
					{
						pwInputLayout.ErrorEnabled = false;
					}
				}
			};

			txtEmail.FocusChange += (s, e) =>
			{
				if (!txtEmail.HasFocus && !ViewModel.EmailValid)
					emailInputLayout.Error = emailErrorMsg;
				else
				{
					if (ViewModel.EmailValid)
					{
						emailInputLayout.ErrorEnabled = false;
					}
				}
			};

			Bindings.Bind(login).To(x => x.SignInCommand);
			Bindings.Bind(waiting).For(x => x.Visibility).To(x => x.InFlight);
			Bindings.Apply();
		}

		private void HandleError(object sender, DialogClickEventArgs e)
		{

		}

		public override void OnBackPressed()
		{
			FragmentManager.PopBackStack();
			this.FinishAffinity();
		}

		protected override void OnResume()
		{
			base.OnResume();
		}
	}
}