package md5502796294cb3bd55fb945c19da81d4b8;


public class HomeView_MenuAdapter
	extends md5bf0126c95bf9fc0db24c02c9adb4cfa7.MvxAdapter
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_getViewTypeCount:()I:GetGetViewTypeCountHandler\n" +
			"n_getItemViewType:(I)I:GetGetItemViewType_IHandler\n" +
			"";
		mono.android.Runtime.register ("PorpoiseMobileApp.Droid.Views.HomeView+MenuAdapter, PorpoiseMobileApp.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", HomeView_MenuAdapter.class, __md_methods);
	}


	public HomeView_MenuAdapter () throws java.lang.Throwable
	{
		super ();
		if (getClass () == HomeView_MenuAdapter.class)
			mono.android.TypeManager.Activate ("PorpoiseMobileApp.Droid.Views.HomeView+MenuAdapter, PorpoiseMobileApp.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public HomeView_MenuAdapter (android.content.Context p0) throws java.lang.Throwable
	{
		super ();
		if (getClass () == HomeView_MenuAdapter.class)
			mono.android.TypeManager.Activate ("PorpoiseMobileApp.Droid.Views.HomeView+MenuAdapter, PorpoiseMobileApp.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}


	public int getViewTypeCount ()
	{
		return n_getViewTypeCount ();
	}

	private native int n_getViewTypeCount ();


	public int getItemViewType (int p0)
	{
		return n_getItemViewType (p0);
	}

	private native int n_getItemViewType (int p0);

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
