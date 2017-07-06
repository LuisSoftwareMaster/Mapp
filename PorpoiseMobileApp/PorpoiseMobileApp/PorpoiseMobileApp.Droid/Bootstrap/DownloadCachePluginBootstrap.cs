
using MvvmCross.Platform.Plugins;

namespace PorpoiseMobileApp.Droid.Bootstrap
{
    public class DownloadCachePluginBootstrap
        : MvxPluginBootstrapAction<global::MvvmCross.Plugins.DownloadCache.PluginLoader>
    {
        protected override void Load(IMvxPluginManager manager)
        {
            global::MvvmCross.Plugins.File.PluginLoader.Instance.EnsureLoaded();
            base.Load(manager);
        }
    }
}