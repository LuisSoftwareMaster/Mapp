// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace PorpoiseMobileApp.iOS
{
    [Register ("OrganizationSearchItem")]
    partial class OrganizationSearchItem
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView check { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        PorpoiseMobileApp.iOS.PorpoiseLabel title { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (check != null) {
                check.Dispose ();
                check = null;
            }

            if (title != null) {
                title.Dispose ();
                title = null;
            }
        }
    }
}