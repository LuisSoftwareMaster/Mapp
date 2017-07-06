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
using PorpoiseMobileApp.Services;

namespace PorpoiseMobileApp.Droid.Services
{
    class ConsoleLogger : IConsoleLogger
    {
        public void WriteLine()
        {
            Console.WriteLine();
        }

        public void WriteLine(string what)
        {
            Console.WriteLine(what);
        }

        public void WriteLine(string format, params object[] parameters)
        {
            Console.WriteLine(format, parameters);
        }
    }
}