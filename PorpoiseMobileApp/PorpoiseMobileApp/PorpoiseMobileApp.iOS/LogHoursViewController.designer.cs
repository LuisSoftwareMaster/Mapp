// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace PorpoiseMobileApp.iOS
{
    [Register ("LogHoursViewController")]
    partial class LogHoursViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton AddImage { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        PorpoiseMobileApp.iOS.PorpoiseButton btnCancel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        PorpoiseMobileApp.iOS.PorpoiseButton btnDone { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView CameraIcon { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        PorpoiseMobileApp.iOS.PorpoiseEditText DateSelection { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        PorpoiseMobileApp.iOS.PorpoiseEditText GoalSelection { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView Highlight { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        PorpoiseMobileApp.iOS.PorpoiseEditText Hour { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView LogHoursContainer { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        PorpoiseMobileApp.iOS.PorpoiseEditText OrganisationSelection { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIScrollView ScrollView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView UploadedImage { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIActivityIndicatorView waiting { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (AddImage != null) {
                AddImage.Dispose ();
                AddImage = null;
            }

            if (btnCancel != null) {
                btnCancel.Dispose ();
                btnCancel = null;
            }

            if (btnDone != null) {
                btnDone.Dispose ();
                btnDone = null;
            }

            if (CameraIcon != null) {
                CameraIcon.Dispose ();
                CameraIcon = null;
            }

            if (DateSelection != null) {
                DateSelection.Dispose ();
                DateSelection = null;
            }

            if (GoalSelection != null) {
                GoalSelection.Dispose ();
                GoalSelection = null;
            }

            if (Highlight != null) {
                Highlight.Dispose ();
                Highlight = null;
            }

            if (Hour != null) {
                Hour.Dispose ();
                Hour = null;
            }

            if (LogHoursContainer != null) {
                LogHoursContainer.Dispose ();
                LogHoursContainer = null;
            }

            if (OrganisationSelection != null) {
                OrganisationSelection.Dispose ();
                OrganisationSelection = null;
            }

            if (ScrollView != null) {
                ScrollView.Dispose ();
                ScrollView = null;
            }

            if (UploadedImage != null) {
                UploadedImage.Dispose ();
                UploadedImage = null;
            }

            if (waiting != null) {
                waiting.Dispose ();
                waiting = null;
            }
        }
    }
}