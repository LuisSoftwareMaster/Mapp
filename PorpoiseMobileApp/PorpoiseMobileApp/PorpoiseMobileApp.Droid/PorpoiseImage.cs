using System;
using Android.Content;
using Android.Util;
using MvvmCross.Binding.Droid.Views;

namespace porpoiseimage
{
    public class PorpoiseImage: MvxImageView
    {
        public PorpoiseImage(Context context, Android.Util.IAttributeSet attrs): base(context, attrs)
        {
        }

        public PorpoiseImage(Context context, IAttributeSet attrs, int defStyleAttr) : base(context, attrs, defStyleAttr)
		{
		}

		public PorpoiseImage(Context context) : base(context)
        {
		}




		//public MvxImageView(Context context, IAttributeSet attrs);

        //public MvxImageView(Context context, IAttributeSet attrs, int defStyleAttr);

		//protected MvxImageView(IntPtr javaReference, JniHandleOwnership transfer);

		//public MvxImageView(Context context);
	}
}
