using Android.App;
using Android.Content;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.Droid.BindingContext;
using MvvmCross.Binding.Droid.Views;
using MvvmCross.Droid.Support.V7.AppCompat.Widget;
using MvvmCross.Platform;
using MvvmCross.Plugins.Permissions;
using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
using PorpoiseMobileApp.Converters;
using PorpoiseMobileApp.Droid.Helpers;
using PorpoiseMobileApp.Models;
using PorpoiseMobileApp.ViewModels;
using System;

using Android.Util;
using PorpoiseMobileApp.Droid.Converters;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using PorpoiseMobileApp.Droid.Converters;

using Android.Util;
using MvvmCross.Core.ViewModels;
using Android.Views.Animations;

namespace PorpoiseMobileApp.Droid.Views
{
   // [MenuItem(MenuItem.LogHours)]
    public class LogHoursView : MvvmFragment<LogHoursViewModel>
    {
        public static readonly int PickImageId = 1000;
        private MvxImageView _imageView;
        TextView _dateDisplay;
        Button _dateSelectButton;
        IMvxPermissions _permissions;
        private MvxAppCompatSpinner ddlGoals;
        private string hoursError;
        private string highlightError;
        private Button btnDone;
        private Button btnCancel;
        private ImageView btnRotateLeft;
        private ImageView btnRotateRight;
        private EditText txtHours;
        private TextInputLayout hoursInputLayout;
        private EditText txtHighlight;
        private TextInputLayout highlightInputLayout;
        private OrganisationSpinner ddlOrgs;
        private RelativeLayout _datepickerContainer;
        private Organisation _currentOrganisation;

        public LogHoursView() : base(Resource.Layout.LogHoursView)
        {
            _permissions = Mvx.Resolve<IMvxPermissions>();

        }
        protected override bool RespondToViewModelChanges
        {
            get
            {
                return true;
            }
        }
        public override void OnViewModelSet()
        {
            base.OnViewModelSet();

            ViewModel.GetPostDetailsEvent += (s, e) =>
            {
                if (!e.Successful)
                {
                    this.Alert(PorpoiseMobileApp.Droid.Extensions.AlertType.Error, PorpoiseMobileApp.Resource.ProblemOccurred, e.Message, null, Resource.Style.PorpoiseDialogTheme);
                }
            };
        }

