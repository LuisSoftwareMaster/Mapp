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
    [Register ("PostItemCellController")]
    partial class PostItemCellController
    {
        [Outlet]
        UIKit.UILabel Date { get; set; }



        [Outlet]
        UIKit.UIButton EditButton { get; set; }



        [Outlet]
        UIKit.UILabel EmployeeName { get; set; }



        /*[Outlet]
		UIKit.UILabel hidden_lblHours { get; set; }


		[Outlet]
		UIKit.UILabel hidden_lblOrg { get; set; }*/


        [Outlet]
        UIKit.UILabel postDetails
        {
            get; set;

        }




        [Outlet]
        UIKit.UIImageView UploadedImage { get; set; }


        [Outlet]

        UIKit.UIButton DeleteButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel companyNameLocation { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton dots { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView dotsView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView givenWelldone { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel givenWelldoneText { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.NSLayoutConstraint highlightLineConstraint { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel highligth { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView line { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView profileImage { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        PorpoiseMobileApp.iOS.WelldoneButton wellDoneButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView welldoneButtonContainer { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.NSLayoutConstraint wellDoneHeight { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.NSLayoutConstraint welldoneImageHeight { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (companyNameLocation != null) {
                companyNameLocation.Dispose ();
                companyNameLocation = null;
            }

            if (Date != null) {
                Date.Dispose ();
                Date = null;
            }

            if (dots != null) {
                dots.Dispose ();
                dots = null;
            }

            if (dotsView != null) {
                dotsView.Dispose ();
                dotsView = null;
            }

            if (EditButton != null) {
                EditButton.Dispose ();
                EditButton = null;
            }

            if (EmployeeName != null) {
                EmployeeName.Dispose ();
                EmployeeName = null;
            }

            if (givenWelldone != null) {
                givenWelldone.Dispose ();
                givenWelldone = null;
            }

            if (givenWelldoneText != null) {
                givenWelldoneText.Dispose ();
                givenWelldoneText = null;
            }

            if (highlightLineConstraint != null) {
                highlightLineConstraint.Dispose ();
                highlightLineConstraint = null;
            }

            if (highligth != null) {
                highligth.Dispose ();
                highligth = null;
            }

            if (line != null) {
                line.Dispose ();
                line = null;
            }

            if (postDetails != null) {
                postDetails.Dispose ();
                postDetails = null;
            }

            if (profileImage != null) {
                profileImage.Dispose ();
                profileImage = null;
            }

            if (UploadedImage != null) {
                UploadedImage.Dispose ();
                UploadedImage = null;
            }

            if (wellDoneButton != null) {
                wellDoneButton.Dispose ();
                wellDoneButton = null;
            }

            if (welldoneButtonContainer != null) {
                welldoneButtonContainer.Dispose ();
                welldoneButtonContainer = null;
            }

            if (wellDoneHeight != null) {
                wellDoneHeight.Dispose ();
                wellDoneHeight = null;
            }

            if (welldoneImageHeight != null) {
                welldoneImageHeight.Dispose ();
                welldoneImageHeight = null;
            }
        }
    }
}