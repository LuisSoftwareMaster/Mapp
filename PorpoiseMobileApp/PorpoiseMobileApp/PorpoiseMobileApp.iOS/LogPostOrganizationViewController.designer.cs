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
    [Register ("LogPostOrganizationViewController")]
    partial class LogPostOrganizationViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel contributionLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel dateLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        PorpoiseMobileApp.iOS.PorpoiseEditText DateSelection { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView firstLine { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        PorpoiseMobileApp.iOS.PorpoiseDescriptionTextView highlight { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.NSLayoutConstraint leftConstraint { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel metricLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel OrganisationLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        PorpoiseMobileApp.iOS.PorpoiseEditText OrganisationSelection { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView Overlay { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView secondLine { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel shareLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        PorpoiseMobileApp.iOS.PorpoiseLabel surveyLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel tellusaboutLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView thirdLine { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView topHeader { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField unit { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView UploadedImage { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIActivityIndicatorView waiting { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (contributionLabel != null) {
                contributionLabel.Dispose ();
                contributionLabel = null;
            }

            if (dateLabel != null) {
                dateLabel.Dispose ();
                dateLabel = null;
            }

            if (DateSelection != null) {
                DateSelection.Dispose ();
                DateSelection = null;
            }

            if (firstLine != null) {
                firstLine.Dispose ();
                firstLine = null;
            }

            if (highlight != null) {
                highlight.Dispose ();
                highlight = null;
            }

            if (leftConstraint != null) {
                leftConstraint.Dispose ();
                leftConstraint = null;
            }

            if (metricLabel != null) {
                metricLabel.Dispose ();
                metricLabel = null;
            }

            if (OrganisationLabel != null) {
                OrganisationLabel.Dispose ();
                OrganisationLabel = null;
            }

            if (OrganisationSelection != null) {
                OrganisationSelection.Dispose ();
                OrganisationSelection = null;
            }

            if (Overlay != null) {
                Overlay.Dispose ();
                Overlay = null;
            }

            if (secondLine != null) {
                secondLine.Dispose ();
                secondLine = null;
            }

            if (shareLabel != null) {
                shareLabel.Dispose ();
                shareLabel = null;
            }

            if (surveyLabel != null) {
                surveyLabel.Dispose ();
                surveyLabel = null;
            }

            if (tellusaboutLabel != null) {
                tellusaboutLabel.Dispose ();
                tellusaboutLabel = null;
            }

            if (thirdLine != null) {
                thirdLine.Dispose ();
                thirdLine = null;
            }

            if (topHeader != null) {
                topHeader.Dispose ();
                topHeader = null;
            }

            if (unit != null) {
                unit.Dispose ();
                unit = null;
            }

            if (UploadedImage != null) {
                UploadedImage.Dispose ();
                UploadedImage = null;
            }

            if (waiting != null) {
                waiting.Dispose ();
                waiting = null;
            }
        }
    }
}