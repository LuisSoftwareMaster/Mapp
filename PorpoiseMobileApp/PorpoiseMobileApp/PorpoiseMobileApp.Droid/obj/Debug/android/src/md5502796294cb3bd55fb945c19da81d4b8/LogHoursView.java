package md5502796294cb3bd55fb945c19da81d4b8;


public class LogHoursView
	extends md5502796294cb3bd55fb945c19da81d4b8.MvvmFragment_1
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onActivityCreated:(Landroid/os/Bundle;)V:GetOnActivityCreated_Landroid_os_Bundle_Handler\n" +
			"n_onViewCreated:(Landroid/view/View;Landroid/os/Bundle;)V:GetOnViewCreated_Landroid_view_View_Landroid_os_Bundle_Handler\n" +
			"n_onRequestPermissionsResult:(I[Ljava/lang/String;[I)V:GetOnRequestPermissionsResult_IarrayLjava_lang_String_arrayIHandler\n" +
			"n_shouldShowRequestPermissionRationale:(Ljava/lang/String;)Z:GetShouldShowRequestPermissionRationale_Ljava_lang_String_Handler\n" +
			"n_onResume:()V:GetOnResumeHandler\n" +
			"n_onStop:()V:GetOnStopHandler\n" +
			"";
		mono.android.Runtime.register ("PorpoiseMobileApp.Droid.Views.LogHoursView, PorpoiseMobileApp.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", LogHoursView.class, __md_methods);
	}


	public LogHoursView () throws java.lang.Throwable
	{
		super ();
		if (getClass () == LogHoursView.class)
			mono.android.TypeManager.Activate ("PorpoiseMobileApp.Droid.Views.LogHoursView, PorpoiseMobileApp.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onActivityCreated (android.os.Bundle p0)
	{
		n_onActivityCreated (p0);
	}

	private native void n_onActivityCreated (android.os.Bundle p0);


	public void onViewCreated (android.view.View p0, android.os.Bundle p1)
	{
		n_onViewCreated (p0, p1);
	}

	private native void n_onViewCreated (android.view.View p0, android.os.Bundle p1);


	public void onRequestPermissionsResult (int p0, java.lang.String[] p1, int[] p2)
	{
		n_onRequestPermissionsResult (p0, p1, p2);
	}

	private native void n_onRequestPermissionsResult (int p0, java.lang.String[] p1, int[] p2);


	public boolean shouldShowRequestPermissionRationale (java.lang.String p0)
	{
		return n_shouldShowRequestPermissionRationale (p0);
	}

	private native boolean n_shouldShowRequestPermissionRationale (java.lang.String p0);


	public void onResume ()
	{
		n_onResume ();
	}

	private native void n_onResume ();


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
