package md5fc9cb9f6aa8f85c65a03614b5176458b;


public class StickyScrollView_RunnableAnonymousInnerClassHelper
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		java.lang.Runnable
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_run:()V:GetRunHandler:Java.Lang.IRunnableInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("stickyscrollviewxamarinandroid.StickyScrollView+RunnableAnonymousInnerClassHelper, PorpoiseMobileApp.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", StickyScrollView_RunnableAnonymousInnerClassHelper.class, __md_methods);
	}


	public StickyScrollView_RunnableAnonymousInnerClassHelper () throws java.lang.Throwable
	{
		super ();
		if (getClass () == StickyScrollView_RunnableAnonymousInnerClassHelper.class)
			mono.android.TypeManager.Activate ("stickyscrollviewxamarinandroid.StickyScrollView+RunnableAnonymousInnerClassHelper, PorpoiseMobileApp.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public StickyScrollView_RunnableAnonymousInnerClassHelper (md5fc9cb9f6aa8f85c65a03614b5176458b.StickyScrollView p0) throws java.lang.Throwable
	{
		super ();
		if (getClass () == StickyScrollView_RunnableAnonymousInnerClassHelper.class)
			mono.android.TypeManager.Activate ("stickyscrollviewxamarinandroid.StickyScrollView+RunnableAnonymousInnerClassHelper, PorpoiseMobileApp.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "stickyscrollviewxamarinandroid.StickyScrollView, PorpoiseMobileApp.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", this, new java.lang.Object[] { p0 });
	}


	public void run ()
	{
		n_run ();
	}

	private native void n_run ();

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
