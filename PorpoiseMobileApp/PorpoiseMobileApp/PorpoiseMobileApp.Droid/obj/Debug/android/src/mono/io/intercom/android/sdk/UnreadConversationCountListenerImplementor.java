package mono.io.intercom.android.sdk;


public class UnreadConversationCountListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		io.intercom.android.sdk.UnreadConversationCountListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCountUpdate:(I)V:GetOnCountUpdate_IHandler:IO.Intercom.Android.Sdk.IUnreadConversationCountListenerInvoker, IntercomBinding_Droid\n" +
			"";
		mono.android.Runtime.register ("IO.Intercom.Android.Sdk.IUnreadConversationCountListenerImplementor, IntercomBinding_Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", UnreadConversationCountListenerImplementor.class, __md_methods);
	}


	public UnreadConversationCountListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == UnreadConversationCountListenerImplementor.class)
			mono.android.TypeManager.Activate ("IO.Intercom.Android.Sdk.IUnreadConversationCountListenerImplementor, IntercomBinding_Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCountUpdate (int p0)
	{
		n_onCountUpdate (p0);
	}

	private native void n_onCountUpdate (int p0);

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
