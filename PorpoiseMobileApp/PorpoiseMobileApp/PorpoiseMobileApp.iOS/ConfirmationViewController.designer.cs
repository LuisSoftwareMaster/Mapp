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
    [Register ("ConfirmationViewController")]
    partial class ConfirmationViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton back { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView contentView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView topImage { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (back != null) {
                back.Dispose ();
                back = null;
            }

            if (contentView != null) {
                contentView.Dispose ();
                contentView = null;
            }

            if (topImage != null) {
                topImage.Dispose ();
                topImage = null;
            }
        }
    }
}