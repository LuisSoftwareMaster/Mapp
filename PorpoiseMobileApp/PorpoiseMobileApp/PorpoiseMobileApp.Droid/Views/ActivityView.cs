using System;
using System.Collections.Generic;
using System.Linq;
using Android.Content;
using Android.OS;
using Android.Views;
using Android.Widget;
using PorpoiseMobileApp.Models;
using MvvmCross.Binding.Droid.Views;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.Droid.BindingContext;
using PorpoiseMobileApp.Droid.Helpers;
using PorpoiseMobileApp.Converters;
using PorpoiseMobileApp.Droid.Converters;
using R = PorpoiseMobileApp.Resource;
using Android.Graphics;
using System.Diagnostics.Contracts;
using Java.Net;
using Java.IO;
using System.Net;
using Android.App;
using PorpoiseMobileApp.ViewModels;
using Android.Util;

namespace PorpoiseMobileApp.Droid.Views
{

    [MenuItem(MenuItem.Activity)]
    public class ActivityView : MvvmFragment<ActivityViewModel>
    {

        List<HourLog> userPosts = new List<HourLog>();

        List<HourLog> allPosts = new List<HourLog>();

        Action<int> doUpdateDisplay;

        private const int USER_TAB = 0;
        private const int COMPANY_TAB = 1;
        protected MvxListView list;
        //private SoloTabWidget tabs;
        private View emptyPost;

        public ActivityView() : base(Resource.Layout.ActivityView)
        {

        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            ViewModel.SelectedPostsList = SelectedPostsList.All;
            ViewModel.LoadPosts();
            return base.OnCreateView(inflater, container, savedInstanceState);
        }

        public override void OnResume()
        {
            ViewModel.LoadPosts();
            base.OnResume();
        }
        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            base.OnViewCreated(view, savedInstanceState);



            ViewModel.ForPropertyChange(x => x.ChangedWelldones, async y =>
            {
                //Console.WriteLine("CHANGEWELLDONES IN ANDROID");


                if (this.data_list != null)
                {

                    int count = data_list.Count();
                    int position = 0;
                    for (int i = 0; i < count; i++)
                    {

                        if (ViewModel.CompanyPosts.ElementAt(i).Id.Equals(ViewModel.UpdatedPost.Id))
                        {
                            System.Console.WriteLine("PostFound");

                            HourLog aux = ViewModel.CompanyPosts.ElementAt(i);

                            aux = ViewModel.UpdatedPost;

                            position = i;
                            break;

                        }

                    }

                    await ViewModel.LoadPosts();

                    list.SetSelection(position);
                }



            });


            list = view.FindViewById<MvxListView>(Resource.Id.posts_list);

            list.Divider = null;
            //tabs = view.FindViewById<SoloTabWidget>(Android.Resource.Id.Tabs);
            emptyPost = view.FindViewById(Resource.Id.activity_empty_post_item);

            //list.Clickable = true;
            Bindings.Bind(list).For(x => x.ItemClick).To(vm => vm.PostItemSelectCommand);
            Bindings.Apply();

            ViewModel.OnPostsLoaded += (s, e) =>
            {
                doUpdateDisplay.Invoke((int)ViewModel.SelectedPostsList);
            };
            System.Console.WriteLine("ON VIEW CREATED");






        }
        IOrderedEnumerable<HourLog> data_list;



