package md57306e6e149ebea1bf2ea3527cb156f39;


public class SupportView
	extends md5502796294cb3bd55fb945c19da81d4b8.MvvmFragment_1
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onViewCreated:(Landroid/view/View;Landroid/os/Bundle;)V:GetOnViewCreated_Landroid_view_View_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("PorpoiseMobileApp.Droid.SupportView, PorpoiseMobileApp.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", SupportView.class, __md_methods);
	}


	public SupportView () throws java.lang.Throwable
	{
		super ();
		if (getClass () == SupportView.class)
			mono.android.TypeManager.Activate ("PorpoiseMobileApp.Droid.SupportView, PorpoiseMobileApp.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onViewCreated (android.view.View p0, android.os.Bundle p1)
	{
		n_onViewCreated (p0, p1);
	}

	private native void n_onViewCreated (android.view.View p0, android.os.Bundle p1);

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
