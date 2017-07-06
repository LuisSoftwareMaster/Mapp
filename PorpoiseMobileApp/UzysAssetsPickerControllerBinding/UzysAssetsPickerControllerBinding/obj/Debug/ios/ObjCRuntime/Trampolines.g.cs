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

namespace ObjCRuntime {
	
	[CompilerGenerated]
	static partial class Trampolines {
		
		[DllImport ("/usr/lib/libobjc.dylib")]
		static extern IntPtr _Block_copy (IntPtr ptr);
		
		[DllImport ("/usr/lib/libobjc.dylib")]
		static extern void _Block_release (IntPtr ptr);
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::UzysAssetsPickerController.intBlock))]
		internal delegate void DintBlock (IntPtr block, global::System.nint arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDintBlock {
			static internal readonly DintBlock Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DintBlock))]
			static unsafe void Invoke (IntPtr block, global::System.nint arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::UzysAssetsPickerController.intBlock) (descriptor->Target);
				if (del != null)
					del (arg0);
			}
		} /* class SDintBlock */
		
		internal class NIDintBlock {
			IntPtr blockPtr;
			DintBlock invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDintBlock (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DintBlock> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDintBlock ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::UzysAssetsPickerController.intBlock Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::UzysAssetsPickerController.intBlock;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDintBlock ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::System.nint arg0)
			{
				invoker (blockPtr, arg0);
			}
		} /* class NIDintBlock */
	}
}
