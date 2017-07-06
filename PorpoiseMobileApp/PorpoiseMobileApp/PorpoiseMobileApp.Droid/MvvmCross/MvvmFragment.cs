using Android.Graphics;
using Android.Graphics.Drawables;
using System;
using Android.Views;
using Android.Views.InputMethods;
using Android.Content;
using Android.Widget;
using MvvmCross.Droid.Support.V4;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Core.ViewModels;
using MvvmCross.Binding.Droid.BindingContext;
using Android.OS;
using Plugin.CurrentActivity;
using Plugin.Permissions;

namespace PorpoiseMobileApp.Droid.Views
{
    public abstract class MvvmFragment<TViewModel> : MvxFragment<TViewModel>, IDirty where TViewModel : MvxViewModel
    {
        private MvxFluentBindingDescriptionSet<MvvmFragment<TViewModel>, TViewModel> bindingSet;
        private int layoutId;

        public MvvmFragment(int layoutId)
            : base()
        {
            this.layoutId = layoutId;
            this.bindingSet = this.CreateBindingSet<MvvmFragment<TViewModel>, TViewModel>();
        }

        public MvxFluentBindingDescriptionSet<MvvmFragment<TViewModel>, TViewModel> Bindings
        {
            get
            {
                return bindingSet;
            }
        }
        
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, Android.Content.PM.Permission[] grantResults)
        {
            PermissionsImplementation.Current.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
        public override void OnActivityCreated(Bundle savedInstanceState)
        {
            base.OnActivityCreated(savedInstanceState);
            CrossCurrentActivity.Current.Activity = this.Activity;
        }
        public bool IsDirty { get; protected set; }

        protected virtual void HandleDirty(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            this.IsDirty = true;
        }

        void IDirty.Cleanup()
        {
            this.Cleanup();
            IsDirty = false;
        }

        public override Android.Views.View OnCreateView(Android.Views.LayoutInflater inflater, Android.Views.ViewGroup container, Android.OS.Bundle savedInstanceState)
        {
            var ignored = base.OnCreateView(inflater, container, savedInstanceState);
         return this.BindingInflate(layoutId, null);
        }

        protected Bitmap RBitmap(int resourceId)
        {
            return ((BitmapDrawable)Resources.GetDrawable(resourceId)).Bitmap;
        }

        protected Drawable RDrawable(int resourceId)
        {
            return Resources.GetDrawable(resourceId);
        }

        protected String RString(int resourceId)
        {
            return Resources.GetString(resourceId);
        }

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            if (RespondToViewModelChanges)
            {

                base.ViewModel.PropertyChanged += HandleDirty;
            }
        }



        protected virtual bool RespondToViewModelChanges
        {
            get
            {
                return false;
            }
        }

        public virtual void Cleanup()
        {
        }

        public void ShowSoftKeyboard(View view)
        {
            if (view.RequestFocus())
            {
                InputMethodManager imm = (InputMethodManager)Activity.GetSystemService(Context.InputMethodService);
                imm.ShowSoftInput(view, ShowFlags.Implicit);
            }
        }

        public void HideSoftKeyboard(View view)
        {
            InputMethodManager imm = (InputMethodManager)Activity.GetSystemService(Context.InputMethodService);
            imm.HideSoftInputFromWindow(view.WindowToken, HideSoftInputFlags.ImplicitOnly);
        }

        protected int StatusBarHeight
        {
            get
            {
                int result = 0;
                if (Activity != null)
                {
                    int resourceId = Resources.GetIdentifier("status_bar_height", "dimen", "android");
                    if (resourceId > 0)
                    {
                        result = Resources.GetDimensionPixelSize(resourceId);
                    }
                }
                return result;
            }
        }

        private static readonly int UNBOUNDED = Android.Views.View.MeasureSpec.MakeMeasureSpec(0, MeasureSpecMode.Unspecified);

        // To calculate the total height of all items in ListView call with items = adapter.getCount()
        public static int GetItemHeightofListView(ListView listView, int items)
        {
            IListAdapter adapter = listView.Adapter;

            int grossElementHeight = 0;
            for (int i = 0; i < items; i++)
            {
                View childView = adapter.GetView(i, null, listView);
                childView.Measure(UNBOUNDED, UNBOUNDED);
                grossElementHeight += childView.MeasuredHeight;
            }
            return grossElementHeight;
        }

        public virtual bool AddToBackStack
        {
            get { return true; }
        }

		public static implicit operator MvvmFragment<TViewModel>(View v)
		{
			throw new NotImplementedException();
		}
	}
}
