//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//using Android.App;
//using Android.Content;
//using Android.OS;
//using Android.Runtime;
//using Android.Views;
//using Android.Widget;

//namespace PorpoiseMobileApp.Droid.Helpers
//{
//    public class ActionBarDrawerEventArgs : EventArgs
//    {
//        public View DrawerView { get; set; }
//        public float SlideOffset { get; set; }
//        public int NewState { get; set; }
//    }

//    public delegate void ActionBarDrawerChangedEventHandler(object s, ActionBarDrawerEventArgs e);

//    public class MvvmActionBarDrawerToggle 
//    {
//        public MvvmActionBarDrawerToggle(Activity activity, Android.Support.V4.Widget.DrawerLayout drawerLayout, Android.Support.V7.Widget.Toolbar toolbar, int openDrawerContentDescRes, int closeDrawerContentDescRes)
//            : base(activity, drawerLayout, toolbar, openDrawerContentDescRes, closeDrawerContentDescRes)
//        {

//        }

//        public MvvmActionBarDrawerToggle(Activity activity, Android.Support.V4.Widget.DrawerLayout drawerLayout, int openDrawerContentDescRes, int closeDrawerContentDescRes)
//            : base(activity, drawerLayout, openDrawerContentDescRes, closeDrawerContentDescRes)
//        {

//        }

//        public event ActionBarDrawerChangedEventHandler DrawerClosed;
//        public event ActionBarDrawerChangedEventHandler DrawerOpened;
//        public event ActionBarDrawerChangedEventHandler DrawerSlide;
//        public event ActionBarDrawerChangedEventHandler DrawerStateChanged;

//        private Dictionary<View, bool> drawerState = new Dictionary<View, bool>();

//        public override void OnDrawerClosed(View drawerView)
//        {
//            drawerState[drawerView] = false;
//            if (null != this.DrawerClosed)
//                this.DrawerClosed(this, new ActionBarDrawerEventArgs { DrawerView = drawerView });
//            base.OnDrawerClosed(drawerView);
//        }

//        public override void OnDrawerOpened(View drawerView)
//        {
//            drawerState[drawerView] = true;
//            if (null != this.DrawerOpened)
//                this.DrawerOpened(this, new ActionBarDrawerEventArgs { DrawerView = drawerView });
//            base.OnDrawerOpened(drawerView);
//        }

//        public override void OnDrawerSlide(View drawerView, float slideOffset)
//        {
//            if (null != this.DrawerSlide)
//                this.DrawerSlide(this, new ActionBarDrawerEventArgs
//                {
//                    DrawerView = drawerView,
//                    SlideOffset = slideOffset
//                });
//            base.OnDrawerSlide(drawerView, slideOffset);
//        }

//        public override void OnDrawerStateChanged(int newState)
//        {
//            if (null != this.DrawerStateChanged)
//                this.DrawerStateChanged(this, new ActionBarDrawerEventArgs
//                {
//                    NewState = newState
//                });
//            base.OnDrawerStateChanged(newState);
//        }

//        public bool IsDrawerOpen(View drawer)
//        {
//            return drawerState.ContainsKey(drawer) ? drawerState[drawer] : false;
//        }
//    }
//}