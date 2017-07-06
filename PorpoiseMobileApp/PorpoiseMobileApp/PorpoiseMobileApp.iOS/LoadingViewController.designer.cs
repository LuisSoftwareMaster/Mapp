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
    [Register ("LoadingViewController")]
    partial class LoadingViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIActivityIndicatorView Waiting { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (Waiting != null) {
                Waiting.Dispose ();
                Waiting = null;
            }
        }
    }
}