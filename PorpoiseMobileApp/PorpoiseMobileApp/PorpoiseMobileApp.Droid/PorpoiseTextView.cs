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

namespace porpoisetextview
{
    public class PorpoiseTextView: TextView
    {
		public PorpoiseTextView(Context context): base(context)
        {
			
			//init();
		}

		protected PorpoiseTextView(IntPtr javaReference, JniHandleOwnership transfer): base(javaReference, transfer){
			
			//init();
		}

		public PorpoiseTextView(Context context, IAttributeSet attrs, int defStyle): base(context, attrs, defStyle)
        {
			//super(context, attrs, defStyle);
			//init();
		}

		public PorpoiseTextView(Context context, IAttributeSet attrs): base(context, attrs)
        {
			
			//super(context, attrs);
			//init();
		}

       /* protected override void OnSizeChanged(int w, int h, int oldw, int oldh)
        {

           
            if(h > oldh)
            {
            PorpoiseMobileApp.Droid.Helper.sizes.Add(h * 2);
            IViewParent parent = this.Parent;
            while (true)
            {

                if (parent is expandedlistview.ExpandedListView)
                {

                    break;

                }

                parent = parent.Parent;

            }

            Console.WriteLine("PARENT TYPE: " + parent.GetType());

            expandedlistview.ExpandedListView list = (expandedlistview.ExpandedListView)parent;

            PorpoiseMobileApp.Droid.Views.PostItemAdapter listAdapter = (PorpoiseMobileApp.Droid.Views.PostItemAdapter)list.Adapter;
            if (listAdapter == null)
                return;

            int desiredWidth = View.MeasureSpec.MakeMeasureSpec(list.Width, MeasureSpecMode.Unspecified);
            int totalHeight = 0;
            View view = null;
            for (int i = 0; i < listAdapter.Count; i++)
            {
                view = listAdapter.GetView(i, view, list);


                if (i == 0)
                {
                    view.LayoutParameters = new ViewGroup.LayoutParams(desiredWidth, WindowManagerLayoutParams.WrapContent);
                }


                view.Measure(desiredWidth, (int)MeasureSpecMode.Unspecified);
                totalHeight += view.MeasuredHeight;
            }
            PorpoiseMobileApp.Droid.Helper.index++;
            ViewGroup.LayoutParams parameters = list.LayoutParameters;
                parameters.Height = list.LayoutParameters.Height + h;
            PorpoiseMobileApp.Droid.Helper.size = parameters.Height;
               list.LayoutParameters.Height += h;
            list.RequestLayout();

        }
           
        }*/
		}

	}

