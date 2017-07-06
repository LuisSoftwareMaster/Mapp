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
    [Register ("ReportOtherReasonViewController")]
    partial class ReportOtherReasonViewController
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
        UIKit.UILabel errorLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView reason { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton submit { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView submitView { get; set; }

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

            if (errorLabel != null) {
                errorLabel.Dispose ();
                errorLabel = null;
            }

            if (reason != null) {
                reason.Dispose ();
                reason = null;
            }

            if (submit != null) {
                submit.Dispose ();
                submit = null;
            }

            if (submitView != null) {
                submitView.Dispose ();
                submitView = null;
            }

            if (topView != null) {
                topView.Dispose ();
                topView = null;
            }
        }
    }
}