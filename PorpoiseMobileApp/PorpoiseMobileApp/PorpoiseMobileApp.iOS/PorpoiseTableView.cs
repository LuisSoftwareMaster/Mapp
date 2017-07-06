using Foundation;
using System;
using UIKit;

namespace PorpoiseMobileApp.iOS
{
    public partial class PorpoiseTableView : UITableView
    {

        public bool change = false;

        public System.Collections.Generic.List<Models.HourLog> posts;

        public ActivityViewController controller;

        public PorpoiseTableView (IntPtr handle) : base (handle)
        {
        }
      

    

       
    }
}