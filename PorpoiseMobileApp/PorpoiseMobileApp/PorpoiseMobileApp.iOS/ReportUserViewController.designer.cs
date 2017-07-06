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
    [Register ("ReportUserViewController")]
    partial class ReportUserViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton cancel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView cancelView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView contentView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton innapropriate { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton other { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        PorpoiseMobileApp.iOS.PorpoiseView topView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (cancel != null) {
                cancel.Dispose ();
                cancel = null;
            }

            if (cancelView != null) {
                cancelView.Dispose ();
                cancelView = null;
            }

            if (contentView != null) {
                contentView.Dispose ();
                contentView = null;
            }

            if (innapropriate != null) {
                innapropriate.Dispose ();
                innapropriate = null;
            }

            if (other != null) {
                other.Dispose ();
                other = null;
            }

            if (topView != null) {
                topView.Dispose ();
                topView = null;
            }
        }
    }
}