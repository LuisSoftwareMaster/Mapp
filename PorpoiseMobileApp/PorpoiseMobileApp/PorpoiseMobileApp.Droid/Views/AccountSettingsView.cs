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
using PorpoiseMobileApp.Droid.Helpers;
using PorpoiseMobileApp.ViewModels;
using Android.Webkit;
using PorpoiseMobileApp.Droid.Interfaces;

namespace PorpoiseMobileApp.Droid.Views
{
    
	[MenuItem(MenuItem.AccountSettings)]
	public class AccountSettingsView : MvvmFragment<AccountSettingsViewModel>, IHandleBack
	{
		private bool _openedBrowser;

		public AccountSettingsView() : base(Resource.Layout.AccountSettingsView)
		{
		}
        
		public override void OnViewCreated(View view, Bundle savedInstanceState)
		{
			base.OnViewCreated(view, savedInstanceState);
            //var webview = view.FindViewById<WebView>(Resource.Id.settingsWebView);
            //         var webClient = new PorpoiseWebChromeClient((uploadMsg, acceptType, capture) =>
            //         {
            //             //UploadMessage = uploadMsg;
            //             if (Build.VERSION.SdkInt < BuildVersionCodes.Kitkat)
            //             {

            //                 //Here File Chooser dialog is started as Activity, and it gives result while coming back from that Activity.
            //                 var mediaChooserIntent = new Intent(Intent.ActionGetContent);
            //                 mediaChooserIntent.AddCategory(Intent.CategoryOpenable);
            //                 mediaChooserIntent.SetType("image/*");                
            //                 ((Activity)this.Context).StartActivityForResult(Intent.CreateChooser(mediaChooserIntent, "File Chooser"), 1);
            //             }
            //             else
            //             {
            //                 var mediaChooserIntent = new Intent(Intent.ActionOpenDocument);
            //                 mediaChooserIntent.AddCategory(Intent.CategoryOpenable);
            //                 mediaChooserIntent.SetType("image/*");
            //                 ((Activity)this.Context).StartActivityForResult(Intent.CreateChooser(mediaChooserIntent, "File Chooser"), 1);
            //             }
            //         });
            //         webview.SetWebChromeClient(webClient);
            //         webview.Settings.JavaScriptEnabled = true;
            //         webview.Settings.AllowFileAccess = true;
            //        // webview.Settings.SetGeolocationEnabled(true);
            //         webview.LoadUrl(ViewModel.SettingsUrl);
           
        }

        public override void OnActivityCreated(Bundle savedInstanceState)
        {
            base.OnActivityCreated(savedInstanceState);
            if (!this.IsResumed)
            {
                this.Alert(PorpoiseMobileApp.Droid.Extensions.AlertType.Confirm, "", PorpoiseMobileApp.Resource.LeavingPorpoiseWarning, x =>
                {
                    switch (x)
                    {
                        case DialogButtonType.Positive:
                            _openedBrowser = true;
                            var settingsIntent = new Intent(action: Intent.ActionView, uri: Android.Net.Uri.Parse(ViewModel.SettingsUrl));
                            StartActivity(settingsIntent);
                            break;
                        case DialogButtonType.Negative:
                            ViewModel.GoBackToProfile();
                            _openedBrowser = false;
                            break;
                    }
                }, Resource.Style.PorpoiseDialogTheme);
            }
            else
            {
                ViewModel.GoBackToProfile();
            }

        }

        public override void OnDetach()
        {
            base.OnDetach();
            ViewModel.GoBackToProfile();
        }

        
        public override void OnResume()
		{
			base.OnResume();
            if (_openedBrowser)
            {                
                ViewModel.GoBackToProfile();
                _openedBrowser = false;
            }

        }

        bool IHandleBack.HandleBack()
        {
            return true;
        }

        internal class PorpoiseWebChromeClient : WebChromeClient
		{
            

            public override void OnPermissionRequest(PermissionRequest request)
            {
                base.OnPermissionRequest(request);
            }

            Action<IValueCallback, Java.Lang.String, Java.Lang.String> callback;

            public PorpoiseWebChromeClient(Action<IValueCallback, Java.Lang.String, Java.Lang.String> callback)
            {
                this.callback = callback;
            }

            //For Android 4.1
            [Java.Interop.Export]
            public void openFileChooser(IValueCallback uploadMsg, Java.Lang.String acceptType, Java.Lang.String capture)
            {
                callback(uploadMsg, acceptType, capture);
            }

            // For Android > 5.0
            [Android.Runtime.Register("onShowFileChooser", "(Landroid/webkit/WebView;Landroid/webkit/ValueCallback;Landroid/webkit/WebChromeClient$FileChooserParams;)Z", "GetOnShowFileChooser_Landroid_webkit_WebView_Landroid_webkit_ValueCallback_Landroid_webkit_WebChromeClient_FileChooserParams_Handler")]
            public override Boolean OnShowFileChooser(Android.Webkit.WebView webView, IValueCallback uploadMsg, WebChromeClient.FileChooserParams fileChooserParams)
            {
                try
                {
                    callback(uploadMsg, null, null);
                }
                catch (Exception e)
                {

                }
                return true;
            }

        }

	}


}