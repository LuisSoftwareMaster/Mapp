using System;
using MvvmCross.Binding.Bindings.Target;
using UIKit;

namespace PorpoiseMobileApp.iOS
{
	public class MvxLayoutTargetBinding : MvxConvertingTargetBinding,IMvxEditableTextView
	{
		public override Type TargetType
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		protected override void SetValueImpl(object target, object value)
		{
			throw new NotImplementedException();
		}
	}
}
