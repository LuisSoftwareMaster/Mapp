using System;
using PorpoiseMobileApp.Droid.Helpers;
using PorpoiseMobileApp.ViewModels;
namespace PorpoiseMobileApp.Droid.Views
{
    [MenuItem(MenuItem.FirstViewFragment)]
    public class FirstView : MvvmFragment<FirstViewModel>
    {
        public FirstView() : base(Resource.Layout.FirstView)
        {
        }
    }
}
