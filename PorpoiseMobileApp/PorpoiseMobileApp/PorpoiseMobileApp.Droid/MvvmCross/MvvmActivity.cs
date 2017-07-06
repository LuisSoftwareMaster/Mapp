using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Views;
using Android.Views.InputMethods;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Views;
using MvvmCross.Droid.Support.V4;
using System;
using System.Linq;
using Android.Content.Res;
using Plugin.Permissions;
using Android.Content.PM;
using Android.Runtime;
using MvvmCross.Droid.Support.V7.AppCompat;

namespace PorpoiseMobileApp.Droid.MvvmCross
{
    public abstract class MvvmAppCompatActivity<TViewModel> : MvxAppCompatActivity where TViewModel : IMvxViewModel
    {
        private bool approveBack;
        private MvxFluentBindingDescriptionSet<MvvmAppCompatActivity<TViewModel>, TViewModel> bindingSet;

        protected MvvmAppCompatActivity()
        {
            this.bindingSet = this.CreateBindingSet<MvvmAppCompatActivity<TViewModel>, TViewModel>();
        }

        protected MvvmAppCompatActivity(bool approveBack)
            : this()
        {
            this.approveBack = approveBack;
        }

        public MvxFluentBindingDescriptionSet<MvvmAppCompatActivity<TViewModel>, TViewModel> Bindings
        {
            get
            {
                return bindingSet;
            }
        }

        public new TViewModel ViewModel
        {
            get
            {
                return (TViewModel)base.ViewModel;
            }
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Permission[] grantResults)
        {
            PermissionsImplementation.Current.OnRequestPermissionsResult(requestCode, permissions, grantResults);
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

            if (!approveBack)
            {
                doBack();
            }
            else
            {
                this.Alert(PorpoiseMobileApp.Droid.Extensions.AlertType.Confirm, "Log out", "Do you want to log out?", x =>
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

        protected void If(BuildVersionCodes atLeast, Action action)
        {
            if (Build.VERSION.SdkInt >= atLeast)
            {
                action();
            }
        }

        protected void IfExact(BuildVersionCodes exact, Action action)
        {
            if (Build.VERSION.SdkInt == exact)
            {
                action();
            }
        }

        protected override void OnCreate(Bundle bundle)
        {
            RequestedOrientation = Android.Content.PM.ScreenOrientation.Portrait;
            Window.DecorView.SetBackgroundColor(Resources.GetColor(Resource.Color.default_background));

            base.OnCreate(bundle);

            If(BuildVersionCodes.Lollipop, () =>
            {
                Window.SetFlags(WindowManagerFlags.DrawsSystemBarBackgrounds, WindowManagerFlags.DrawsSystemBarBackgrounds);
            });

            if (ActionBar != null)
            {
                ActionBar.SetDisplayUseLogoEnabled(true);
                ActionBar.SetLogo(Resource.Drawable.ic_top_logo1);
                ActionBar.SetDisplayShowHomeEnabled(true);
                ActionBar.SetDisplayShowTitleEnabled(false);
            }

            If(BuildVersionCodes.JellyBeanMr2, () =>
            {
                if (ActionBar != null)
                {
                    ActionBar.SetHomeAsUpIndicator(Resource.Drawable.arrow_z);
                }
            });
        }

        protected override void OnResume()
        {
            base.OnResume();
            // Security.Check();
            //AppboyInAppMessageManager.Instance.RegisterInAppMessageManager(this);
        }

        protected override void OnPause()
        {
            base.OnPause();
            //AppboyInAppMessageManager.Instance.UnregisterInAppMessageManager(this);
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

        protected override void OnStart()
        {
            base.OnStart();
            //Appboy.GetInstance(this).OpenSession(this);
        }

        protected override void OnStop()
        {
            base.OnStop();
            //Appboy.GetInstance(this).CloseSession(this);
        }

		
        
    }

    public abstract class MvvmFragmentActivity<TViewModel> : MvxFragmentActivity where TViewModel : IMvxViewModel
    {
        private MvxFluentBindingDescriptionSet<MvvmFragmentActivity<TViewModel>, TViewModel> bindingSet;

        protected MvvmFragmentActivity()
        {
            bindingSet = this.CreateBindingSet<MvvmFragmentActivity<TViewModel>, TViewModel>();
        }

        protected MvxFluentBindingDescriptionSet<MvvmFragmentActivity<TViewModel>, TViewModel> Bindings
        {
            get
            {
                return bindingSet;
            }
        }

        public new TViewModel ViewModel
        {
            get
            {
                return (TViewModel)base.ViewModel;
            }
        }

        protected void If(BuildVersionCodes atLeast, Action action)
        {
            if (Android.OS.Build.VERSION.SdkInt >= atLeast)
            {
                action();
            }
        }

        protected void IfExpr(Func<BuildVersionCodes, bool> expr, Action action)
        {
            if (expr(Android.OS.Build.VERSION.SdkInt))
            {
                action();
            }
        }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            Window.DecorView.SetBackgroundColor(Resources.GetColor(Resource.Color.default_background));

            if (ActionBar != null)
            {
                ActionBar.SetDisplayUseLogoEnabled(true);
                ActionBar.SetLogo(Resource.Drawable.ic_top_logo1);
                ActionBar.SetDisplayShowHomeEnabled(true);
                ActionBar.SetDisplayShowTitleEnabled(false);
            }

            RequestedOrientation = Android.Content.PM.ScreenOrientation.Portrait;

            IfExpr(x => x >= BuildVersionCodes.Lollipop, () =>
            {
                Window.SetFlags(WindowManagerFlags.DrawsSystemBarBackgrounds, WindowManagerFlags.DrawsSystemBarBackgrounds);
            });
        }
   
        public void ShowSoftKeyboard(View view)
        {
            if (view.RequestFocus())
            {
                InputMethodManager imm = (InputMethodManager)GetSystemService(Context.InputMethodService);
                imm.ShowSoftInput(view, ShowFlags.Implicit);
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

        protected override void OnStart()
        {
            base.OnStart();
            //Appboy.GetInstance(this).OpenSession(this);
        }

        protected override void OnStop()
        {
            base.OnStop();
            //Appboy.GetInstance(this).CloseSession(this);
        }
    }
}