        public override void OnActivityCreated(Bundle savedInstanceState)
        {
            base.OnActivityCreated(savedInstanceState);

            _dateSelectButton.Click += (s, e) =>
            {
                BuildDatePickerDialog();
            };

            _imageView.SetImageDrawable(Resources.GetDrawable(Resource.Drawable.Camera_Icon_Btn_Sm));
            _imageView.Click += OnPickImageClicked;

            btnRotateLeft.Click += RotatePictureLeftClicked;
            btnRotateRight.Click += RotatePictureRightClicked;

            Bindings.Bind(ddlOrgs).For(x => x.ItemsSource).To(vm => vm.Organisations).WithConversion(new BlankDropdownValueConverter<Organisation>(new Organisation { Name = " ", isEmpty = true, Id = Guid.NewGuid() }));
            Bindings.Bind(ddlOrgs).For(x => x.SelectedItem).To(vm => vm.Organisation);
            ddlOrgs.Adapter = new LogHour_DropdownAdapter(this.Context, (IMvxAndroidBindingContext)BindingContext);
            
            ddlGoals.Adapter = new LogHour_DropdownAdapter(this.Context, (IMvxAndroidBindingContext)BindingContext);
            Bindings.Bind(ddlGoals).For(x => x.ItemsSource).To(vm => vm.Goals).WithConversion(new BlankDropdownValueConverter<Goal>(new Goal { Name = " ", isEmpty = true, Id = Guid.NewGuid() }));
            Bindings.Bind(ddlGoals).For(x => x.SelectedItem).To(vm => vm.Goal);

            Bindings.Bind(btnDone).For(x => x.Enabled).To(vm => vm.InFlight).WithConversion(new InverseConverter());
            Bindings.Bind(txtHighlight).For(x => x.Text).To(vm => vm.Highlight);
            Bindings.Bind(txtHours).For(x => x.Text).To(vm => vm.HourAmount).WithConversion(new DoubleCantBe0ToStringConverter());
            Bindings.Bind(_dateDisplay).For(x => x.Text).To(vm => vm.Date).WithConversion(new LongDateConverter("MMMM, dd yyyy"));

            if (ViewModel.IsEditing)
            {

                _currentOrganisation = ViewModel.Organisation;
                btnDone.Text = PorpoiseMobileApp.Resource.Update;
                Bindings.Bind(btnDone).To(vm => vm.UpdateLogCommand);
                ViewModel.GetPostDetailsEvent += (s, e) =>
                {
                    if (e.Successful)
                    {
                        _imageView.ImageUrl = this.ViewModel.PhotoUrl;
                        _currentOrganisation = ViewModel.Organisation;
                    }
                };
                ViewModel.UpdateLogEvent += (s, e) =>
                {
                    if (e.Successful)
                    {
                        this.Alert(PorpoiseMobileApp.Droid.Extensions.AlertType.Message, PorpoiseMobileApp.Resource.Success, e.Message, x =>
                        {
                            switch (x)
                            {
                                case DialogButtonType.Positive:
                                    ViewModel.ReturnToProfile();
                                    break;
                            }
                        }, Resource.Style.PorpoiseDialogTheme);
                    }
                    else
                    {
                        this.Alert(PorpoiseMobileApp.Droid.Extensions.AlertType.Error, PorpoiseMobileApp.Resource.Error, e.Message, x =>
                        {
                            switch (x)
                            {
                                case DialogButtonType.Positive:
                                    break;
                            }
                        }, Resource.Style.PorpoiseDialogTheme);
                    }
                };
            }
            else
            {
                Bindings.Bind(btnDone).To(vm => vm.LogHoursCommand);
                btnDone.Text = PorpoiseMobileApp.Resource.Post;
                ViewModel.LogHoursEvent += (s, e) =>
                {
                    if (e.Successful)
                    {
                        this.Alert(PorpoiseMobileApp.Droid.Extensions.AlertType.Message, PorpoiseMobileApp.Resource.Success, e.Message, x =>
                        {
                            switch (x)
                            {
                                case DialogButtonType.Positive:
                                    ViewModel.ReturnToProfile();
                                    break;
                            }
                        }, Resource.Style.PorpoiseDialogTheme);
                    }
                    else
                    {
                        this.Alert(PorpoiseMobileApp.Droid.Extensions.AlertType.Error, PorpoiseMobileApp.Resource.Error, e.Message, x =>
                        {
                            switch (x)
                            {
                                case DialogButtonType.Positive:
                                    break;
                            }
                        }, Resource.Style.PorpoiseDialogTheme);
                    }
                };

            }
            
            Bindings.Apply();

            ViewModel.UploadAssetEvent += (s, e) =>
            {
                if (!e.Successful)
                {
                    this.Alert(PorpoiseMobileApp.Resource.Error, e.Message, null, Resource.Style.PorpoiseDialogTheme);
                }
            };


            btnCancel.Click += (sender, e) =>
            {
                if (this.IsDirty)
                {
                    this.Alert(PorpoiseMobileApp.Droid.Extensions.AlertType.Confirm, PorpoiseMobileApp.Resource.AreYouSure, PorpoiseMobileApp.Resource.UnsavedChanges, x =>
                    {
                        if (x == DialogButtonType.Positive)
                        {
                            ViewModel.ReturnToProfile();
                        }
                    }, Resource.Style.PorpoiseDialogTheme);
                }
                else
                {
                    ViewModel.ReturnToProfile();
                }
            };


            txtHours.Text = "";
            txtHours.FocusChange += (s, e) =>
            {
                if (!txtHours.HasFocus && !validHourAmount(txtHours.Text))
                {
                    hoursInputLayout.Error = hoursError;
                }
                else
                {
                    hoursInputLayout.ErrorEnabled = false;
                }
            };

            txtHighlight.FocusChange += (s, e) =>
            {
                if (!txtHighlight.HasFocus && !ViewModel.HighlightValid)
                {
                    highlightInputLayout.Error = highlightError;
                }
                else
                {
                    highlightInputLayout.ErrorEnabled = false;
                }
            };

            ViewModel.ForPropertyChange(x => x.Date, y =>
            {
                {
                    if (!Validation.IsValidDate(_dateDisplay.Text))
                    {
                        _datepickerContainer.Background = Resources.GetDrawable(Resource.Drawable.redBorderStyle);
                    }
                    else
                    {
                        _datepickerContainer.Background = Resources.GetDrawable(Resource.Drawable.WhiteBorderStyle);
                    }
                };
            });
            ddlOrgs.ItemSelected += (s, e) =>
            {
                System.Console.WriteLine("SELECTING ORGANISATION");
                var selectedOrg = ((Organisation)(ddlOrgs.SelectedView as MvxListItemView).DataContext);
                var selected = ddlOrgs.SelectedItem;
                
                Console.WriteLine("SELECTED ORGANISATION " + selectedOrg.Name);
               // BuildNewOrganisationDialog(selectedOrg);
                if (selectedOrg != null && selectedOrg.Name.Equals(PorpoiseMobileApp.Resource.Other))
                {
                    if (!_dontShowOtherAlert)
                    {
                        Console.WriteLine("WRITING NEW DIALOG");
                        BuildNewOrganisationDialog(selectedOrg);
                    }

                }
            };
            ViewModel.ForPropertyChange(x => x.Organisation, y =>
            {
                var selectedOrg = ((Organisation)(ddlOrgs.SelectedView as MvxListItemView).DataContext);
                if (selectedOrg == null || string.IsNullOrEmpty(selectedOrg.Name))
                {
                    ddlOrgs.Background = Resources.GetDrawable(Resource.Drawable.redBorderStyle);
                }
                else
                {
                    ddlOrgs.Background = Resources.GetDrawable(Resource.Drawable.WhiteBorderStyle);
                }

            });

            ViewModel.ForPropertyChange(x => x.Goal, y =>
            {
                var selectedGoal = ((Goal)(ddlGoals.SelectedView as MvxListItemView).DataContext);
                if (selectedGoal == null || string.IsNullOrEmpty(selectedGoal.Name))
                {
                    ddlGoals.Background = Resources.GetDrawable(Resource.Drawable.redBorderStyle);
                }
                else
                {
                    ddlGoals.Background = Resources.GetDrawable(Resource.Drawable.WhiteBorderStyle);
                }

            });

        }


