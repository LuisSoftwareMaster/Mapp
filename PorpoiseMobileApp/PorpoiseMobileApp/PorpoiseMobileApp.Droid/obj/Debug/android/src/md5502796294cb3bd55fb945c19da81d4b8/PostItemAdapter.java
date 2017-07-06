package md5502796294cb3bd55fb945c19da81d4b8;


public class PostItemAdapter
	extends md5bf0126c95bf9fc0db24c02c9adb4cfa7.MvxAdapter
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_isEnabled:(I)Z:GetIsEnabled_IHandler\n" +
			"";
		mono.android.Runtime.register ("PorpoiseMobileApp.Droid.Views.PostItemAdapter, PorpoiseMobileApp.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", PostItemAdapter.class, __md_methods);
	}


	public PostItemAdapter () throws java.lang.Throwable
	{
		super ();
		if (getClass () == PostItemAdapter.class)
			mono.android.TypeManager.Activate ("PorpoiseMobileApp.Droid.Views.PostItemAdapter, PorpoiseMobileApp.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public PostItemAdapter (android.content.Context p0) throws java.lang.Throwable
	{
		super ();
		if (getClass () == PostItemAdapter.class)
			mono.android.TypeManager.Activate ("PorpoiseMobileApp.Droid.Views.PostItemAdapter, PorpoiseMobileApp.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}


	public boolean isEnabled (int p0)
	{
		return n_isEnabled (p0);
	}

	private native boolean n_isEnabled (int p0);

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
