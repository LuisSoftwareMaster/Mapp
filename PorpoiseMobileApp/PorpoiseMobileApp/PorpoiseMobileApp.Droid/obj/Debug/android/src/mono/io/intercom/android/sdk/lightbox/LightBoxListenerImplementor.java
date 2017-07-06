package mono.io.intercom.android.sdk.lightbox;


public class LightBoxListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		io.intercom.android.sdk.lightbox.LightBoxListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_closeLightBox:()V:GetCloseLightBoxHandler:IO.Intercom.Android.Sdk.Lightbox.ILightBoxListenerInvoker, IntercomBinding_Droid\n" +
			"";
		mono.android.Runtime.register ("IO.Intercom.Android.Sdk.Lightbox.ILightBoxListenerImplementor, IntercomBinding_Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", LightBoxListenerImplementor.class, __md_methods);
	}


	public LightBoxListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == LightBoxListenerImplementor.class)
			mono.android.TypeManager.Activate ("IO.Intercom.Android.Sdk.Lightbox.ILightBoxListenerImplementor, IntercomBinding_Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void closeLightBox ()
	{
		n_closeLightBox ();
	}

	private native void n_closeLightBox ();

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
