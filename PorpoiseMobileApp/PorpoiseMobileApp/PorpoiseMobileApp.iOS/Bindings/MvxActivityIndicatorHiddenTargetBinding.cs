using MvvmCross.Binding;
using MvvmCross.Binding.Bindings.Target;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using UIKit;
using MvvmCross.Platform.Platform;

namespace PorpoiseMobileApp.iOS.Bindings
{
   public class MvxActivityIndicatorHiddenTargetBinding : MvxPropertyInfoTargetBinding<UIActivityIndicatorView>
    {
        public MvxActivityIndicatorHiddenTargetBinding(object target, PropertyInfo targetPropertyInfo) : base(target, targetPropertyInfo)
        {
			if (target == null)
			{
				MvxBindingTrace.Trace(
					MvxTraceLevel.Error,
					"Error - UIActivityIndicatorView is null in ActivityIndicatorViewHiddenTargetBinding");
			}
        }

		public override System.Type TargetType
		{
			get { 
				return typeof(bool); 
			}
		}

        public override MvxBindingMode DefaultMode
        {
            get
            {
                return MvxBindingMode.OneWay;
            }
        }

        protected override void SetValueImpl(object target, object value)
        {
//			var hidden = ((bool)value);
//			base.SetValueImpl (target, hidden);
//			if (hidden) {
//				View.StopAnimating ();
//			} else {
//				View.StartAnimating ();
//			}
			var view = (UIActivityIndicatorView)target;
			if (view == null)
			{
				return;
			}

			view.Hidden = !((bool)value);

			if (view.Hidden)
			{
				view.StopAnimating();
			}
			else
			{
				view.StartAnimating();
			}


        }


    }
}
