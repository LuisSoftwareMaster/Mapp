package mono.io.intercom.android.sdk.views;


public class AttachedImageView_OnAttachedToWindowListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		io.intercom.android.sdk.views.AttachedImageView.OnAttachedToWindowListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_callback:()V:GetCallbackHandler:IO.Intercom.Android.Sdk.Views.AttachedImageView/IOnAttachedToWindowListenerInvoker, IntercomBinding_Droid\n" +
			"";
		mono.android.Runtime.register ("IO.Intercom.Android.Sdk.Views.AttachedImageView+IOnAttachedToWindowListenerImplementor, IntercomBinding_Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", AttachedImageView_OnAttachedToWindowListenerImplementor.class, __md_methods);
	}


	public AttachedImageView_OnAttachedToWindowListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == AttachedImageView_OnAttachedToWindowListenerImplementor.class)
			mono.android.TypeManager.Activate ("IO.Intercom.Android.Sdk.Views.AttachedImageView+IOnAttachedToWindowListenerImplementor, IntercomBinding_Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void callback ()
	{
		n_callback ();
	}

	private native void n_callback ();

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
