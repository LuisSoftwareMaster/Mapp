package mono.io.intercom.android.sdk.conversation;


public class ReactionListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		io.intercom.android.sdk.conversation.ReactionListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onReactionSelected:()V:GetOnReactionSelectedHandler:IO.Intercom.Android.Sdk.Conversation.IReactionListenerInvoker, IntercomBinding_Droid\n" +
			"";
		mono.android.Runtime.register ("IO.Intercom.Android.Sdk.Conversation.IReactionListenerImplementor, IntercomBinding_Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ReactionListenerImplementor.class, __md_methods);
	}


	public ReactionListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == ReactionListenerImplementor.class)
			mono.android.TypeManager.Activate ("IO.Intercom.Android.Sdk.Conversation.IReactionListenerImplementor, IntercomBinding_Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onReactionSelected ()
	{
		n_onReactionSelected ();
	}

	private native void n_onReactionSelected ();

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
