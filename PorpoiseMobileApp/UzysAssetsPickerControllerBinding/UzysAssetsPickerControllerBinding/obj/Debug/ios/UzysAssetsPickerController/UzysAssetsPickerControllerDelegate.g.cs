//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using UIKit;
using GLKit;
using Metal;
using MapKit;
using ModelIO;
using SceneKit;
using Security;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using CoreAnimation;
using CoreFoundation;

namespace UzysAssetsPickerController {
	[Register("UzysAssetsPickerControllerDelegate", false)]
	[Model]
	public unsafe abstract partial class UzysAssetsPickerControllerDelegate : NSObject {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected UzysAssetsPickerControllerDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected UzysAssetsPickerControllerDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal UzysAssetsPickerControllerDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("uzysAssetsPickerController:didFinishPickingAssets:")]
		[CompilerGenerated]
		public abstract void UzysAssetsPickerController (UzysAssetsPickerController picker, NSObject[] assets);
		[Export ("uzysAssetsPickerControllerDidCancel:")]
		[CompilerGenerated]
		public virtual void UzysAssetsPickerControllerDidCancel (UzysAssetsPickerController picker)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("uzysAssetsPickerControllerDidExceedMaximumNumberOfSelection:")]
		[CompilerGenerated]
		public virtual void UzysAssetsPickerControllerDidExceedMaximumNumberOfSelection (UzysAssetsPickerController picker)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class UzysAssetsPickerControllerDelegate */
}
