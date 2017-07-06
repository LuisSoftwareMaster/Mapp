package md5ffbfae892aaf094f4ba80ccb94b1c2b5;


public abstract class MvvmFragmentActivity_1
	extends mvvmcross.droid.support.v4.MvxFragmentActivity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"n_onStart:()V:GetOnStartHandler\n" +
			"n_onStop:()V:GetOnStopHandler\n" +
			"";
		mono.android.Runtime.register ("PorpoiseMobileApp.Droid.MvvmCross.MvvmFragmentActivity`1, PorpoiseMobileApp.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", MvvmFragmentActivity_1.class, __md_methods);
	}


	public MvvmFragmentActivity_1 () throws java.lang.Throwable
	{
		super ();
		if (getClass () == MvvmFragmentActivity_1.class)
			mono.android.TypeManager.Activate ("PorpoiseMobileApp.Droid.MvvmCross.MvvmFragmentActivity`1, PorpoiseMobileApp.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);


	public void onStart ()
	{
		n_onStart ();
	}

	private native void n_onStart ();


	public void onStop ()
	{
		n_onStop ();
	}

	private native void n_onStop ();

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
