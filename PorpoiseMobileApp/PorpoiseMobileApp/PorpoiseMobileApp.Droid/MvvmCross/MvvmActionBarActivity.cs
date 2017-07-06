using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Views.InputMethods;
using Android.Widget;
using MvvmCross.Core;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.Droid.BindingContext;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Views;
using MvvmCross.Platform.Core;
using MvvmCross.Platform.Droid.Views;
using PorpoiseMobileApp.Droid.MvvmCross;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PorpoiseMobileApp.Droid.MvvmCross
{
    public abstract class MvvmActionBarActivity<TViewModel> : MvvmActionBarActivity where TViewModel : IMvxViewModel
    {
        private MvxFluentBindingDescriptionSet<MvvmActionBarActivity<TViewModel>, TViewModel> bindingSet;

        protected MvvmActionBarActivity()
            : base()
        {
            this.bindingSet = this.CreateBindingSet<MvvmActionBarActivity<TViewModel>, TViewModel>();
        }

        public MvxFluentBindingDescriptionSet<MvvmActionBarActivity<TViewModel>, TViewModel> Bindings
        {
            get
            {
                return bindingSet;
            }
        }

        protected MvvmActionBarActivity(bool approveBack)
            : base(approveBack)
        {
            this.bindingSet = this.CreateBindingSet<MvvmActionBarActivity<TViewModel>, TViewModel>();
        }

        public new TViewModel ViewModel
        {
            get
            {
                return (TViewModel)base.ViewModel;
            }
            set
            {
                base.ViewModel = value;
            }
        }
    }

    public abstract class MvvmActionBarActivity : MvxActionBarEventSourceActivity, IMvxAndroidView
    {
        private bool backMustBeApproved;

        protected MvvmActionBarActivity()
        {
            BindingContext = new MvxAndroidBindingContext(this, this);
            this.AddEventListeners();
        }

        protected MvvmActionBarActivity(bool backMustBeApproved)
            : this()
        {
            this.backMustBeApproved = backMustBeApproved;
        }
        public IMvxBindingContext BindingContext { get; set; }

        public object DataContext
        {
            get { return BindingContext.DataContext; }
            set { BindingContext.DataContext = value; }
        }


        public IMvxViewModel ViewModel
        {
            get { return DataContext as IMvxViewModel; }
            set
            {
                DataContext = value;
                OnViewModelSet();
            }
        }
        public override void SetContentView(int layoutResID)
        {
            var view = this.BindingInflate(layoutResID, null);
            SetContentView(view);
        }

        protected virtual void OnViewModelSet()
        {
        }
        public void MvxInternalStartActivityForResult(Intent intent, int requestCode)
        {
            base.StartActivityForResult(intent, requestCode);
        }




        public void ShowSoftKeyboard(View view)
        {
            if (view.RequestFocus())
            {
                InputMethodManager imm = (InputMethodManager)GetSystemService(Context.InputMethodService);
                imm.ShowSoftInput(view, ShowFlags.Implicit);
            }
        }

        public void HideSoftKeyboard(View view)
        {
            InputMethodManager imm = (InputMethodManager)GetSystemService(Context.InputMethodService);
            imm.HideSoftInputFromWindow(view.WindowToken, HideSoftInputFlags.ImplicitOnly);
        }

        public override void OnBackPressed()
        {
            Action doBack = () =>
            {
                var activityAttributes = GetType().GetCustomAttributes(typeof(ActivityAttribute), true).Cast<ActivityAttribute>();
                foreach (var attr in activityAttributes)
                {
                    var parent = attr.ParentActivity;
                    PerformGotoParent(parent);
                }
            };

            if (!backMustBeApproved)
            {
                doBack();
            }
            else
            {
                this.Alert(PorpoiseMobileApp.Droid.Extensions.AlertType.Confirm, PorpoiseMobileApp.Resource.Logout, "Do you want to log out?", x =>
                {
                    switch (x)
                    {
                        case DialogButtonType.Positive:
                            doBack();
                            break;
                    }
                });
            }
        }

        public override void OnUserInteraction()
        {
            base.OnUserInteraction();
            Security.Touch();
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            RequestedOrientation = Android.Content.PM.ScreenOrientation.Portrait;
            Window.DecorView.SetBackgroundColor(Resources.GetColor(Resource.Color.default_background));

            base.OnCreate(savedInstanceState);



            if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
            {
                Window.SetFlags(WindowManagerFlags.DrawsSystemBarBackgrounds, WindowManagerFlags.DrawsSystemBarBackgrounds);
            }

            if (Build.VERSION.SdkInt >= BuildVersionCodes.JellyBeanMr2)
            {
                if (ActionBar != null)
                {
                    ActionBar.SetHomeAsUpIndicator(Resource.Drawable.arrow_z);
                }
            }

            if (ActionBar != null)
            {
                ActionBar.SetDisplayUseLogoEnabled(true);
                ActionBar.SetLogo(Resource.Drawable.ic_top_logo1);
                ActionBar.SetDisplayShowHomeEnabled(true);
                ActionBar.SetDisplayShowTitleEnabled(false);
            }

        }

        protected override void OnResume()
        {
            base.OnResume();
        }

        protected override void OnPause()
        {
            base.OnPause();
        }
        protected virtual void PerformGotoParent(Type parent)
        {
            if (parent != null)
            {
                NavigateUpTo(new Intent(this, parent));
            }
            else
            {
                base.OnBackPressed();
            }
        }

        protected String RString(int resourceId)
        {
            return Resources.GetString(resourceId);
        }

        protected Bitmap RBitmap(int resourceId)
        {
            return ((BitmapDrawable)Resources.GetDrawable(resourceId)).Bitmap;
        }

        protected Drawable RDrawable(int resourceId)
        {
            return Resources.GetDrawable(resourceId);
        }

    }
    public abstract class MvxActionBarEventSourceActivity : AppCompatActivity, IMvxEventSourceActivity
    {


        protected override void OnCreate(Bundle savedInstanceState)
        {
            CreateWillBeCalled.Raise(this, savedInstanceState);
            base.OnCreate(savedInstanceState);
            CreateCalled.Raise(this, savedInstanceState);
        }

        protected override void OnDestroy()
        {
            DestroyCalled.Raise(this);
            base.OnDestroy();
        }

        protected override void OnNewIntent(Intent intent)
        {
            base.OnNewIntent(intent);
            NewIntentCalled.Raise(this, intent);
        }

        protected override void OnResume()
        {
            base.OnResume();
            ResumeCalled.Raise(this);
        }

        protected override void OnPause()
        {
            PauseCalled.Raise(this);
            base.OnPause();
        }

        protected override void OnStart()
        {
            base.OnStart();
            StartCalled.Raise(this);
        }

        protected override void OnRestart()
        {
            base.OnRestart();
            RestartCalled.Raise(this);
        }

        protected override void OnStop()
        {
            StopCalled.Raise(this);
            base.OnStop();
        }

        public override void StartActivityForResult(Intent intent, int requestCode)
        {
            StartActivityForResultCalled.Raise(this, new MvxStartActivityForResultParameters(intent, requestCode));
            base.StartActivityForResult(intent, requestCode);
        }

        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            ActivityResultCalled.Raise(this, new MvxActivityResultParameters(requestCode, resultCode, data));
            base.OnActivityResult(requestCode, resultCode, data);
        }

        protected override void OnSaveInstanceState(Bundle outState)
        {
            SaveInstanceStateCalled.Raise(this, outState);
            base.OnSaveInstanceState(outState);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                DisposeCalled.Raise(this);
            }
            base.Dispose(disposing);
        }

        public event EventHandler DisposeCalled;
        public event EventHandler<MvxValueEventArgs<Bundle>> CreateWillBeCalled;
        public event EventHandler<MvxValueEventArgs<Bundle>> CreateCalled;
        public event EventHandler DestroyCalled;
        public event EventHandler<MvxValueEventArgs<Intent>> NewIntentCalled;
        public event EventHandler ResumeCalled;
        public event EventHandler PauseCalled;
        public event EventHandler StartCalled;
        public event EventHandler RestartCalled;
        public event EventHandler StopCalled;
        public event EventHandler<MvxValueEventArgs<Bundle>> SaveInstanceStateCalled;
        public event EventHandler<MvxValueEventArgs<MvxStartActivityForResultParameters>> StartActivityForResultCalled;
        public event EventHandler<MvxValueEventArgs<MvxActivityResultParameters>> ActivityResultCalled;
    }
}