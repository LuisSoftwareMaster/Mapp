using MvvmCross.Platform;
using MvvmCross.Platform.Plugins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmCross.Plugins.Permissions
{
    public class PluginLoader
       : IMvxPluginLoader
    {
        public static readonly PluginLoader Instance = new PluginLoader();

        private bool _loaded;

        public void EnsureLoaded()
        {
            if (_loaded)
            {
                return;
            }

            Mvx.RegisterSingleton<IMvxPermissions>(new MvxPermissions());
            _loaded = true;
        }
    }
}