        private void BuildDatePickerDialog()
        {
            DateTime today = DateTime.Today;
            DatePickerDialog dialog = new DatePickerDialog(this.Activity, 5, OnDateSet, today.Year, today.Month - 1, today.Day);

            DateTime _dt_now = DateTime.Now;
            DateTime _start = new DateTime(1970, 1, 1);
            TimeSpan ts = (_dt_now - _start);

            int maxNumOfDays = ts.Days + 1;
            dialog.DatePicker.MaxDate = (long)(TimeSpan.FromDays(maxNumOfDays).TotalMilliseconds);

            int minNumOfDays = ts.Days - 366;
            dialog.DatePicker.MinDate = (long)(TimeSpan.FromDays(minNumOfDays).TotalMilliseconds);

            var m = ViewModel.Date.Month - 1;
            var d = ViewModel.Date.Day;
            var y = ViewModel.Date.Year;
            dialog.DatePicker.UpdateDate(y, m, d);
            dialog.Show();
        }

        private void BuildNewOrganisationDialog(Organisation selectedOrg)
        {
            Android.App.AlertDialog.Builder builder = new Android.App.AlertDialog.Builder(this.Activity, Resource.Style.PorpoiseDialogTheme);

            Android.App.AlertDialog alertDialog = builder.Create();
            alertDialog.SetTitle(PorpoiseMobileApp.Resource.NewOrganization);
            alertDialog.SetIcon(Resource.Drawable.logo_small2_cyan);
            alertDialog.SetMessage(PorpoiseMobileApp.Resource.NewOrganizationMessage);
            EditText newOrgInput = new EditText(this.Activity);
            LinearLayout.LayoutParams lp = new LinearLayout.LayoutParams(LinearLayout.LayoutParams.WrapContent, LinearLayout.LayoutParams.MatchParent);
            lp.RightMargin = 30;
            lp.LeftMargin = 30;
            newOrgInput.LayoutParameters = lp;
            alertDialog.SetView(newOrgInput);

            alertDialog.SetButton("Save", (sender, ev) =>
            {
                if (string.IsNullOrEmpty(newOrgInput.Text) || newOrgInput.Text.Equals(PorpoiseMobileApp.Resource.Other, StringComparison.InvariantCultureIgnoreCase))
                {
                    ViewModel.Organisation = ViewModel.Organisations.FirstOrDefault(x => x.isEmpty);
                    ddlOrgs.Background = Resources.GetDrawable(Resource.Drawable.redBorderStyle);
                    ddlOrgs.RequestLayout();
                }
                else
                {
                    var newOrg = new Organisation
                    {
                        Id = new Guid(),
                        Name = newOrgInput.Text
                    };
                    _dontShowOtherAlert = true;
                    ViewModel.Organisations.Add(newOrg);
                    this.ViewModel.Organisation = newOrg;
                    ViewModel.RaisePropertyChanged(() => ViewModel.Organisations);
                    ViewModel.RaisePropertyChanged(() => ViewModel.Organisation);
                    ddlOrgs.RequestLayout();
                    _dontShowOtherAlert = false;
                    alertDialog.Dismiss();
                }
            });

            alertDialog.SetButton2(PorpoiseMobileApp.Resource.Cancel, (s, e) =>
            {
                _dontShowOtherAlert = true;

                if (!ViewModel.IsEditing)
                {
                    //if user clicks cancel, make the selected item the empty one
                    ViewModel.Organisation = ViewModel.Organisations.FirstOrDefault(x => x.isEmpty);
                }
                else
                {
                    //if the user is editing and the user clicks cancel, revert the selected back to what it was originally.
                    ViewModel.Organisation = _currentOrganisation;
                    if (ViewModel.Organisation != null && !ViewModel.Organisation.Name.Equals(PorpoiseMobileApp.Resource.Other, StringComparison.InvariantCultureIgnoreCase))
                    {
                        ddlOrgs.Background = Resources.GetDrawable(Resource.Drawable.WhiteBorderStyle);
                    }
                }

                var selectedPosition = ddlOrgs.SelectedItemPosition;
                //Console.WriteLine("SELECTED "+selectedPosition)
                ddlOrgs.SetSelection((int)selectedPosition);
                ViewModel.RaisePropertyChanged(() => ViewModel.Organisation);

                ddlOrgs.RequestLayout();
                _dontShowOtherAlert = false;
                alertDialog.Dismiss();
                if (selectedOrg != null && selectedOrg.Name.Equals(PorpoiseMobileApp.Resource.Other, StringComparison.InvariantCultureIgnoreCase))
                {
                    if (ViewModel.IsEditing && ViewModel.Organisation != null && !ViewModel.Organisation.Name.Equals(PorpoiseMobileApp.Resource.Other, StringComparison.InvariantCultureIgnoreCase))
                    {
                        ddlOrgs.Background = Resources.GetDrawable(Resource.Drawable.WhiteBorderStyle);
                    }
                    else
                    {
                        ddlOrgs.Background = Resources.GetDrawable(Resource.Drawable.redBorderStyle);
                    }

                }
            });

            alertDialog.Show();
            ShowSoftKeyboard(this.View);
        }

        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            base.OnViewCreated(view, savedInstanceState);
            hoursError = Resources.GetString(Resource.String.hoursAmount_invalid);
            highlightError = Resources.GetString(Resource.String.highlight_invalid);
            _imageView = view.FindViewById<MvxImageView>(Resource.Id.selectedImage);
            btnDone = view.FindViewById<Button>(Resource.Id.btnDone);
            btnCancel = view.FindViewById<Button>(Resource.Id.btnCancel);
            btnRotateLeft = view.FindViewById<ImageView>(Resource.Id.rotateLeftBtn);
            btnRotateRight = view.FindViewById<ImageView>(Resource.Id.rotateRightBtn);
            txtHours = view.FindViewById<EditText>(Resource.Id.txtHourAmount);
            hoursInputLayout = view.FindViewById<TextInputLayout>(Resource.Id.hoursInputLayout);
            txtHighlight = view.FindViewById<EditText>(Resource.Id.txtHighlight);
            highlightInputLayout = view.FindViewById<TextInputLayout>(Resource.Id.highlightInputLayout);
            ddlOrgs = view.FindViewById<OrganisationSpinner>(Resource.Id.ddlOrganisations);
            ddlGoals = view.FindViewById<MvxAppCompatSpinner>(Resource.Id.ddlGoals);
            _dateDisplay = view.FindViewById<TextView>(Resource.Id.txtDateDisplay);
            _dateSelectButton = view.FindViewById<Button>(Resource.Id.btnSelectDate);
            _datepickerContainer = view.FindViewById<RelativeLayout>(Resource.Id.datePickerContainer);

