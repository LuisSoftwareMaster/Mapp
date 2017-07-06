package md5ffbfae892aaf094f4ba80ccb94b1c2b5;


public abstract class MvvmActionBarActivity
	extends md5ffbfae892aaf094f4ba80ccb94b1c2b5.MvxActionBarEventSourceActivity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_setContentView:(I)V:GetSetContentView_IHandler\n" +
			"n_onBackPressed:()V:GetOnBackPressedHandler\n" +
			"n_onUserInteraction:()V:GetOnUserInteractionHandler\n" +
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"n_onResume:()V:GetOnResumeHandler\n" +
			"n_onPause:()V:GetOnPauseHandler\n" +
			"";
		mono.android.Runtime.register ("PorpoiseMobileApp.Droid.MvvmCross.MvvmActionBarActivity, PorpoiseMobileApp.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", MvvmActionBarActivity.class, __md_methods);
	}


	public MvvmActionBarActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == MvvmActionBarActivity.class)
			mono.android.TypeManager.Activate ("PorpoiseMobileApp.Droid.MvvmCross.MvvmActionBarActivity, PorpoiseMobileApp.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void setContentView (int p0)
	{
		n_setContentView (p0);
	}

	private native void n_setContentView (int p0);


	public void onBackPressed ()
	{
		n_onBackPressed ();
	}

	private native void n_onBackPressed ();


	public void onUserInteraction ()
	{
		n_onUserInteraction ();
	}

	private native void n_onUserInteraction ();


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);


	public void onResume ()
	{
		n_onResume ();
	}

	private native void n_onResume ();


	public void onPause ()
	{
		n_onPause ();
	}

	private native void n_onPause ();

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
