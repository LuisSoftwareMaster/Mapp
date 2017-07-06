package mono.io.intercom.android.sdk.conversation;


public class ComposerInputView_ListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		io.intercom.android.sdk.conversation.ComposerInputView.Listener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onSendButtonPressed:()V:GetOnSendButtonPressedHandler:IO.Intercom.Android.Sdk.Conversation.ComposerInputView/IListenerInvoker, IntercomBinding_Droid\n" +
			"n_onUploadButtonPressed:()V:GetOnUploadButtonPressedHandler:IO.Intercom.Android.Sdk.Conversation.ComposerInputView/IListenerInvoker, IntercomBinding_Droid\n" +
			"";
		mono.android.Runtime.register ("IO.Intercom.Android.Sdk.Conversation.ComposerInputView+IListenerImplementor, IntercomBinding_Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ComposerInputView_ListenerImplementor.class, __md_methods);
	}


	public ComposerInputView_ListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == ComposerInputView_ListenerImplementor.class)
			mono.android.TypeManager.Activate ("IO.Intercom.Android.Sdk.Conversation.ComposerInputView+IListenerImplementor, IntercomBinding_Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onSendButtonPressed ()
	{
		n_onSendButtonPressed ();
	}

	private native void n_onSendButtonPressed ();


	public void onUploadButtonPressed ()
	{
		n_onUploadButtonPressed ();
	}

	private native void n_onUploadButtonPressed ();

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
