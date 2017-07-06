// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace PorpoiseMobileApp.iOS
{
    [Register ("LogHourPhotoViewController")]
    partial class LogHourPhotoViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView buttons { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton CameraButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton GalleryButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        PorpoiseMobileApp.iOS.PorpoiseView HeaderView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView mainView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton NoPhotoButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.NSLayoutConstraint width { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (buttons != null) {
                buttons.Dispose ();
                buttons = null;
            }

            if (CameraButton != null) {
                CameraButton.Dispose ();
                CameraButton = null;
            }

            if (GalleryButton != null) {
                GalleryButton.Dispose ();
                GalleryButton = null;
            }

            if (HeaderView != null) {
                HeaderView.Dispose ();
                HeaderView = null;
            }

            if (mainView != null) {
                mainView.Dispose ();
                mainView = null;
            }

            if (NoPhotoButton != null) {
                NoPhotoButton.Dispose ();
                NoPhotoButton = null;
            }

            if (width != null) {
                width.Dispose ();
                width = null;
            }
        }
    }
}