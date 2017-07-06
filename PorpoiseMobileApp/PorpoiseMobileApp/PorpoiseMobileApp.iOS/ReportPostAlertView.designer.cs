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
    [Register ("ReportPostAlertView")]
    partial class ReportPostAlertView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView contentView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView porpoiseLogo { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton ReportPost { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton ReportUser { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        PorpoiseMobileApp.iOS.PorpoiseView topView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (contentView != null) {
                contentView.Dispose ();
                contentView = null;
            }

            if (porpoiseLogo != null) {
                porpoiseLogo.Dispose ();
                porpoiseLogo = null;
            }

            if (ReportPost != null) {
                ReportPost.Dispose ();
                ReportPost = null;
            }

            if (ReportUser != null) {
                ReportUser.Dispose ();
                ReportUser = null;
            }

            if (topView != null) {
                topView.Dispose ();
                topView = null;
            }
        }
    }
}