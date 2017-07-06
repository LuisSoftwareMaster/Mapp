package mono.io.intercom.android.sdk.conversation;


public class UploadProgressListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		io.intercom.android.sdk.conversation.UploadProgressListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_uploadNotice:(B)V:GetUploadNotice_BHandler:IO.Intercom.Android.Sdk.Conversation.IUploadProgressListenerInvoker, IntercomBinding_Droid\n" +
			"n_uploadStarted:()V:GetUploadStartedHandler:IO.Intercom.Android.Sdk.Conversation.IUploadProgressListenerInvoker, IntercomBinding_Droid\n" +
			"n_uploadStopped:()V:GetUploadStoppedHandler:IO.Intercom.Android.Sdk.Conversation.IUploadProgressListenerInvoker, IntercomBinding_Droid\n" +
			"";
		mono.android.Runtime.register ("IO.Intercom.Android.Sdk.Conversation.IUploadProgressListenerImplementor, IntercomBinding_Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", UploadProgressListenerImplementor.class, __md_methods);
	}


	public UploadProgressListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == UploadProgressListenerImplementor.class)
			mono.android.TypeManager.Activate ("IO.Intercom.Android.Sdk.Conversation.IUploadProgressListenerImplementor, IntercomBinding_Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void uploadNotice (byte p0)
	{
		n_uploadNotice (p0);
	}

	private native void n_uploadNotice (byte p0);


	public void uploadStarted ()
	{
		n_uploadStarted ();
	}

	private native void n_uploadStarted ();


	public void uploadStopped ()
	{
		n_uploadStopped ();
	}

	private native void n_uploadStopped ();

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