           //ddlOrgs.SetSelection(0);

        }


        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, Android.Content.PM.Permission[] grantResults)
        {

            PermissionsImplementation.Current.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        public override bool ShouldShowRequestPermissionRationale(string permission)
        {
            return base.ShouldShowRequestPermissionRationale(permission);
        }

        void OnDateSet(object sender, DatePickerDialog.DateSetEventArgs e)
        {
            this.ViewModel.Date = e.Date;
            _dateDisplay.Text = e.Date.ToShortDateString();
        }

        PermissionStatus statusCamera;
        PermissionStatus statusStorage;
        async void OnPickImageClicked(object sender, EventArgs e)
        {


            statusStorage = await _permissions.CheckPermissionStatusAsync(Plugin.Permissions.Abstractions.Permission.Storage);
            statusCamera = await _permissions.CheckPermissionStatusAsync(Plugin.Permissions.Abstractions.Permission.Camera);

            Android.App.AlertDialog.Builder builder = new Android.App.AlertDialog.Builder(this.Activity, Resource.Style.PorpoiseDialogTheme);
            Android.App.AlertDialog alertDialog = builder.Create();
            alertDialog.SetTitle(PorpoiseMobileApp.Resource.PickImage);
            alertDialog.SetIcon(Resource.Drawable.logo_small2_cyan);
            alertDialog.SetMessage(PorpoiseMobileApp.Resource.ChooseImageSourceMessage);



            alertDialog.SetButton(PorpoiseMobileApp.Resource.Gallery, async (s, ev) =>
            {
                if (statusStorage != PermissionStatus.Granted)
                {
                    var results = await _permissions.RequestPermissionsAsync(new[] { Plugin.Permissions.Abstractions.Permission.Storage });
                    statusStorage = results[Plugin.Permissions.Abstractions.Permission.Storage];
                }

                if (statusStorage == PermissionStatus.Granted)
                {
                    // Show Gallery
                    ViewModel.ChoosePictureCommand.Execute(null);
                }
                //else show alert that they denied the permission
            });

            // Camera
            alertDialog.SetButton2(PorpoiseMobileApp.Resource.Camera, async (s, ev) =>
            {
                if (statusCamera != PermissionStatus.Granted || statusStorage != PermissionStatus.Granted)
                {
                    var results = await _permissions.RequestPermissionsAsync(new[] { Plugin.Permissions.Abstractions.Permission.Camera, Plugin.Permissions.Abstractions.Permission.Storage });
                    statusCamera = results[Plugin.Permissions.Abstractions.Permission.Camera];
                    statusStorage = results[Plugin.Permissions.Abstractions.Permission.Storage];
                }
                if (statusCamera == PermissionStatus.Granted && statusStorage == PermissionStatus.Granted)
                {
                    ViewModel.TakePictureCommand.Execute(null);
                }
                //else show alert that they denied the permission
            });

            alertDialog.Show();
        }

        private void RotatePictureLeftClicked(object sender, EventArgs e)
        {
            try
            {
                ViewModel.RotateLeftPictureCommand.Execute(null);
            }
            catch (Exception ex)
            {
                this.Alert(PorpoiseMobileApp.Resource.Oops, ex.Message, null, Resource.Style.PorpoiseDialogTheme);

            }

        }

        private void RotatePictureRightClicked(object sender, EventArgs e)
        {
            try
            {
                ViewModel.RotateRightPictureCommand.Execute(null);
            }
            catch (Exception ex)
            {
                this.Alert(PorpoiseMobileApp.Resource.Oops, ex.Message, null, Resource.Style.PorpoiseDialogTheme);

            }

        }

        private float bar_elevation;
        private bool _dontShowOtherAlert;

        public override void OnResume()
        {
            base.OnResume();
            var actionBar = ((AppCompatActivity)Activity).SupportActionBar;
            bar_elevation = actionBar.Elevation;
            actionBar.Elevation = 0;
        }

        public override void OnStop()
        {
            base.OnStop();
            var actionBar = ((AppCompatActivity)Activity).SupportActionBar;
            actionBar.Elevation = bar_elevation;
        }



        private bool validHourAmount(string text)
        {
            var validNumber = Validation.IsNumeric(text);
            if (!validNumber)
            {
                return false;
            }
            return true;
        }



        public class LogHour_DropdownAdapter : MvxAdapter
        {
            private int _itemTemplateId = Resource.Layout.goal_spinnerItem;

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

            public LogHour_DropdownAdapter(Context context, IMvxBindingContext bindingContext) : base(context, (IMvxAndroidBindingContext)bindingContext)
            {
                this.context = context;
            }



            protected override View GetBindableView(View convertView, object source, int templateId)
            {
                Console.WriteLine("INSIDE ADAPTER");

                if (source is Goal)
                {
                    templateId = Resource.Layout.goal_spinnerItem;
                }
                else if (source is Organisation)
                {
                    templateId = Resource.Layout.organisation_spinnerItem;
                }

                return base.GetBindableView(convertView, source, templateId);
            }


            public override View GetDropDownView(int position, View convertView, ViewGroup parent)
            {
                View v = null;
                Console.WriteLine("INSIDE ADAPTER 2");
                

                // If this is the initial dummy entry, make it hidden
                if (position == 0)
                {
                    TextView tv = new TextView(parent.Context);
                    tv.SetHeight(0);
                    tv.Visibility = ViewStates.Gone;
                    v = tv;
                }
                else
                {
                    // Pass convertView as null to prevent reuse of special case views
                    v = base.GetDropDownView(position, null, parent);
                }

                // Hide scroll bar because it appears sometimes unnecessarily, this does not prevent scrolling 
                parent.VerticalScrollBarEnabled = false;
                return v;
            }
        }
    }


    public class OrganisationSpinner : MvxAppCompatSpinner
    {

        public OrganisationSpinner(Context context, IAttributeSet attrs) : base(context, attrs)
        {

        }
        public override void SetSelection(int position)
        {
            var sameSelected = position == SelectedItemPosition;
            base.SetSelection(position);
            if (sameSelected)
            {
                OnItemSelectedListener.OnItemSelected(this, SelectedView, position, SelectedItemId);
            }
        }


    }
}