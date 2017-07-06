package mono.io.intercom.android.sdk.utilities;


public class ConnectivityBroadcastReceiver_ConnectivityUpdateListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		io.intercom.android.sdk.utilities.ConnectivityBroadcastReceiver.ConnectivityUpdateListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onUpdate:()V:GetOnUpdateHandler:IO.Intercom.Android.Sdk.Utilities.ConnectivityBroadcastReceiver/IConnectivityUpdateListenerInvoker, IntercomBinding_Droid\n" +
			"";
		mono.android.Runtime.register ("IO.Intercom.Android.Sdk.Utilities.ConnectivityBroadcastReceiver+IConnectivityUpdateListenerImplementor, IntercomBinding_Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ConnectivityBroadcastReceiver_ConnectivityUpdateListenerImplementor.class, __md_methods);
	}


	public ConnectivityBroadcastReceiver_ConnectivityUpdateListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == ConnectivityBroadcastReceiver_ConnectivityUpdateListenerImplementor.class)
			mono.android.TypeManager.Activate ("IO.Intercom.Android.Sdk.Utilities.ConnectivityBroadcastReceiver+IConnectivityUpdateListenerImplementor, IntercomBinding_Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onUpdate ()
	{
		n_onUpdate ();
	}

	private native void n_onUpdate ();

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
