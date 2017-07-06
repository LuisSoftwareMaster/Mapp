
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using MvvmCross.Platform;
using MvvmCross.Plugins.Permissions;
using PorpoiseMobileApp.Droid.Helpers;
using PorpoiseMobileApp.ViewModels;
using Square.Picasso;
using Android;
using Java.IO;
using Java.Util;
using Android.Graphics;
using Java.Lang;
using Android.Support.V4.Content;
using Android.Support.V4.App;
using Android.Provider;
using Android.Content.PM;
using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
using Android.Content.Res;
using Android.Graphics.Drawables;
using Java.Nio;
using System.IO;
using Java.IO;
using MvvmCross.Core.ViewModels;

namespace PorpoiseMobileApp.Droid.Views
{


	[MenuItem(MenuItem.LogHours)]
	public class LogPostPhoto : MvvmFragment<ViewModels.LogHourPhotoViewModel>
	{


		View view;

		GridView grid;


		public static readonly int MY_PERMISSIONS_REQUEST_READ_EXTERNAL_STORAGE = 123;

		private Android.Database.ICursor cursor;

		Button cameraButton;

		Button galleryButton;

		Button noPhotoButton;

		ImageButton cancel;

		private int width;

		IMvxPermissions _permissions;
		public LogPostPhoto() : base(Resource.Layout.LogPostPhoto)
		{
			_permissions = Mvx.Resolve<IMvxPermissions>();

			LogPost.clear();

		}


		public List<string> getFilePaths()
		{

			int permissionCheck = (int)ContextCompat.CheckSelfPermission(this.Activity,
																	Manifest.Permission.ReadExternalStorage);
			Android.Net.Uri u = Android.Provider.MediaStore.Images.Media.ExternalContentUri;
			string[] projection = { Android.Provider.MediaStore.Images.ImageColumns.Data };
			Android.Database.ICursor c = null;
			List<string> dirList = new System.Collections.Generic.List<string>();
			List<string> resultIAV = new List<string>();

			string[] directories = null;
			if (u != null)
			{

				c = Application.Context.ContentResolver.Query(u, projection, null, null, null);
			}

			if ((c != null) && (c.MoveToFirst()))
			{
				do
				{
					string tempDir = c.GetString(0);
					tempDir = tempDir.Substring(0, tempDir.LastIndexOf("/"));
					try
					{
						dirList.Add(tempDir);
					}
					catch (System.Exception e)
					{

					}
				}
				while (c.MoveToNext());
				directories = new string[dirList.Count()];


			}

			for (int i = 0; i < dirList.Count(); i++)
			{
				Java.IO.File imageDir = new Java.IO.File(dirList[i]);
				Java.IO.File[] imageList = imageDir.ListFiles();
				if (imageList == null)
					continue;
				foreach (Java.IO.File imagePath in imageList)
				{
					try
					{

						if (imagePath.IsDirectory)
						{
							imageList = imagePath.ListFiles();

						}
						if (imagePath.Name.Contains(".jpg") || imagePath.Name.Contains(".JPG")
								|| imagePath.Name.Contains(".jpeg") || imagePath.Name.Contains(".JPEG")
								|| imagePath.Name.Contains(".png") || imagePath.Name.Contains(".PNG")
								|| imagePath.Name.Contains(".gif") || imagePath.Name.Contains(".GIF")
								|| imagePath.Name.Contains(".bmp") || imagePath.Name.Contains(".BMP")
		)
						{



							string path = imagePath.AbsolutePath;
							resultIAV.Add(path);

						}
					}
					//  }
					catch (System.Exception e)
					{
						System.Console.WriteLine(e.ToString());
					}
				}
			}

			return resultIAV;


		}

