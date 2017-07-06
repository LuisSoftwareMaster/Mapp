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
    [Register ("AddCoworkerViewController")]
    partial class AddCoworkerViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView buttonsContainer { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton firstButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton secondButton { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (buttonsContainer != null) {
                buttonsContainer.Dispose ();
                buttonsContainer = null;
            }

            if (firstButton != null) {
                firstButton.Dispose ();
                firstButton = null;
            }

            if (secondButton != null) {
                secondButton.Dispose ();
                secondButton = null;
            }
        }
    }
}