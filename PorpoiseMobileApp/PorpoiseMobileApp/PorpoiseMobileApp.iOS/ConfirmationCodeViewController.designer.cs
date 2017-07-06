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
    [Register ("ConfirmationCodeViewController")]
    partial class ConfirmationCodeViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton back { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        PorpoiseMobileApp.iOS.PorpoiseEditText confirmationCode { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView contentForm { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton continueButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel errorLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView help { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView logo { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        PorpoiseMobileApp.iOS.PorpoiseLabel message { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (back != null) {
                back.Dispose ();
                back = null;
            }

            if (confirmationCode != null) {
                confirmationCode.Dispose ();
                confirmationCode = null;
            }

            if (contentForm != null) {
                contentForm.Dispose ();
                contentForm = null;
            }

            if (continueButton != null) {
                continueButton.Dispose ();
                continueButton = null;
            }

            if (errorLabel != null) {
                errorLabel.Dispose ();
                errorLabel = null;
            }

            if (help != null) {
                help.Dispose ();
                help = null;
            }

            if (logo != null) {
                logo.Dispose ();
                logo = null;
            }

            if (message != null) {
                message.Dispose ();
                message = null;
            }
        }
    }
}