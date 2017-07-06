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
    [Register ("ChallengeLogHourViewController")]
    partial class ChallengeLogHourViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView challengers { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView headerBrackgroud { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView headerContainer { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel headerLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISearchBar searchBar { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (challengers != null) {
                challengers.Dispose ();
                challengers = null;
            }

            if (headerBrackgroud != null) {
                headerBrackgroud.Dispose ();
                headerBrackgroud = null;
            }

            if (headerContainer != null) {
                headerContainer.Dispose ();
                headerContainer = null;
            }

            if (headerLabel != null) {
                headerLabel.Dispose ();
                headerLabel = null;
            }

            if (searchBar != null) {
                searchBar.Dispose ();
                searchBar = null;
            }
        }
    }
}