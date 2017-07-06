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
    [Register ("RequestAccountViewController")]
    partial class RequestAccountViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton back { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton checkbox { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        PorpoiseMobileApp.iOS.PorpoiseEditText company { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView contentView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        PorpoiseMobileApp.iOS.PorpoiseEditText email { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        PorpoiseMobileApp.iOS.PorpoiseEditText firstname { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        PorpoiseMobileApp.iOS.PorpoiseEditText lastname { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView mail { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton submit { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView terms { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView topImage { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (back != null) {
                back.Dispose ();
                back = null;
            }

            if (checkbox != null) {
                checkbox.Dispose ();
                checkbox = null;
            }

            if (company != null) {
                company.Dispose ();
                company = null;
            }

            if (contentView != null) {
                contentView.Dispose ();
                contentView = null;
            }

            if (email != null) {
                email.Dispose ();
                email = null;
            }

            if (firstname != null) {
                firstname.Dispose ();
                firstname = null;
            }

            if (lastname != null) {
                lastname.Dispose ();
                lastname = null;
            }

            if (mail != null) {
                mail.Dispose ();
                mail = null;
            }

            if (submit != null) {
                submit.Dispose ();
                submit = null;
            }

            if (terms != null) {
                terms.Dispose ();
                terms = null;
            }

            if (topImage != null) {
                topImage.Dispose ();
                topImage = null;
            }
        }
    }
}