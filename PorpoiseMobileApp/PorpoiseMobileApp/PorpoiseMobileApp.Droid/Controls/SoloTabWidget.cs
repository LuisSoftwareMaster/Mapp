using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Util;
using Java.Lang;
using Android.Text;

namespace PorpoiseMobileApp.Droid.Controls
{
    public class SoloTabWidget : TabWidget
    {

        public SoloTabWidget(Context context, IAttributeSet attrs)
           : base(context, attrs)
        {
            StripEnabled = false;
            SetDividerDrawable(null);
        }
        public int LayoutId { get; set; }

        public void AddTab(int imageResId)
        {
            AddTab(imageResId, null);
        }

        public void AddTab(string title)
        {
            AddTab(0, title);
        }

        private void AddTab(int imageResId, string title)
        {
            View view = LayoutInflater.From(Context).Inflate(LayoutId, this, false);
            if (view == null)
            {
                throw new RuntimeException("You must call 'setLayout(int layoutResId)' to initialize the tab.");
            }
            else
            {
                LinearLayout.LayoutParams layoutParams = (LinearLayout.LayoutParams)view.LayoutParameters;
                layoutParams.Width = 0;
                layoutParams.Height = LinearLayout.LayoutParams.WrapContent;
                layoutParams.Weight = 1.0f;
                view.LayoutParameters = (layoutParams);
            }

            if (view is TextView)
            {
                if (imageResId > 0)
                {
                    ((TextView)view).SetCompoundDrawablesWithIntrinsicBounds(0, imageResId, 0, 0);
                }
                if (!TextUtils.IsEmpty(title))
                {
                    ((TextView)view).SetText(title, Android.Widget.TextView.BufferType.Normal);
                }
            }
            else if (view is ImageView)
            {
                if (imageResId > 0)
                {
                    ((ImageView)view).SetImageResource(imageResId);
                }
            }

            else
            {
                TextView textView = (TextView)view.FindViewById(Android.Resource.Id.Title);
                if (textView == null)
                {
                    throw new RuntimeException("Your layout must have a TextView whose id attribute is 'android.R.id.title'");
                }
                else
                {
                    textView.SetText(title, TextView.BufferType.Normal);
                }
                ImageView imageView = (ImageView)view.FindViewById(Android.Resource.Id.Icon);
                if (imageView == null)
                {
                    throw new RuntimeException("Your layout must have a ImageView whose id attribute is 'android.R.id.icon'");
                }
                else
                {
                    imageView.SetImageResource(imageResId);
                }
            }

            AddView(view);
            var tabIndex = TabCount - 1;
            view.Click += (s, e) => {
                if (OnTabClicked != null)
                {
                    OnTabClicked(this, new TabClickedEventArgs { TabIndex = tabIndex });
                }
            };
            view.FocusChange += (s, e) => ((IOnFocusChangeListener)this).OnFocusChange(((View)s), e.HasFocus);

        }

        public override void OnFocusChange(View v, bool hasFocus)
        {

        }

        public event EventHandler<TabClickedEventArgs> OnTabClicked;
    }
    public class TabClickedEventArgs : EventArgs
    {
        public int TabIndex { get; set; }
    }
}