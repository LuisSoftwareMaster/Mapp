using MvvmCross.Binding;
using MvvmCross.Binding.Bindings.Target;
using MvvmCross.Binding.ExtensionMethods;
using MvvmCross.Platform.Platform;
using System;
using System.Collections.Generic;
using System.Text;
using UIKit;

namespace PorpoiseMobileApp.iOS
{
    public class PorpoiseTextEditTargetBinding : MvxConvertingTargetBinding, IMvxEditableTextView
    {
        public PorpoiseTextEditTargetBinding(PorpoiseEditText target) : base(target) { }

		protected PorpoiseEditText View
        {
            get
            {
				return Target as PorpoiseEditText;
            }
        }

        bool _subscribed;

        public override void SubscribeToEvents()
        {
            var target = View;
            if (target == null)
            {
                MvxBindingTrace.Trace(MvxTraceLevel.Error,
                    "Error - PorpoiseTextField is null in PorpoiseTextFieldEditTargetBinding");
                return;
            }

            target.TextChanged += HandleTextChanged;
            target.EditingChanged += HandleTextChanged;
            _subscribed = true;
        }

        void HandleTextChanged(object sender, EventArgs e)
        {
            var view = View;
            if (view == null)
                return;
            FireValueChanged(view.Text);
        }

        public override MvxBindingMode DefaultMode
        {
            get
            {
                return MvxBindingMode.TwoWay;
            }
        }

        protected override void Dispose(bool isDisposing)
        {
            base.Dispose(isDisposing);

            if (isDisposing)
            {
                var editText = View;
                if (editText != null && _subscribed)
                {
                    editText.TextChanged -= HandleTextChanged;
                    editText.EditingChanged -= HandleTextChanged;
                    _subscribed = false;
                }
            }
        }

        #region implemented abstract members of MvxTargetBinding
        public override Type TargetType
        {
            get
            {
                return typeof(String);
            }
        }
        #endregion
        #region implemented abstract members of MvxConvertingTargetBinding
        protected override void SetValueImpl(object target, object value)
        {
            var view = (UITextField)target;
            if (view == null)
                return;

            view.Text = (string)value;
        }
        #endregion

        #region IMvxEditableTextView implementation

        public string CurrentText
        {
            get
            {
                var view = View;
                if (view == null)
                    return null;
                return view.Text;
            }
        }

        #endregion
    }
}
