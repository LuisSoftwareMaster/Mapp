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

namespace PorpoiseMobileApp.Droid
{
    static class Extensions
    {

        public enum AlertType
        {
            Error, Confirm, Message
        }
        public static void Alert(this Context activity, string title, string message, Action<DialogButtonType> handler = null, int? themeResId = null)
        {
            if (themeResId.HasValue)
            {
                activity.Alert(AlertType.Message, title, message, handler, themeResId.Value);
            }
            else
            {
                activity.Alert(AlertType.Message, title, message, handler);
            }
                
        }

        public static void Alert(this Android.Support.V4.App.Fragment fragment, string title, string message, Action<DialogButtonType> handler = null, int? themeResId = null)
        {

            if (themeResId.HasValue)
            {
                fragment.Activity.Alert(AlertType.Message, title, message, handler, themeResId.Value);
            }
            else
            { fragment.Activity.Alert(AlertType.Message, title, message, handler);

            }
               
        }

        public static void Alert(this Android.Support.V4.App.Fragment fragment, AlertType type, string title, string message, Action<DialogButtonType> handler = null, int? themeResId = null)
        {

            if (themeResId.HasValue)
            {
                fragment.Activity.Alert(type, title, message, handler, themeResId.Value);
            }
            else
            {
                fragment.Activity.Alert(type, title, message, handler);

            }
            
        }

        public static void Alert(this Context activity, AlertType type, string title, string message, Action<DialogButtonType> handler = null, int? themeResId = null)
        {
            try
            {
                AlertDialog.Builder dialog;
                if (themeResId.HasValue)
                {
                    dialog = new AlertDialog.Builder(activity, themeResId.Value);
                }
                else
                {
                    dialog = new AlertDialog.Builder(activity);
                }
          

                dialog = dialog
                    .SetTitle(title)
                    .SetMessage(message);

               

                switch (type)
                {
                    case AlertType.Confirm:
                        dialog = dialog.SetPositiveButton(Resource.String.ok, (s, e) => { if (handler != null) handler((DialogButtonType)e.Which); });
                        dialog = dialog.SetNegativeButton(Resource.String.cancel, (s, e) => { if (handler != null) handler((DialogButtonType)e.Which); });
                        break;
                    case AlertType.Message:
                        dialog = dialog.SetPositiveButton(Resource.String.ok, (s, e) => { if (handler != null) handler((DialogButtonType)e.Which); });
                        break;
                    case AlertType.Error:
                        dialog.SetIcon(Resource.Drawable.ic_error_black_24dp); // can set an icon indicating error
                        dialog = dialog.SetPositiveButton(Resource.String.ok, (s, e) => { if (handler != null) handler((DialogButtonType)e.Which); });
                        break;
                }


                dialog.Show();
            }
            catch (Exception e) { }
        }
    }
}