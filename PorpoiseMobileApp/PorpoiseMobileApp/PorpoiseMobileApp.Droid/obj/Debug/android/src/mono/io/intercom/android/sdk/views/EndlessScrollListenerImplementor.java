package mono.io.intercom.android.sdk.views;


public class EndlessScrollListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		io.intercom.android.sdk.views.EndlessScrollListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onLoadMore:()V:GetOnLoadMoreHandler:IO.Intercom.Android.Sdk.Views.IEndlessScrollListenerInvoker, IntercomBinding_Droid\n" +
			"n_setOverScrollColour:()V:GetSetOverScrollColourHandler:IO.Intercom.Android.Sdk.Views.IEndlessScrollListenerInvoker, IntercomBinding_Droid\n" +
			"";
		mono.android.Runtime.register ("IO.Intercom.Android.Sdk.Views.IEndlessScrollListenerImplementor, IntercomBinding_Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", EndlessScrollListenerImplementor.class, __md_methods);
	}


	public EndlessScrollListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == EndlessScrollListenerImplementor.class)
			mono.android.TypeManager.Activate ("IO.Intercom.Android.Sdk.Views.IEndlessScrollListenerImplementor, IntercomBinding_Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onLoadMore ()
	{
		n_onLoadMore ();
	}

	private native void n_onLoadMore ();


	public void setOverScrollColour ()
	{
		n_setOverScrollColour ();
	}

	private native void n_setOverScrollColour ();

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
