using System;
using Foundation;
using UIKit;
using System.Drawing;

namespace PorpoiseMobileApp.iOS.Utils
{
	public static class KeyboardManager
	{
		static NSObject keyboardUpObserver;
		static NSObject keyboardDownObserver;

		public static void Init() {
			keyboardUpObserver = NSNotificationCenter.DefaultCenter.AddObserver (UIKeyboard.WillShowNotification, notification => {
				var dict = notification.UserInfo;
				var rectValue = dict.ValueForKey (UIKeyboard.FrameBeginUserInfoKey);
				var rect = ((NSValue)rectValue).RectangleFValue;
				var size = rect.Size;
				if (_keyboardUp != null) {
					_keyboardUp(size);
				}
			});
			keyboardDownObserver = NSNotificationCenter.DefaultCenter.AddObserver (UIKeyboard.WillHideNotification, notification => {
				if (KeyboardDown != null) {
					KeyboardDown();
				}
			});
		}

		public static void Shutdown() {
			var center = NSNotificationCenter.DefaultCenter;
			center.RemoveObserver (keyboardDownObserver);
			center.RemoveObserver (keyboardUpObserver);
		}

		private static event KeyboardUpDelegate _keyboardUp;

		public static event KeyboardUpDelegate KeyboardUp {
			add {
				_keyboardUp += value;
			}
			remove {
				_keyboardUp -= value;
			}
		}
		public static event KeyboardDownDelegate KeyboardDown;
	}

	public delegate void KeyboardUpDelegate(SizeF size);
	public delegate void KeyboardDownDelegate();
}

