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
    [Register ("InviteCoworkerViewController")]
    partial class InviteCoworkerViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton addButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField email { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView emailcontainer { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel errormessagelabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel inviteTitle { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView maincontainer { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField name { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView namecontainer { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton submitButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView titleContainer { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (addButton != null) {
                addButton.Dispose ();
                addButton = null;
            }

            if (email != null) {
                email.Dispose ();
                email = null;
            }

            if (emailcontainer != null) {
                emailcontainer.Dispose ();
                emailcontainer = null;
            }

            if (errormessagelabel != null) {
                errormessagelabel.Dispose ();
                errormessagelabel = null;
            }

            if (inviteTitle != null) {
                inviteTitle.Dispose ();
                inviteTitle = null;
            }

            if (maincontainer != null) {
                maincontainer.Dispose ();
                maincontainer = null;
            }

            if (name != null) {
                name.Dispose ();
                name = null;
            }

            if (namecontainer != null) {
                namecontainer.Dispose ();
                namecontainer = null;
            }

            if (submitButton != null) {
                submitButton.Dispose ();
                submitButton = null;
            }

            if (titleContainer != null) {
                titleContainer.Dispose ();
                titleContainer = null;
            }
        }
    }
}