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
    [Register ("InvitationConfirmationViewController")]
    partial class InvitationConfirmationViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton addcoworkerbutton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton backbutton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView line { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView logo { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (addcoworkerbutton != null) {
                addcoworkerbutton.Dispose ();
                addcoworkerbutton = null;
            }

            if (backbutton != null) {
                backbutton.Dispose ();
                backbutton = null;
            }

            if (line != null) {
                line.Dispose ();
                line = null;
            }

            if (logo != null) {
                logo.Dispose ();
                logo = null;
            }
        }
    }
}