package md5502796294cb3bd55fb945c19da81d4b8;


public class BackStackListener_1
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		android.support.v4.app.FragmentManager.OnBackStackChangedListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onBackStackChanged:()V:GetOnBackStackChangedHandler:Android.Support.V4.App.FragmentManager/IOnBackStackChangedListenerInvoker, Xamarin.Android.Support.v4\n" +
			"";
		mono.android.Runtime.register ("PorpoiseMobileApp.Droid.Views.BackStackListener`1, PorpoiseMobileApp.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", BackStackListener_1.class, __md_methods);
	}


	public BackStackListener_1 () throws java.lang.Throwable
	{
		super ();
		if (getClass () == BackStackListener_1.class)
			mono.android.TypeManager.Activate ("PorpoiseMobileApp.Droid.Views.BackStackListener`1, PorpoiseMobileApp.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public BackStackListener_1 (android.app.Activity p0) throws java.lang.Throwable
	{
		super ();
		if (getClass () == BackStackListener_1.class)
			mono.android.TypeManager.Activate ("PorpoiseMobileApp.Droid.Views.BackStackListener`1, PorpoiseMobileApp.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.App.Activity, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}


	public void onBackStackChanged ()
	{
		n_onBackStackChanged ();
	}

	private native void n_onBackStackChanged ();

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
