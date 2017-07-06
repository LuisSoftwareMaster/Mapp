using PorpoiseMobileApp.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace PorpoiseMobileApp.iOS.Services
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
