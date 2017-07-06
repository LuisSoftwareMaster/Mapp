using Android.Content;
using Android.Graphics.Drawables;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Java.Interop;
using Java.Lang;
using System;
using Android.Widget;
using MvvmCross.Binding.Droid.Views;
namespace PorpoiseMobileApp.Droid
{
    public class ExpandableHeightGridView: MvxGridView
    {
		bool expanded = false;

		

		public ExpandableHeightGridView(Context context, IAttributeSet attrs): base(context, attrs)
		{
			
		}
    }
}
