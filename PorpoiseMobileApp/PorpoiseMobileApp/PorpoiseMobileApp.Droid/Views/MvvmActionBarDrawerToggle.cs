using Android.Support.V4.Widget;

namespace PorpoiseMobileApp.Droid.Views
{
    internal class MvvmActionBarDrawerToggle
    {
        private DrawerLayout drawer;
        private int drawer_close;
        private int drawer_open;
        private HomeView homeView;

        public MvvmActionBarDrawerToggle(HomeView homeView, DrawerLayout drawer, int drawer_open, int drawer_close)
        {
            this.homeView = homeView;
            this.drawer = drawer;
            this.drawer_open = drawer_open;
            this.drawer_close = drawer_close;
        }
    }
}