		public override void OnActivityCreated(Bundle savedInstanceState)
		{
			try
			{
				base.OnActivityCreated(savedInstanceState);





				//this.OnPickImageClicked();
				this.OnPickImageClicked();

				//Bindings.Bind(cameraButton).To(vm => vm.TakePictureCommand);

				//Bindings.Apply();


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

		public List<string> getImagePaths(Context context)
		{
			// The list of columns we're interested in:
			string[] columns = { Android.Provider.MediaStore.Images.ImageColumns.Data, Android.Provider.MediaStore.Images.ImageColumns.DateAdded };

			Android.Database.ICursor cursor = context.ContentResolver.
				Query(MediaStore.Images.Media.ExternalContentUri, // Specify the provider
							columns, // The columns we're interested in
							null, // A WHERE-filter query
							null, // The arguments for the filter-query
							Android.Provider.MediaStore.Images.ImageColumns.DateAdded + " DESC" // Order the results, newest first
					);

			List<string> result = new List<string>();

			if (cursor.MoveToFirst())
			{
				int image_path_col = cursor.GetColumnIndexOrThrow(Android.Provider.MediaStore.Images.ImageColumns.Data);
				do
				{
					result.Add(cursor.GetString(image_path_col));
				} while (cursor.MoveToNext());
			}
			cursor.Close();

			return result;
		}

		public override void OnRequestPermissionsResult(int requestCode, string[] permissions, Android.Content.PM.Permission[] grantResults)
		{

			PermissionsImplementation.Current.OnRequestPermissionsResult(requestCode, permissions, grantResults);
		}

		public override bool ShouldShowRequestPermissionRationale(string permission)
		{
			return base.ShouldShowRequestPermissionRationale(permission);
		}

		PermissionStatus statusStorage;

		PermissionStatus statusCamera;

		async void OnPickImageClicked()
		{


			statusStorage = await _permissions.CheckPermissionStatusAsync(Plugin.Permissions.Abstractions.Permission.Storage);




			if (statusStorage != PermissionStatus.Granted)
			{
				var results = await _permissions.RequestPermissionsAsync(new[] { Plugin.Permissions.Abstractions.Permission.Storage });
				statusStorage = results[Plugin.Permissions.Abstractions.Permission.Storage];
			}

			if (statusStorage == PermissionStatus.Granted)
			{
				// Show Gallery
				var metrics = Resources.DisplayMetrics;
				var widthInDp = ConvertPixelsToDp(metrics.WidthPixels);
				var heightInDp = ConvertPixelsToDp(metrics.HeightPixels);
				width = view.LayoutParameters.Width;

				ImageAdapterTest adapter = new ImageAdapterTest(view.Context, this.getImagePaths(this.Context), metrics.WidthPixels);

				grid.Adapter = adapter;

				HomeView home = (PorpoiseMobileApp.Droid.Views.HomeView)this.Activity;
				grid.ItemClick += delegate (object sender, AdapterView.ItemClickEventArgs args)
				{
					ImageView image = (Android.Widget.ImageView)args.View;

					LogPost.image = this.convertByteArray(image);

					//ViewModel.navigateContinueEditing();

					home.Show(new MvxViewModelRequest(typeof(ChallengeLogHourViewModel), null, null, null));

				};



			}

			if (statusCamera != PermissionStatus.Granted || statusStorage != PermissionStatus.Granted)
			{
				var results = await _permissions.RequestPermissionsAsync(new[] { Plugin.Permissions.Abstractions.Permission.Camera, Plugin.Permissions.Abstractions.Permission.Storage });
				statusCamera = results[Plugin.Permissions.Abstractions.Permission.Camera];
				statusStorage = results[Plugin.Permissions.Abstractions.Permission.Storage];
			}

			if (statusCamera == PermissionStatus.Granted && statusStorage == PermissionStatus.Granted)
			{
				Bindings.Bind(cameraButton).To(vm => vm.TakePictureCommand).Apply();
			}


		}

		private byte[] convertByteArray(ImageView imageView) { 

			Bitmap bitmap = ((BitmapDrawable)imageView.Drawable).Bitmap;
			var ms = new MemoryStream();
				// Converting Bitmap image to byte[] array
			bitmap.Compress(Bitmap.CompressFormat.Jpeg, 0, ms);
			var imageByteArray = ms.ToArray();
			return imageByteArray;
		}
			

		private int ConvertPixelsToDp(float pixelValue)
		{
		var dp = (int)((pixelValue) / Resources.DisplayMetrics.Density);
		return dp;
		}
	
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
			

            view = base.OnCreateView(inflater, container, savedInstanceState);

            grid = view.FindViewById<GridView>(Resource.Id.gridview);

            cameraButton = view.FindViewById<Button>(Resource.Id.camera_button);

            galleryButton = view.FindViewById<Button>(Resource.Id.gallery_button);

            noPhotoButton = view.FindViewById<Button>(Resource.Id.no_photo_button);

			styleNavigationBar();

            this.handleClicks();

            return view;


        }


        private void handleClicks(){


            galleryButton.Click += (sender, e) => {

				noPhotoButton.SetBackgroundColor(Color.White);

				noPhotoButton.SetTextColor(Color.Black);

				cameraButton.SetBackgroundColor(Color.White);

				cameraButton.SetTextColor(Color.Black);

                galleryButton.SetBackgroundColor(Color.Black);

                galleryButton.SetTextColor(Color.White);

            };

            cameraButton.Click +=  (sender, e) =>
            {

                noPhotoButton.SetBackgroundColor(Color.White);

                noPhotoButton.SetTextColor(Color.Black);

                galleryButton.SetBackgroundColor(Color.White);

                galleryButton.SetTextColor(Color.Black);

                cameraButton.SetBackgroundColor(Color.Black);

                cameraButton.SetTextColor(Color.White);


            };


			noPhotoButton.Click += (sender, e) =>
			{

				cameraButton.SetBackgroundColor(Color.White);

				cameraButton.SetTextColor(Color.Black);

				galleryButton.SetBackgroundColor(Color.White);

				galleryButton.SetTextColor(Color.Black);

				noPhotoButton.SetBackgroundColor(Color.Black);

				noPhotoButton.SetTextColor(Color.White);

			};

        }

		private void styleNavigationBar() { 
		
			  cancel = (ImageButton)this.Activity.FindViewById(Resource.Id.logout);

//cancel.SetBackgroundColor(Color.Transparent);

var toolbar = (Android.Support.V7.Widget.Toolbar)this.Activity.FindViewById(Resource.Id.toolbar);

toolbar.SetBackgroundColor(Color.White);

var text = (TextView)this.Activity.FindViewById(Resource.Id.myTitle);

text.Visibility = ViewStates.Gone;

var logo = (ImageView)this.Activity.FindViewById(Resource.Id.home);

cancel.SetImageResource(Resource.Drawable.cancel);

logo.SetImageResource(Resource.Drawable.header);


		
		}


    }

