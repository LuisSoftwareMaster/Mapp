using System;
using Android.Views;
using Android.Widget;
using MvvmCross.Binding.Droid.Views;
namespace PorpoiseMobileApp.Droid
{
	public class Helper
	{
        public static System.Collections.Generic.List<double> sizes;

        public static double size;

        public static bool loaded;

        public static int elements;

        public static int index;

        public static void clearList(){

            sizes = new System.Collections.Generic.List<double>();

            sizes.Clear();

        }

        public static void setListViewHeightBasedOnChildren(expandedlistview.ExpandedListView listView)
		{
          
            if (listView.Adapter == null)
			{
				// pre-condition
				return;
			}

            int totalHeight = listView.PaddingTop + listView.PaddingBottom;
            int desiredWidth = View.MeasureSpec.MakeMeasureSpec(listView.Width, MeasureSpecMode.AtMost);
            for (int i = 0; i < listView.Adapter.Count; i++)
			{
                View listItem = listView.Adapter.GetView(i, null, listView);

				if (listItem != null)
				{
					// This next line is needed before you call measure or else you won't get measured height at all. The listitem needs to be drawn first to know the height.
                    listItem.LayoutParameters=new RelativeLayout.LayoutParams(RelativeLayout.LayoutParams.WrapContent, RelativeLayout.LayoutParams.WrapContent);
                    listItem.Measure(desiredWidth, (int)MeasureSpecMode.Unspecified);
                    totalHeight += listItem.MeasuredHeight;

				}
			}

            ViewGroup.LayoutParams parameters = listView.LayoutParameters;
            parameters.Height = totalHeight + (listView.DividerHeight* (listView.Adapter.Count - 1));
            listView.LayoutParameters = parameters;
            listView.RequestLayout();
		}


        public static void getListViewSize(ExpandableListView myListView)
		{
            IListAdapter myListAdapter = myListView.Adapter;
			if (myListAdapter == null)
			{
				//do nothing return null
				return;
			}
			//set listAdapter in loop for getting final size
			int totalHeight = 0;
            for (int size = 0; size < myListAdapter.Count; size++)
			{
                View listItem = myListAdapter.GetView(size, null, myListView);
                listItem.Measure(0, 0);
                totalHeight += listItem.MeasuredHeight;
			}
            //setting listview item in adapter
            ViewGroup.LayoutParams parameters = myListView.LayoutParameters;
            parameters.Height = totalHeight + (myListView.DividerHeight* (myListAdapter.Count - 1));
            myListView.LayoutParameters = parameters;
			// print height of adapter on log
			//Log.i("height of listItem:", (totalHeight));
		}

        public static void SetListViewHeightBasedOnChildren(MvxListView listView)
		{
			Views.PostItemAdapter listAdapter = (PorpoiseMobileApp.Droid.Views.PostItemAdapter)listView.Adapter;
			if (listAdapter == null)
				return;

			int desiredWidth = View.MeasureSpec.MakeMeasureSpec(listView.Width, MeasureSpecMode.Unspecified);
			int totalHeight = 0;
			View view = null;
			for (int i = 0; i < listAdapter.Count; i++)
			{
				view = listAdapter.GetView(i, view, listView);
                MvxImageView uploadedPic = view.FindViewById<scaleimageview.ScaleImageView>(Resource.Id.image);
                int desiredImageWidth = View.MeasureSpec.MakeMeasureSpec(uploadedPic.Width, MeasureSpecMode.Unspecified);
				if (i == 0)
				{
					view.LayoutParameters = new ViewGroup.LayoutParams(desiredWidth, WindowManagerLayoutParams.WrapContent);
				}
                uploadedPic.Measure(desiredImageWidth, (int)MeasureSpecMode.Unspecified);
                Console.WriteLine("UPLOADED PIC HEIGHT: "+uploadedPic.Height);
				view.Measure(desiredWidth, (int)MeasureSpecMode.Unspecified);
                totalHeight += view.MeasuredHeight+uploadedPic.MeasuredHeight;
			}
			ViewGroup.LayoutParams parameters = listView.LayoutParameters;
            int lastHeight = (totalHeight + (listView.DividerHeight * (listAdapter.Count - 1)));
            Console.WriteLine("LAST HEIGHT BEFORE: " + lastHeight);
            foreach(double aux in Helper.sizes){
				Console.WriteLine("AUX: " + aux);
                lastHeight += (int)aux;

            }
            Console.WriteLine("LAST HEIGHT: "+lastHeight);
            parameters.Height = lastHeight;
			listView.LayoutParameters = parameters;
		}
	}


	
}
