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
    [Register ("PasswordConfirmationViewController")]
    partial class PasswordConfirmationViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView help { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView logo { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton nextButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        PorpoiseMobileApp.iOS.PorpoiseEditText password { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        PorpoiseMobileApp.iOS.PorpoiseEditText passwordConfirmation { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (help != null) {
                help.Dispose ();
                help = null;
            }

            if (logo != null) {
                logo.Dispose ();
                logo = null;
            }

            if (nextButton != null) {
                nextButton.Dispose ();
                nextButton = null;
            }

            if (password != null) {
                password.Dispose ();
                password = null;
            }

            if (passwordConfirmation != null) {
                passwordConfirmation.Dispose ();
                passwordConfirmation = null;
            }
        }
    }
}