        public override void OnActivityCreated(Bundle savedInstanceState)
        {
            base.OnActivityCreated(savedInstanceState);

            //tabs.LayoutId = Resource.Layout.single_tab_indicator;
            //tabs.AddTab(Resources.GetString(Resource.String.UserActivity));
            //tabs.AddTab(Resources.GetString(Resource.String.AllActivity));
            //tabs.FocusCurrentTab((int)ViewModel.SelectedPostsList);

            this.ViewModel.PostItemClickEvent += (s, e) =>
            {
                HandlePostItemClick(e);
            };

            doUpdateDisplay = index =>
            {
                ViewModel.SelectedPostsList = SelectedPostsList.All;
                data_list = ViewModel.CompanyPosts.OrderByDescending(x => x.Date);
                if (data_list.Count() == 0)
                {
                    list.Visibility = ViewStates.Invisible;
                    emptyPost.Visibility = ViewStates.Visible;
                }
                else
                {
                    emptyPost.Visibility = ViewStates.Gone;
                    list.Visibility = ViewStates.Visible;
                }
                list.ItemsSource = data_list;
                MvxAdapter adapter = new PostItemAdapter(this.Activity, (IMvxAndroidBindingContext)this.BindingContext, this);
                list.Adapter = adapter;
                list.RequestLayout();

            };

            //doUpdateDisplay = index =>
            //{
            //    switch (index)
            //    {
            //        case USER_TAB:
            //            if (ViewModel.UserPosts.Count() <= 0)
            //            {
            //                list.Visibility = ViewStates.Invisible;
            //                emptyPost.Visibility = ViewStates.Visible;
            //            }
            //            else
            //            {

            //                adapter = new PostItemAdapter(this.Activity, (IMvxAndroidBindingContext)this.BindingContext, this);
            //                list.Adapter = adapter;
            //                list.ItemsSource = ViewModel.UserPosts.OrderByDescending(x => x.Date);
            //                list.Visibility = ViewStates.Visible;
            //                emptyPost.Visibility = ViewStates.Gone;
            //                list.RequestLayout();
            //            }

            //            break;
            //        case COMPANY_TAB:
            //list.Visibility = ViewStates.Visible;
            //emptyPost.Visibility = ViewStates.Gone;
            //adapter = new PostItemAdapter(this.Activity, (IMvxAndroidBindingContext)this.BindingContext, this);
            //list.Adapter = adapter;
            //list.ItemsSource = ViewModel.CompanyPosts.OrderByDescending(x => x.Date).ThenByDescending(x => x.PostSticky);
            //list.RequestLayout();
            //            break;
            //    }

            //    tabs.SetCurrentTab(index);
            //};

            //tabs.OnTabClicked += (s, e) =>
            //{
            //    var index = e.TabIndex;
            //    ViewModel.LoadPosts();
            //    switch (index)
            //    {
            //        case USER_TAB:
            //            ViewModel.SelectedPostsList = SelectedPostsList.User;
            //            break;
            //        case COMPANY_TAB:
            //            ViewModel.SelectedPostsList = SelectedPostsList.All;
            //            break;
            //        default:
            //            ViewModel.SelectedPostsList = SelectedPostsList.User;
            //            break;
            //    }
            //};

        }

