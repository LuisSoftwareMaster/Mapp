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
using PorpoiseMobileApp;
namespace scaleimageview
{
    public class ScaleImageView: MvxImageView
    {
		//private ImageChangeListener imageChangeListener;
		//private bool scaleToWidth = false; // this flag determines if should measure height manually dependent of width

		public ScaleImageView(Context context): base(context)
		{
            this.SetScaleType(ScaleType.FitXy);
			//init();
		}

        protected ScaleImageView(IntPtr javaReference, JniHandleOwnership transfer): base(javaReference, transfer){
            this.SetScaleType(ScaleType.FitXy);
            //init();
        }

		public ScaleImageView(Context context, IAttributeSet attrs, int defStyle): base(context, attrs, defStyle)
        {this.SetScaleType(ScaleType.FitXy);
			//super(context, attrs, defStyle);
			//init();
		}

		public ScaleImageView(Context context, IAttributeSet attrs): base(context, attrs)
        {this.SetScaleType(ScaleType.FitXy);
			//super(context, attrs);
			//init();
		}

		private void init()
		{
            this.SetScaleType(ScaleType.CenterCrop);
		}

       /* protected override void OnSizeChanged(int w, int h, int oldw, int oldh)
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

			

           
        }*/

		protected override void OnMeasure(int widthMeasureSpec, int heightMeasureSpec)
		{
            Drawable d = this.Drawable;

            if (d != null && d.IntrinsicWidth > 0)
			{
                int width = MeasureSpec.GetSize(widthMeasureSpec);
				if (width <= 0)
                    width = LayoutParameters.Width;

                int height = width * d.IntrinsicHeight / d.IntrinsicWidth;
                Console.WriteLine("IMAGE SIZE: "+ height);
				SetMeasuredDimension(width, height);
			}
			else
				base.OnMeasure(widthMeasureSpec, heightMeasureSpec);
		}
		}


   
		}

	

