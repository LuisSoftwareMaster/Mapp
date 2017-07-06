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
using MvvmCross.Droid.Views;
using MvvmCross.Core.ViewModels;
using PorpoiseMobileApp.Droid.Helpers;

namespace PorpoiseMobileApp.Droid.MvvmCross
{
    class PorpoiseViewsContainer : MvxAndroidViewsContainer
    {
        private Context _applicationContext;
        public PorpoiseViewsContainer(Context applicationContext) : base(applicationContext)
        {
        }

        protected override void AdjustIntentForPresentation(Intent intent, MvxViewModelRequest request)
        {
            base.AdjustIntentForPresentation(intent, request);
            var viewType = GetViewType(request.ViewModelType);
            var hints = viewType.GetCustomAttributes(typeof(PresentationHintAttribute), true).Cast<PresentationHintAttribute>();
            foreach (var hint in hints)
            {
                if (hint.ClearTop)
                {
                    intent.AddFlags(ActivityFlags.ClearTop);
                    intent.AddFlags(ActivityFlags.NewTask);
                }
            }
        }
    }
}