        private void HandlePostItemClick(PostItemEventArgs e)
        {
            HourLog postItem = e.Post;
            if (postItem.PostType == "company" && postItem.MediaType == "youtube")
            {
                //open url
                var videoIntent = new Intent(action: Intent.ActionView, uri: Android.Net.Uri.Parse(postItem.VideoUrl));
                StartActivity(videoIntent);
            }
            else
            {
                //show highlight
                /*AlertDialog.Builder builder = new Android.App.AlertDialog.Builder(this.Activity, Resource.Style.PorpoiseDialogTheme);
                AlertDialog alertDialog = builder.Create();

                alertDialog.SetTitle(e.Title);
                alertDialog.SetIcon(Resource.Drawable.logo_small2_cyan);
                alertDialog.SetMessage(postItem.Highlight);
                alertDialog.SetButton("Done", (s2, e2) => { });
                alertDialog.Show();*/
            }
        }
        private void HandleGiveWelldone(PostItemEventArgs e)
        {



        }
    }

    public class PostItemAdapter : MvxAdapter
    {
        private int _itemTemplateId = Resource.Layout.post_item;
        private ActivityView CurrentActivity;

        public override bool IsEnabled(int position)
        {
            return false;
        }

        public override int ItemTemplateId
        {
            get
            {
                return this._itemTemplateId;
            }
            set
            {
                this._itemTemplateId = value;
            }
        }

        public Context context { get; set; }

        public PostItemAdapter(Context context, IMvxBindingContext bindingContext, object activity = null) : base(context, (IMvxAndroidBindingContext)bindingContext)
        {
            this.context = context;
            if (activity is ActivityView)
            {
                this.CurrentActivity = (ActivityView)activity;
            }
        }

        PopupMenu _menu;

        private PopupWindow _popupWindow;

        private ListView _listView;

        private PopupWindow CreatePopupWindow(Context cont)
        {
            _popupWindow = new PopupWindow(cont);

            var adapter = new ArrayAdapter<string>(cont, Android.Resource.Layout.SimpleDropDownItem1Line, new string[] { "Edit Post", "Delete Post", "Cancel" });
            _listView = new ListView(cont) { Adapter = adapter };

            _listView.ItemClick += async (sender, args) =>
            {

                switch (args.Position)
                {

                    case 0: //Edit Post    
                        CurrentActivity.ViewModel.IsEditing = true;
                        await CurrentActivity.ViewModel.EditPost();
                        _popupWindow.Dismiss();
                        break;
                    case 1: //Delete Post
                            //set alert for executing the task
                        AlertDialog.Builder alert = new AlertDialog.Builder(cont);
                        alert.SetTitle("Confirm delete");
                        alert.SetMessage("Are you sure you want to delete this post?");
                        alert.SetPositiveButton("Delete", async (senderAlert, argss) =>
                        {
                            await CurrentActivity.ViewModel.DeletePost();
                            await CurrentActivity.ViewModel.LoadPosts();
                        });

                        alert.SetNegativeButton("Cancel", (senderAlert, argss) =>
                      {
                          //Toast.MakeText(cont, "Cancelled!", ToastLength.Short).Show();
                      });

                        Dialog dialog = alert.Create();
                        dialog.Show();
                        _popupWindow.Dismiss();
                        break;
                    case 2:
                        _popupWindow.Dismiss();
                        break;
                }


            };

            _popupWindow.Width = ViewGroup.LayoutParams.WrapContent;
            _popupWindow.Height = ViewGroup.LayoutParams.WrapContent;
            _popupWindow.ContentView = _listView;
            return _popupWindow;
        }

        private string GivenwelldoneText(int people)
        {

            if (people == 0)
            {

                return "Be the first to give a WellDone!";

            }
            else if (people == 1)
            {

                return "1 Person gave a WellDone!";

            }
            else
            {

                return people + " People gave a WellDone!";

            }

        }




        private bool givenWelldone(Welldones[] array)
        {

            foreach (Welldones aux in array)
            {

                if (aux.UserId.Equals(AccountInfo.UserId.ToString()))
                {

                    return true;

                }


            }

            return false;

        }


        private int resourceId;

        protected override View GetBindableView(View convertView, object dataContext, int templateId)
        {
            Contract.Ensures(Contract.Result<View>() != null);
            if (dataContext is HourLog)
            {

                templateId = Resource.Layout.post_item;
                var view = base.GetBindableView(convertView, dataContext, templateId);
                var hourLog = dataContext as HourLog;

                var uploadedPic = view.FindViewById<scaleimageview.ScaleImageView>(Resource.Id.image);
                //uploadedPic.SetOnTouchListener(this);
                var employeeName = view.FindViewById<TextView>(Resource.Id.post_details_name);
                var date = view.FindViewById<TextView>(Resource.Id.post_details_date);

                var details = view.FindViewById<TextView>(Resource.Id.details);
                var editButton = view.FindViewById<Button>(Resource.Id.edit_button);
                var profileImage = view.FindViewById<RoundedImageView.MvxRoundedImageView>(Resource.Id.profileImage);

                var wellDoneButton = view.FindViewById<Button>(Resource.Id.well_done);
                var play_button = view.FindViewById<ImageView>(Resource.Id.imgSecond);
                var post_details = view.FindViewById<TextView>(Resource.Id.post);
                var listItem = ((MvxListItemView)view);
                var bindings = listItem.CreateBindingSet<MvxListItemView, HourLog>();
                var location = view.FindViewById<TextView>(Resource.Id.post_city_name);
                var givenWelldonePanel = view.FindViewById<LinearLayout>(Resource.Id.given_Welldone_container);
                var givenWelldoneText = view.FindViewById<TextView>(Resource.Id.givenwelldones_text);
                var lineContainer = view.FindViewById<LinearLayout>(Resource.Id.line_container);
                var givenWelldonesContaner = view.FindViewById<LinearLayout>(Resource.Id.given_Welldone_container);
                var highlightContainer = view.FindViewById<LinearLayout>(Resource.Id.post_details_container_2);
                var imageContainer = view.FindViewById<FrameLayout>(Resource.Id.image_container);
                Typeface employeeNameFont = Typeface.CreateFromAsset(this.context.Assets, "AvenirLT-Book.ttf");

                Typeface locationFont = Typeface.CreateFromAsset(this.context.Assets, "AvenirLT-Book.ttf");

                employeeName.SetTypeface(employeeNameFont, TypefaceStyle.Bold);

                location.SetTypeface(locationFont, TypefaceStyle.Bold);

                bindings.Bind(uploadedPic).For(x => x.ImageUrl).To(x => x.PhotoUrl).WithConversion(new DynamicMvxImageViewConverter());



                //UNCOMMENT
                bindings.Bind(profileImage).For(x => x.ImageUrl).To(x => x.ProfileImage);
                bindings.Bind(location).For(x => x.Text).To(x => x.Location);
                bindings.Bind(date).For(x => x.Text).To(x => x.Date).WithConversion(new LongDateConverter("MMMM dd"));

                //context.SetTheme(Resource.Style.PorpoiseDialogTheme); 

                _menu = new PopupMenu(context, view.FindViewById<Button>(Resource.Id.edit_button), GravityFlags.Right);

                _menu.Menu.Add(1, 1, 1, R.EditPost);
                _menu.Menu.Add(1, 2, 1, R.DeletePost);
                _menu.Menu.Add(1, 3, 3, R.Cancel);

                context.SetTheme(Resource.Style.PorpoiseDialogTheme);

                _menu.MenuItemClick += async (s2, arg2) =>
                {
                    var clicked = arg2.Item;
                    switch (clicked.ItemId)
                    {
                        case 1: //Edit Post    
                            CurrentActivity.ViewModel.IsEditing = true;
                            await CurrentActivity.ViewModel.EditPost();
                            break;
                        case 2: //Delete Post
                            await CurrentActivity.ViewModel.DeletePost();
                            await CurrentActivity.ViewModel.LoadPosts();
                            break;
                    }
                    _menu.Dismiss();
                };

                //wellDoneButton.SetBackgroundColor(Android.Graphics.Color.Yellow);

                editButton.Click -= Post_EditButton_Click; //unti double click
                editButton.Click += Post_EditButton_Click;


                bindings.Bind(editButton).CommandParameter(ItemTemplateId).To(x => x.DeletePostCommand);
                GivenWelldoneObject obj = new GivenWelldoneObject();

                obj.Button = wellDoneButton;

                obj.HourLog = hourLog;

                bindings.Bind(wellDoneButton).For(x => x).To(x => x).WithConversion(new WelldoneButoonConverter(wellDoneButton));
                bindings.Bind(wellDoneButton).CommandParameter(ItemTemplateId).To(x => x.GiveWellDoneCommand);

                if (AccountInfo.UserId.ToString().Equals(hourLog.PosterId))
                {
                    wellDoneButton.Visibility = ViewStates.Gone;

                    if (hourLog.WellDones.Length == 0)
                    {

                        givenWelldonePanel.Visibility = ViewStates.Gone;

                    }
                    else
                    {

                        givenWelldoneText.Text = this.GivenwelldoneText(hourLog.WellDones.Length);

                    }


                }
                else
                {

                    givenWelldoneText.Text = this.GivenwelldoneText(hourLog.WellDones.Length);

                    resourceId = Resource.Drawable.wellDoneGray;

                    if (givenWelldone(hourLog.WellDones))
                    {

                        wellDoneButton.SetBackgroundResource(Resource.Drawable.wellDoneOrange);

                        resourceId = Resource.Drawable.wellDoneOrange;


                    }
                }



                if (hourLog.PostType == "company")
                {
                    bindings.Bind(employeeName).For(x => x.Text).To(x => x.CompanyName);
                    bindings.Bind(details).For(x => x.Text).To(x => x.Highlight);
                    bindings.Bind(profileImage).For(x => x.ImageUrl).To(x => x.CompanyLogo);
                    date.Visibility = ViewStates.Invisible;
                    lineContainer.Visibility = ViewStates.Gone;

                    wellDoneButton.Visibility = ViewStates.Gone;

                    givenWelldonesContaner.Visibility = ViewStates.Gone;

                    highlightContainer.Visibility = ViewStates.Gone;



                }
                else
                {
                    bindings.Bind(employeeName).For(x => x.Text).To(x => x.EmployeeName);
                    bindings.Bind(profileImage).For(x => x.ImageUrl).To(x => x.ProfileImage);
                    bindings.Bind(post_details).For(x => x.Text).To(x => x.Highlight);
                }

                bindings.Apply();
                //this.scaleImage(uploadedPic);
                //uploadedPic.SetScaleType(Android.Widget.ImageView.ScaleType.CenterCrop);
                //this.setScaleImage(uploadedPic, uploadedPic.ImageUrl);
                //uploadedPic.LayoutParameters.Height = uploadedPic.MeasuredWidth;
                if (hourLog.PostType == "user")
                {
                    DesignPostLayoutHelper.SetupDetailsTextView(this.Context, details, hourLog);

                }


                System.Console.WriteLine("UPLOADEDPIC HEIGHT: " + uploadedPic.MeasuredHeight + "-" + uploadedPic.Height);



                //if it's the user's post, display the edit button
                if (string.Equals(hourLog.PosterId, AccountInfo.UserId.Value.ToString()))
                {
                    editButton.Visibility = ViewStates.Visible;
                }
                else
                {
                    editButton.Visibility = ViewStates.Gone;
                }

                if (hourLog.PostType == "company" && hourLog.MediaType == "youtube" && !hourLog.MediaType.Equals("none"))
                {
                    play_button.Visibility = ViewStates.Visible;
                }
                else
                {
                    play_button.Visibility = ViewStates.Gone;
                }
                if (hourLog.MediaType.Equals("none"))
                {
                    DisplayMetrics displayMetrics = new DisplayMetrics();

                    ((Activity)this.context).WindowManager.DefaultDisplay.GetMetrics(displayMetrics);
                    int height = displayMetrics.HeightPixels;
                    int width = displayMetrics.WidthPixels;
                    uploadedPic.Visibility = ViewStates.Gone;

                    imageContainer.LayoutParameters.Height = width / 3;

                    imageContainer.SetBackgroundColor(Color.ParseColor(hourLog.BackgroundColor));

                    TextView highlight = new TextView(this.context);

                    highlight.Text = hourLog.Highlight;

                    highlight.Gravity = (GravityFlags.CenterVertical | GravityFlags.Left);

                    imageContainer.AddView(highlight);

                    highlightContainer.Visibility = ViewStates.Gone;
                     
                    lineContainer.Visibility = ViewStates.Gone;

                    FrameLayout.LayoutParams llp = new FrameLayout.LayoutParams(ViewGroup.LayoutParams.WrapContent, ViewGroup.LayoutParams.WrapContent);
                    llp.SetMargins(100, 0, 0, 0); // llp.setMargins(left, top, right, bottom);
                    llp.Gravity = GravityFlags.CenterVertical;
                    highlight.LayoutParameters = llp;

                    highlight.SetTextColor(Color.White);

                    highlight.TextSize = 20f;

                }
                return view;
            }
            return null;

        }
        public Bitmap getBitmapFromURL(String src)
        {
            try
            {
                URL url = new URL(src);
                System.Console.WriteLine("SRC: " + src);
                HttpURLConnection connection = (HttpURLConnection)url.OpenConnection();
                connection.DoInput = true;
                connection.Connect();
                var input = connection.InputStream;
                Bitmap myBitmap = BitmapFactory.DecodeStream(input);
                return myBitmap;
            }
            catch (IOException e)
            {
                // Log exception
                return null;
            }
        }

        private Bitmap GetImageBitmapFromUrl(string url)
        {
            Bitmap imageBitmap = null;

            using (var webClient = new WebClient())
            {
                var imageBytes = webClient.DownloadData(url);
                if (imageBytes != null && imageBytes.Length > 0)
                {
                    imageBitmap = BitmapFactory.DecodeByteArray(imageBytes, 0, imageBytes.Length);
                }
            }

            return imageBitmap;
        }

        /*public void setScaleImage(MvxImageView view, string path)
		{
			// Get the ImageView and its bitmap
			Drawable drawing = view.Drawable;
			var bitmap = this.GetImageBitmapFromUrl(path);
			// Get current dimensions
			int width = bitmap.Width;
			int height = bitmap.Height;

			float xScale = ((float)4) / width;
			float yScale = ((float)4) / height;
			float scale = (xScale <= yScale) ? xScale : yScale;

			Matrix matrix = new Matrix();
			matrix.PostScale(scale, scale);

			Bitmap scaledBitmap = Bitmap.CreateBitmap(bitmap, 0, 0, width, height, matrix, true);
			BitmapDrawable result = new BitmapDrawable(scaledBitmap);
			width = scaledBitmap.Width;
			height = scaledBitmap.Height;

			view.SetImageDrawable(result);

			var pparams = view.LayoutParameters;
			pparams.Width = width;
			pparams.Height = height;
			System.Console.WriteLine("WIDTH: " + pparams.Width);
			System.Console.WriteLine("HEIGHT: " + pparams.Height);

			view.LayoutParameters = pparams;
		}*/



        private void Post_EditButton_Click(object sender, EventArgs e)
        {
            /*_menu.Gravity = GravityFlags.Right;
			_menu.Show();*/

            var popup = CreatePopupWindow(context);
            popup.ShowAsDropDown((View)sender, 0, 0);




        }




    }


}
