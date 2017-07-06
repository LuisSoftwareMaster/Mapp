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
using MvvmCross.Binding.Bindings.Target;
using System.Reflection;
using MvvmCross.Binding;

namespace PorpoiseMobileApp.Droid.Bindings
{
    public class ProgressBarVisibilityTargetBinding : MvxPropertyInfoTargetBinding<ProgressBar>
    {
        public ProgressBarVisibilityTargetBinding(object target, PropertyInfo targetPropertyInfo)
            : base(target, targetPropertyInfo)
        {
            var view = View;
        }

        public override MvxBindingMode DefaultMode
        {
            get { return MvxBindingMode.OneWay; }
        }

        protected override void SetValueImpl(object target, object value)
        {
            if (!(value is ViewStates))
            {
                var hidden = (bool)value;
                value = hidden ? ViewStates.Visible : ViewStates.Invisible;
            }

            base.SetValueImpl(target, value);
        }

        protected override object MakeSafeValue(object value)
        {
            // value is hidden
            return ((bool)value) ? ViewStates.Visible : ViewStates.Invisible;
        }

        public override void SetValue(object value)
        {
            base.SetValue(value);
        }

        public override void SubscribeToEvents()
        {
            base.SubscribeToEvents();
        }

        public override Type TargetType
        {
            get
            {
                return base.TargetType;
            }
        }
    }
}