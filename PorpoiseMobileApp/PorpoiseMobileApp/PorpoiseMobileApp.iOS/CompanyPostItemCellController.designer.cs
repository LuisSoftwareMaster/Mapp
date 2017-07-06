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
    [Register ("CompanyPostItemCellController")]
    partial class CompanyPostItemCellController
    {
        [Outlet]
        UIKit.UILabel CompanyName { get; set; }


        [Outlet]
        UIKit.UIImageView PlayButton { get; set; }


        [Outlet]
        UIKit.UILabel PostDetails { get; set; }


        [Outlet]
        UIKit.UIImageView PostImage { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView companyImage { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton dots { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (companyImage != null) {
                companyImage.Dispose ();
                companyImage = null;
            }

            if (CompanyName != null) {
                CompanyName.Dispose ();
                CompanyName = null;
            }

            if (dots != null) {
                dots.Dispose ();
                dots = null;
            }

            if (PlayButton != null) {
                PlayButton.Dispose ();
                PlayButton = null;
            }

            if (PostDetails != null) {
                PostDetails.Dispose ();
                PostDetails = null;
            }

            if (PostImage != null) {
                PostImage.Dispose ();
                PostImage = null;
            }
        }
    }
}