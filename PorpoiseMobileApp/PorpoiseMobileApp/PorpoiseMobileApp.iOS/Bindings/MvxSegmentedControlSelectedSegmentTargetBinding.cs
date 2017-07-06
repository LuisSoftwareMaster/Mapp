using MvvmCross.Binding;
using MvvmCross.Binding.Bindings.Target;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using UIKit;

namespace PorpoiseMobileApp.iOS.Bindings
{
    class MvxSegmentedControlSelectedSegmentTargetBinding : MvxPropertyInfoTargetBinding<UISegmentedControl>
    {
        public MvxSegmentedControlSelectedSegmentTargetBinding(object target, PropertyInfo targetPropertyInfo)
            : base(target, targetPropertyInfo)
        {
            var view = View;
            view.ValueChanged += HandleValueChanged;
        }

        private void HandleValueChanged(object sender, System.EventArgs e)
        {
            var view = View;
            if (view == null)
                return;
            FireValueChanged(view.SelectedSegment);
        }

        public override MvxBindingMode DefaultMode
        {
            get { return MvxBindingMode.TwoWay; }
        }

        protected override void Dispose(bool isDisposing)
        {
            base.Dispose(isDisposing);
            if (isDisposing)
            {
                var view = View;
                if (view != null)
                {
                    view.ValueChanged -= HandleValueChanged;
                }
            }
        }

        protected override void SetValueImpl(object target, object value)
        {
            if (value != null)
            {
                base.SetValueImpl(target, value);
            }
        }

        protected override object MakeSafeValue(object value)
        {
            return value != null ? base.MakeSafeValue(value) : base.MakeSafeValue(value);

        }

        public override void SetValue(object value)
        {
            if (value != null)
            {
                base.SetValue(value);
            }
        }
    }
}
