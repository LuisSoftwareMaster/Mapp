// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace PorpoiseMobileApp.iOS
{
    [Register ("ActivityViewController")]
    partial class ActivityViewController
    {
        /*[Outlet]
UIKit.UITableView UserActivityTableView { get; set; }*/



        [Outlet]
        PorpoiseTableView CompanyActivityTableView { get; set; }



        [Outlet]
        UIKit.UIView Overlay { get; set; }



        [Outlet]
        UIKit.UIActivityIndicatorView Waiting { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView OverlayImage { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (CompanyActivityTableView != null) {
                CompanyActivityTableView.Dispose ();
                CompanyActivityTableView = null;
            }

            if (Overlay != null) {
                Overlay.Dispose ();
                Overlay = null;
            }

            if (OverlayImage != null) {
                OverlayImage.Dispose ();
                OverlayImage = null;
            }
        }
    }
}