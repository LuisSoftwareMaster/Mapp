using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PorpoiseMobileApp.Startup
{
    public interface IIoCProvider
    {
        T Resolve<T>(string named = null);
        IEnumerable<T> ResolveAll<T>();
        IEnumerable<Type> ResolveImplementors<T>();
    }
}