    public class ImageAdapterTest : BaseAdapter
    {

        private readonly List<string> thumbIds;

        private readonly Context context;
        int width = 0;
        public ImageAdapterTest(Context c, List<string> thumbIds, int width)
        {
            context = c;
            this.thumbIds = thumbIds;
            this.width = width;
        }

        public override int Count
        {
            get { return thumbIds.Count(); }
        }

        public override Java.Lang.Object GetItem(int position)
        {
            return null;
        }

        public override long GetItemId(int position)
        {
            return 0;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            ImageView imageView;

            if (convertView == null)
            {
                // if it's not recycled, initialize some attributes
                imageView = new ImageView(context);
                int size = (int)(width * .29);
                imageView.LayoutParameters = new AbsListView.LayoutParams(size, size);
                imageView.SetScaleType(ImageView.ScaleType.CenterCrop);
                //imageView.SetPadding(8, 8, 8, 8);
            }
            else
            {
                imageView = (ImageView)convertView;
            }
			BitmapFactory.Options options = new BitmapFactory.Options();
            options.InSampleSize = 8;
            Bitmap picture = BitmapFactory.DecodeFile(thumbIds[position], options);
			//Picasso.With(context).Load(thumbIds[position]).Resize(50, 50).CenterCrop().Into(imageView);
            imageView.SetImageBitmap(picture);
            return imageView;
        }

    }



}
