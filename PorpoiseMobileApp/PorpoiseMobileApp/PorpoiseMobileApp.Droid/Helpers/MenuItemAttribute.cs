using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using PorpoiseMobileApp;

namespace PorpoiseMobileApp.Droid.Helpers
{
    public class MenuItemAttribute : Attribute
    {
        public MenuItemAttribute(MenuItem menuItem)
        {
            this.MenuItem = menuItem;
        }

        public MenuItem MenuItem { get; private set; }
    }
}