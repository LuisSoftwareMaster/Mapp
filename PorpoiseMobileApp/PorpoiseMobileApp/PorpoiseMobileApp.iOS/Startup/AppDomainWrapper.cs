using PorpoiseMobileApp.Startup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace PorpoiseMobileApp.iOS.Startup
{
    public class AppDomainWrapper : IAppDomain
    {
        IList<IAssembly> IAppDomain.GetAssemblies()
        {
            var result = new List<IAssembly>();
            foreach (var assembly in System.AppDomain.CurrentDomain.GetAssemblies())
            {
                result.Add(new AssemblyWrapper(assembly));
            }
            return result;
        }
    }

    public class AssemblyWrapper : IAssembly
    {
        private Assembly m_Assembly;
        public AssemblyWrapper(Assembly assembly)
        {
            m_Assembly = assembly;
        }

        public string GetName()
        {
            return m_Assembly.GetName().ToString();
        }


        public List<TypeInfo> DeclaredTypes
        {
            get { return m_Assembly.DefinedTypes.ToList(); }
        }
    }
}
