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
	[Register("UzysGroupPickerView", true)]
	public unsafe partial class UzysGroupPickerView : global::UIKit.UIView, global::UIKit.IUIGestureRecognizerDelegate, global::UIKit.IUIScrollViewDelegate, global::UIKit.IUITableViewDataSource, global::UIKit.IUITableViewDelegate {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("UzysGroupPickerView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UzysGroupPickerView () : base (NSObjectFlag.Empty)
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
		public UzysGroupPickerView (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected UzysGroupPickerView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal UzysGroupPickerView (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithGroups:")]
		[CompilerGenerated]
		public UzysGroupPickerView (NSMutableArray groups)
			: base (NSObjectFlag.Empty)
		{
			if (groups == null)
				throw new ArgumentNullException ("groups");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithGroups:"), groups.Handle), "initWithGroups:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithGroups:"), groups.Handle), "initWithGroups:");
			}
		}
		
		[Export ("dismiss:")]
		[CompilerGenerated]
		public virtual void Dismiss (bool animated)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("dismiss:"), animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("dismiss:"), animated);
			}
		}
		
		[Export ("tableView:cellForRowAtIndexPath:")]
		[CompilerGenerated]
		[Preserve (Conditional = true)]
		public virtual UITableViewCell GetCell (global::UIKit.UITableView tableView, NSIndexPath indexPath)
		{
			if (tableView == null)
				throw new ArgumentNullException ("tableView");
			if (indexPath == null)
				throw new ArgumentNullException ("indexPath");
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<UITableViewCell> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("tableView:cellForRowAtIndexPath:"), tableView.Handle, indexPath.Handle));
			} else {
				return  Runtime.GetNSObject<UITableViewCell> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("tableView:cellForRowAtIndexPath:"), tableView.Handle, indexPath.Handle));
			}
		}
		
		[Export ("reloadData")]
		[CompilerGenerated]
		public virtual void ReloadData ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("reloadData"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("reloadData"));
			}
		}
		
		[Export ("tableView:numberOfRowsInSection:")]
		[CompilerGenerated]
		[Preserve (Conditional = true)]
		public virtual global::System.nint RowsInSection (global::UIKit.UITableView tableView, global::System.nint section)
		{
			if (tableView == null)
				throw new ArgumentNullException ("tableView");
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.nint_objc_msgSend_IntPtr_nint (this.Handle, Selector.GetHandle ("tableView:numberOfRowsInSection:"), tableView.Handle, section);
			} else {
				return global::ApiDefinition.Messaging.nint_objc_msgSendSuper_IntPtr_nint (this.SuperHandle, Selector.GetHandle ("tableView:numberOfRowsInSection:"), tableView.Handle, section);
			}
		}
		
		[Export ("show")]
		[CompilerGenerated]
		public virtual void Show ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("show"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("show"));
			}
		}
		
		[Export ("toggle")]
		[CompilerGenerated]
		public virtual void Toggle ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("toggle"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("toggle"));
			}
		}
		
		[CompilerGenerated]
		public unsafe virtual intBlock BlockTouchCell {
			[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDintBlock))]
			[Export ("blockTouchCell", ArgumentSemantic.Copy)]
			get {
				IntPtr ret;
				if (IsDirectBinding) {
					ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("blockTouchCell"));
				} else {
					ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("blockTouchCell"));
				}
				return global::ObjCRuntime.Trampolines.NIDintBlock.Create (ret);
			}
			
			[Export ("setBlockTouchCell:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				BlockLiteral *block_ptr_value;
				BlockLiteral block_value;
				block_value = new BlockLiteral ();
				block_ptr_value = &block_value;
				block_value.SetupBlock (Trampolines.SDintBlock.Handler, value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setBlockTouchCell:"), (IntPtr) block_ptr_value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setBlockTouchCell:"), (IntPtr) block_ptr_value);
				}
				block_ptr_value->CleanupBlock ();
				
			}
		}
		
		[CompilerGenerated]
		public virtual NSMutableArray Groups {
			[Export ("groups", ArgumentSemantic.Retain)]
			get {
				NSMutableArray ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSMutableArray> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("groups")));
				} else {
					ret =  Runtime.GetNSObject<NSMutableArray> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("groups")));
				}
				return ret;
			}
			
			[Export ("setGroups:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setGroups:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setGroups:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool IsOpen {
			[Export ("isOpen")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isOpen"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isOpen"));
				}
			}
			
			[Export ("setIsOpen:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setIsOpen:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setIsOpen:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UITableView TableView {
			[Export ("tableView", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UITableView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UITableView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("tableView")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UITableView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("tableView")));
				}
				return ret;
			}
			
			[Export ("setTableView:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setTableView:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setTableView:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UITapGestureRecognizer TapGestureRecognizer {
			[Export ("tapGestureRecognizer", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UITapGestureRecognizer ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UITapGestureRecognizer> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("tapGestureRecognizer")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UITapGestureRecognizer> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("tapGestureRecognizer")));
				}
				return ret;
			}
			
			[Export ("setTapGestureRecognizer:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setTapGestureRecognizer:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setTapGestureRecognizer:"), value.Handle);
				}
			}
		}
		
		public partial class UzysGroupPickerViewAppearance : global::UIKit.UIView.UIViewAppearance {
			protected internal UzysGroupPickerViewAppearance (IntPtr handle) : base (handle) {}
		}
		
		public static new UzysGroupPickerViewAppearance Appearance {
			get { return new UzysGroupPickerViewAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		
		public static new UzysGroupPickerViewAppearance GetAppearance<T> () where T: UzysGroupPickerView {
			return new UzysGroupPickerViewAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		
		public static new UzysGroupPickerViewAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new UzysGroupPickerViewAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		
		public static new UzysGroupPickerViewAppearance GetAppearance (UITraitCollection traits) {
			return new UzysGroupPickerViewAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		
		public static new UzysGroupPickerViewAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new UzysGroupPickerViewAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		
		public static new UzysGroupPickerViewAppearance GetAppearance<T> (UITraitCollection traits) where T: UzysGroupPickerView {
			return new UzysGroupPickerViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		
		public static new UzysGroupPickerViewAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: UzysGroupPickerView{
			return new UzysGroupPickerViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
		
		
	} /* class UzysGroupPickerView */
}
