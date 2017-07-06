using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PorpoiseMobileApp.Startup
{
    public interface IAppDomain
    {
        IList<IAssembly> GetAssemblies();
    }

    public interface IAssembly
    {
        string GetName();
        List<TypeInfo> DeclaredTypes { get; }
    }

    public class AppDomainWrapper
    {
        public static IAppDomain Instance { get; set; }
    }
}
