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
using Android.Graphics;

namespace expandedlistview
{
    public class ExpandedListView: MvxListView
	{
		
        public ExpandedListView(Context context, IAttributeSet attrs): base(context, attrs)
        {
        }

        bool expanded;

		public bool isExpanded()
		{
			return expanded;
		}

		
	protected override void OnMeasure(int widthMeasureSpec, int heightMeasureSpec)
		{
            int heightMeasureSpec_custom = MeasureSpec.MakeMeasureSpec(
                Integer.MaxValue >> 2, MeasureSpecMode.AtMost);
			base.OnMeasure(widthMeasureSpec, heightMeasureSpec_custom);
            ViewGroup.LayoutParams parameters = this.LayoutParameters;
            parameters.Height = this.MeasuredHeight;
		}
		
       /* protected override void OnMeasure(int widthMeasureSpec, int heightMeasureSpec)
		{
			// HACK! TAKE THAT ANDROID!
            int expandSpec = MeasureSpec.MakeMeasureSpec(Integer.MaxValue >> 2,
                                                         MeasureSpecMode.Exactly);
			base.OnMeasure(widthMeasureSpec, expandSpec);
		}*/

		public void setExpanded(bool expanded)
		{
			this.expanded = expanded;
		}

        /*public override bool OnTouchEvent(MotionEvent e)
        {

            Console.WriteLine("LAYOUT PARAMETERS: "+this.LayoutParameters.Height);

			int desiredWidth = View.MeasureSpec.MakeMeasureSpec(this.Width, MeasureSpecMode.Unspecified);
			int totalHeight = 0;
			View view = null;
            for (int i = 0; i < this.Adapter.Count; i++)
			{
                view = this.Adapter.GetView(i, view, this);


				if (i == 0)
				{
					view.LayoutParameters = new ViewGroup.LayoutParams(desiredWidth, WindowManagerLayoutParams.WrapContent);
				}


				view.Measure(desiredWidth, (int)MeasureSpecMode.Unspecified);
				totalHeight += view.MeasuredHeight;
			}
            Console.WriteLine("MEASURED PARAMETERS: " + this.getTotalHeightofListView());

            PorpoiseMobileApp.Droid.Helper.setListViewHeightBasedOnChildren(this);
            return base.OnTouchEvent(e);
        }*/

    }
}
