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
	[Register("UzysAssetsPickerController", true)]
	public unsafe partial class UzysAssetsPickerController : global::UIKit.UIViewController {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("UzysAssetsPickerController");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UzysAssetsPickerController () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public UzysAssetsPickerController (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;

			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected UzysAssetsPickerController (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal UzysAssetsPickerController (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("setUpAppearanceConfig:")]
		[CompilerGenerated]
		public static void SetUpAppearanceConfig (UzysAppearanceConfig config)
		{
			if (config == null)
				throw new ArgumentNullException ("config");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("setUpAppearanceConfig:"), config.Handle);
		}
		
		[CompilerGenerated]
		public virtual global::AssetsLibrary.ALAssetsFilter AssetsFilter {
			[Export ("assetsFilter", ArgumentSemantic.Retain)]
			get {
				global::AssetsLibrary.ALAssetsFilter ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::AssetsLibrary.ALAssetsFilter> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("assetsFilter")));
				} else {
					ret =  Runtime.GetNSObject<global::AssetsLibrary.ALAssetsFilter> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("assetsFilter")));
				}
				return ret;
			}
			
			[Export ("setAssetsFilter:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAssetsFilter:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setAssetsFilter:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_BtnDone_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIButton BtnDone {
			[Export ("btnDone", ArgumentSemantic.Weak)]
			get {
				global::UIKit.UIButton ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIButton> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("btnDone")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIButton> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("btnDone")));
				}
				MarkDirty ();
				__mt_BtnDone_var = ret;
				return ret;
			}
			
			[Export ("setBtnDone:", ArgumentSemantic.Weak)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setBtnDone:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setBtnDone:"), value.Handle);
				}
				MarkDirty ();
				__mt_BtnDone_var = value;
			}
		}
		
		[CompilerGenerated]
		public static global::AssetsLibrary.ALAssetsLibrary DefaultAssetsLibrary {
			[Export ("defaultAssetsLibrary")]
			get {
				global::AssetsLibrary.ALAssetsLibrary ret;
				ret =  Runtime.GetNSObject<global::AssetsLibrary.ALAssetsLibrary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("defaultAssetsLibrary")));
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public UzysAssetsPickerControllerDelegate Delegate {
			get {
				return WeakDelegate as UzysAssetsPickerControllerDelegate;
			}
			set {
				WeakDelegate = value;
			}
		}
		
		[CompilerGenerated]
		public virtual UzysGroupPickerView GroupPicker {
			[Export ("groupPicker", ArgumentSemantic.Retain)]
			get {
				UzysGroupPickerView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UzysGroupPickerView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("groupPicker")));
				} else {
					ret =  Runtime.GetNSObject<UzysGroupPickerView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("groupPicker")));
				}
				return ret;
			}
			
			[Export ("setGroupPicker:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setGroupPicker:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setGroupPicker:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::CoreLocation.CLLocation Location {
			[Export ("location", ArgumentSemantic.Retain)]
			get {
				global::CoreLocation.CLLocation ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::CoreLocation.CLLocation> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("location")));
				} else {
					ret =  Runtime.GetNSObject<global::CoreLocation.CLLocation> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("location")));
				}
				return ret;
			}
			
			[Export ("setLocation:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setLocation:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setLocation:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nint MaximumNumberOfSelectionMedia {
			[Export ("maximumNumberOfSelectionMedia")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nint_objc_msgSend (this.Handle, Selector.GetHandle ("maximumNumberOfSelectionMedia"));
				} else {
					return global::ApiDefinition.Messaging.nint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("maximumNumberOfSelectionMedia"));
				}
			}
			
			[Export ("setMaximumNumberOfSelectionMedia:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nint (this.Handle, Selector.GetHandle ("setMaximumNumberOfSelectionMedia:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nint (this.SuperHandle, Selector.GetHandle ("setMaximumNumberOfSelectionMedia:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nint MaximumNumberOfSelectionPhoto {
			[Export ("maximumNumberOfSelectionPhoto")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nint_objc_msgSend (this.Handle, Selector.GetHandle ("maximumNumberOfSelectionPhoto"));
				} else {
					return global::ApiDefinition.Messaging.nint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("maximumNumberOfSelectionPhoto"));
				}
			}
			
			[Export ("setMaximumNumberOfSelectionPhoto:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nint (this.Handle, Selector.GetHandle ("setMaximumNumberOfSelectionPhoto:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nint (this.SuperHandle, Selector.GetHandle ("setMaximumNumberOfSelectionPhoto:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nint MaximumNumberOfSelectionVideo {
			[Export ("maximumNumberOfSelectionVideo")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nint_objc_msgSend (this.Handle, Selector.GetHandle ("maximumNumberOfSelectionVideo"));
				} else {
					return global::ApiDefinition.Messaging.nint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("maximumNumberOfSelectionVideo"));
				}
			}
			
			[Export ("setMaximumNumberOfSelectionVideo:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nint (this.Handle, Selector.GetHandle ("setMaximumNumberOfSelectionVideo:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nint (this.SuperHandle, Selector.GetHandle ("setMaximumNumberOfSelectionVideo:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual NSMutableArray OrderedSelectedItem {
			[Export ("orderedSelectedItem", ArgumentSemantic.Retain)]
			get {
				NSMutableArray ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSMutableArray> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("orderedSelectedItem")));
				} else {
					ret =  Runtime.GetNSObject<NSMutableArray> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("orderedSelectedItem")));
				}
				return ret;
			}
			
			[Export ("setOrderedSelectedItem:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setOrderedSelectedItem:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setOrderedSelectedItem:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::AssetsLibrary.ALAsset SelectedAsset {
			[Export ("selectedAsset", ArgumentSemantic.Retain)]
			get {
				global::AssetsLibrary.ALAsset ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::AssetsLibrary.ALAsset> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("selectedAsset")));
				} else {
					ret =  Runtime.GetNSObject<global::AssetsLibrary.ALAsset> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("selectedAsset")));
				}
				return ret;
			}
			
			[Export ("setSelectedAsset:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSelectedAsset:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setSelectedAsset:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_WeakDelegate_var;
		[CompilerGenerated]
		public virtual NSObject WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")));
				} else {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("delegate")));
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret;
			}
			
			[Export ("setDelegate:", ArgumentSemantic.Weak)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_WeakDelegate_var = value;
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_BtnDone_var = null;
				__mt_WeakDelegate_var = null;
			}
		}
	} /* class UzysAssetsPickerController */
}
