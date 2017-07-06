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
    [Register ("LoginTutorialFirst")]
    partial class LoginTutorialFirst
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView backgroundImage { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton nextButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel skipLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (backgroundImage != null) {
                backgroundImage.Dispose ();
                backgroundImage = null;
            }

            if (nextButton != null) {
                nextButton.Dispose ();
                nextButton = null;
            }

            if (skipLabel != null) {
                skipLabel.Dispose ();
                skipLabel = null;
            }
        }
    }
}