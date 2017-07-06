package mono.io.intercom.android.sdk.views;


public class ContentAwareScrollView_ListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		io.intercom.android.sdk.views.ContentAwareScrollView.Listener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onBottomReached:()V:GetOnBottomReachedHandler:IO.Intercom.Android.Sdk.Views.ContentAwareScrollView/IListenerInvoker, IntercomBinding_Droid\n" +
			"n_onScrollChanged:(I)V:GetOnScrollChanged_IHandler:IO.Intercom.Android.Sdk.Views.ContentAwareScrollView/IListenerInvoker, IntercomBinding_Droid\n" +
			"";
		mono.android.Runtime.register ("IO.Intercom.Android.Sdk.Views.ContentAwareScrollView+IListenerImplementor, IntercomBinding_Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ContentAwareScrollView_ListenerImplementor.class, __md_methods);
	}


	public ContentAwareScrollView_ListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == ContentAwareScrollView_ListenerImplementor.class)
			mono.android.TypeManager.Activate ("IO.Intercom.Android.Sdk.Views.ContentAwareScrollView+IListenerImplementor, IntercomBinding_Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onBottomReached ()
	{
		n_onBottomReached ();
	}

	private native void n_onBottomReached ();


	public void onScrollChanged (int p0)
	{
		n_onScrollChanged (p0);
	}

	private native void n_onScrollChanged (int p0);

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
