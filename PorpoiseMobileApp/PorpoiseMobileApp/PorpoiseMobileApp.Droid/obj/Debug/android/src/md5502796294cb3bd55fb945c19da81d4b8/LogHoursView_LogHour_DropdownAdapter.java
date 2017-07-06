package md5502796294cb3bd55fb945c19da81d4b8;


public class LogHoursView_LogHour_DropdownAdapter
	extends md5bf0126c95bf9fc0db24c02c9adb4cfa7.MvxAdapter
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_getDropDownView:(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;:GetGetDropDownView_ILandroid_view_View_Landroid_view_ViewGroup_Handler\n" +
			"";
		mono.android.Runtime.register ("PorpoiseMobileApp.Droid.Views.LogHoursView+LogHour_DropdownAdapter, PorpoiseMobileApp.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", LogHoursView_LogHour_DropdownAdapter.class, __md_methods);
	}


	public LogHoursView_LogHour_DropdownAdapter () throws java.lang.Throwable
	{
		super ();
		if (getClass () == LogHoursView_LogHour_DropdownAdapter.class)
			mono.android.TypeManager.Activate ("PorpoiseMobileApp.Droid.Views.LogHoursView+LogHour_DropdownAdapter, PorpoiseMobileApp.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public LogHoursView_LogHour_DropdownAdapter (android.content.Context p0) throws java.lang.Throwable
	{
		super ();
		if (getClass () == LogHoursView_LogHour_DropdownAdapter.class)
			mono.android.TypeManager.Activate ("PorpoiseMobileApp.Droid.Views.LogHoursView+LogHour_DropdownAdapter, PorpoiseMobileApp.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}


	public android.view.View getDropDownView (int p0, android.view.View p1, android.view.ViewGroup p2)
	{
		return n_getDropDownView (p0, p1, p2);
	}

	private native android.view.View n_getDropDownView (int p0, android.view.View p1, android.view.ViewGroup p2);

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
