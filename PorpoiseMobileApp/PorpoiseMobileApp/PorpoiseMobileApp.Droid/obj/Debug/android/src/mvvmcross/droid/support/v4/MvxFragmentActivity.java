package mvvmcross.droid.support.v4;


public class MvxFragmentActivity
	extends md54c8d3888e79e210381ebdd7cb087857c.MvxEventSourceFragmentActivity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_setContentView:(I)V:GetSetContentView_IHandler\n" +
			"n_attachBaseContext:(Landroid/content/Context;)V:GetAttachBaseContext_Landroid_content_Context_Handler\n" +
			"";
		mono.android.Runtime.register ("MvvmCross.Droid.Support.V4.MvxFragmentActivity, MvvmCross.Droid.Support.V4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", MvxFragmentActivity.class, __md_methods);
	}


	public MvxFragmentActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == MvxFragmentActivity.class)
			mono.android.TypeManager.Activate ("MvvmCross.Droid.Support.V4.MvxFragmentActivity, MvvmCross.Droid.Support.V4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void setContentView (int p0)
	{
		n_setContentView (p0);
	}

	private native void n_setContentView (int p0);


	public void attachBaseContext (android.content.Context p0)
	{
		n_attachBaseContext (p0);
	}

	private native void n_attachBaseContext (android.content.Context p0);

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
