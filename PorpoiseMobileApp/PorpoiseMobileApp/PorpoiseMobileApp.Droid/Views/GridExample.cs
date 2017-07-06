
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
using MvvmCross.Platform;
using MvvmCross.Plugins.Permissions;
using PorpoiseMobileApp.Droid.Helpers;

namespace PorpoiseMobileApp.Droid.Views
{
       
    public class GridExample : MvvmFragment<ViewModels.LogPostOrganizationViewModel>
	{IMvxPermissions _permissions;
        public GridExample() : base(Resource.Layout.grid_example)
        {
			_permissions = Mvx.Resolve<IMvxPermissions>();

		}

		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			// Use this to return your custom view for this Fragment
			// return inflater.Inflate(Resource.Layout.YourFragment, container, false);
         


			var view = base.OnCreateView(inflater, container, savedInstanceState);

            var grid = view.FindViewById<GridView>(Resource.Id.gridviewexample);

			//grid.Adapter = new ImageAdapterTest(view.Context);
			//string[] projection = { Android.Provider.MediaStore.Images.Thumbnails.ImageId };


			//this.cursor = Application.Context.ContentResolver.Query(Android.Provider.MediaStore.Images.Thumbnails.ExternalContentUri, projection, null, null, Android.Provider.MediaStore.Images.Thumbnails.ImageId + "");

			//AllImageAdapter adapter = new AllImageAdapter(this.Context, cursor, columnIndex);
			//grid.Adapter = adapter;


			return view;


		}

		public override void OnActivityCreated(Bundle savedInstanceState)
		{
			try
			{
				base.OnActivityCreated(savedInstanceState);

				//this.OnPickImageClicked();



			}
			catch (System.Exception ex)
			{
				System.Console.WriteLine(ex.ToString());

			}

		}


		public override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);


		}
       
    }
}
