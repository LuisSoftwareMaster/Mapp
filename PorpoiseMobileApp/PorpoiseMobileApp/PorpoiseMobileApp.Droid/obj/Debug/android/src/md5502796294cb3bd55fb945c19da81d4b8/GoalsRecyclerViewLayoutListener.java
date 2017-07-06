package md5502796294cb3bd55fb945c19da81d4b8;


public class GoalsRecyclerViewLayoutListener
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		android.view.ViewTreeObserver.OnGlobalLayoutListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onGlobalLayout:()V:GetOnGlobalLayoutHandler:Android.Views.ViewTreeObserver/IOnGlobalLayoutListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("PorpoiseMobileApp.Droid.Views.GoalsRecyclerViewLayoutListener, PorpoiseMobileApp.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", GoalsRecyclerViewLayoutListener.class, __md_methods);
	}


	public GoalsRecyclerViewLayoutListener () throws java.lang.Throwable
	{
		super ();
		if (getClass () == GoalsRecyclerViewLayoutListener.class)
			mono.android.TypeManager.Activate ("PorpoiseMobileApp.Droid.Views.GoalsRecyclerViewLayoutListener, PorpoiseMobileApp.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onGlobalLayout ()
	{
		n_onGlobalLayout ();
	}

	private native void n_onGlobalLayout ();

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
