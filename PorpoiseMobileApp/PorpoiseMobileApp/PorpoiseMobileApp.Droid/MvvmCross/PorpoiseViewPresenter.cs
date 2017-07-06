using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Views;
using PorpoiseMobileApp.Droid.Views;


namespace PorpoiseMobileApp.Droid.MvvmCross
{
    public interface IFragmentHost
    {
        bool Show(MvxViewModelRequest request);
        void ShowKeyboard(View target, KeyboardAdjustment adjust = KeyboardAdjustment.Pan);
    }
    public enum KeyboardAdjustment
    {
        None,
        Pan,
        Resize
    }

    public interface ICustomPresenter
    {
        void Register(Type viewModelType, IFragmentHost host);
    }
    public class PorpoiseViewPresenter : MvxAndroidViewPresenter, ICustomPresenter
    {
        private Dictionary<Type, IFragmentHost> _dictionary = new Dictionary<Type, IFragmentHost>();

        public override void Show(MvxViewModelRequest request)
        {
            IFragmentHost host;
            if (_dictionary.TryGetValue(request.ViewModelType, out host))
            {
                if (host.Show(request))
                {
                    return;
                }
            }

            base.Show(request);
        }

        public void Register(Type viewModelType, IFragmentHost host)
        {
            _dictionary[viewModelType] = host;
        }
    }
}