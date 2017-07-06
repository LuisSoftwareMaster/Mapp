package mono.io.intercom.android.sdk.imageloader;


public class LongTermImageLoader_OnImageReadyListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		io.intercom.android.sdk.imageloader.LongTermImageLoader.OnImageReadyListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onImageReady:(Landroid/graphics/Bitmap;)V:GetOnImageReady_Landroid_graphics_Bitmap_Handler:IO.Intercom.Android.Sdk.Imageloader.LongTermImageLoader/IOnImageReadyListenerInvoker, IntercomBinding_Droid\n" +
			"";
		mono.android.Runtime.register ("IO.Intercom.Android.Sdk.Imageloader.LongTermImageLoader+IOnImageReadyListenerImplementor, IntercomBinding_Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", LongTermImageLoader_OnImageReadyListenerImplementor.class, __md_methods);
	}


	public LongTermImageLoader_OnImageReadyListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == LongTermImageLoader_OnImageReadyListenerImplementor.class)
			mono.android.TypeManager.Activate ("IO.Intercom.Android.Sdk.Imageloader.LongTermImageLoader+IOnImageReadyListenerImplementor, IntercomBinding_Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onImageReady (android.graphics.Bitmap p0)
	{
		n_onImageReady (p0);
	}

	private native void n_onImageReady (android.graphics.Bitmap p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
