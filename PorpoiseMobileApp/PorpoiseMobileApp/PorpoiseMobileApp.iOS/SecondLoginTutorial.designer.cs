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
    [Register ("SecondLoginTutorial")]
    partial class SecondLoginTutorial
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView backgroundImage { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton confirmationButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView container { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (backgroundImage != null) {
                backgroundImage.Dispose ();
                backgroundImage = null;
            }

            if (confirmationButton != null) {
                confirmationButton.Dispose ();
                confirmationButton = null;
            }

            if (container != null) {
                container.Dispose ();
                container = null;
            }
        }
    }
}