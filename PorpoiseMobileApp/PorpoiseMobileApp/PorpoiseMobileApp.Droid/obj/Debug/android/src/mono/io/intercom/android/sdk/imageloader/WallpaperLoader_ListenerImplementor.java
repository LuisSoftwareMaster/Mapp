package mono.io.intercom.android.sdk.imageloader;


public class WallpaperLoader_ListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		io.intercom.android.sdk.imageloader.WallpaperLoader.Listener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onLoadComplete:()V:GetOnLoadCompleteHandler:IO.Intercom.Android.Sdk.Imageloader.WallpaperLoader/IListenerInvoker, IntercomBinding_Droid\n" +
			"";
		mono.android.Runtime.register ("IO.Intercom.Android.Sdk.Imageloader.WallpaperLoader+IListenerImplementor, IntercomBinding_Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", WallpaperLoader_ListenerImplementor.class, __md_methods);
	}


	public WallpaperLoader_ListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == WallpaperLoader_ListenerImplementor.class)
			mono.android.TypeManager.Activate ("IO.Intercom.Android.Sdk.Imageloader.WallpaperLoader+IListenerImplementor, IntercomBinding_Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onLoadComplete ()
	{
		n_onLoadComplete ();
	}

	private native void n_onLoadComplete ();

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
