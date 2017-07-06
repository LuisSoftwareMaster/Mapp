using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PorpoiseMobileApp.Services
{
    public interface IConsoleLogger
    {
        void WriteLine();
        void WriteLine(string what);
        void WriteLine(string format, params object[] parameters);
    }
}
