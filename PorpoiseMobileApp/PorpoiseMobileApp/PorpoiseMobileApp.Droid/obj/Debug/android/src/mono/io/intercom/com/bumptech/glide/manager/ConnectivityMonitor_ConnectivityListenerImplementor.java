package mono.io.intercom.com.bumptech.glide.manager;


public class ConnectivityMonitor_ConnectivityListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		io.intercom.com.bumptech.glide.manager.ConnectivityMonitor.ConnectivityListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onConnectivityChanged:(Z)V:GetOnConnectivityChanged_ZHandler:IO.Intercom.Com.Bumptech.Glide.Manager.IConnectivityMonitorConnectivityListenerInvoker, IntercomBinding_Droid\n" +
			"";
		mono.android.Runtime.register ("IO.Intercom.Com.Bumptech.Glide.Manager.IConnectivityMonitorConnectivityListenerImplementor, IntercomBinding_Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ConnectivityMonitor_ConnectivityListenerImplementor.class, __md_methods);
	}


	public ConnectivityMonitor_ConnectivityListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == ConnectivityMonitor_ConnectivityListenerImplementor.class)
			mono.android.TypeManager.Activate ("IO.Intercom.Com.Bumptech.Glide.Manager.IConnectivityMonitorConnectivityListenerImplementor, IntercomBinding_Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onConnectivityChanged (boolean p0)
	{
		n_onConnectivityChanged (p0);
	}

	private native void n_onConnectivityChanged (boolean p0);

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
