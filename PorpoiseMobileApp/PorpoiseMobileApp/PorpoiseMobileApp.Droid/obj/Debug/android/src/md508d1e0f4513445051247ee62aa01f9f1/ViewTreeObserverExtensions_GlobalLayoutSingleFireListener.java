package md508d1e0f4513445051247ee62aa01f9f1;


public class ViewTreeObserverExtensions_GlobalLayoutSingleFireListener
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
		mono.android.Runtime.register ("StickyHeader.ViewTreeObserverExtensions+GlobalLayoutSingleFireListener, StickyHeader, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ViewTreeObserverExtensions_GlobalLayoutSingleFireListener.class, __md_methods);
	}


	public ViewTreeObserverExtensions_GlobalLayoutSingleFireListener () throws java.lang.Throwable
	{
		super ();
		if (getClass () == ViewTreeObserverExtensions_GlobalLayoutSingleFireListener.class)
			mono.android.TypeManager.Activate ("StickyHeader.ViewTreeObserverExtensions+GlobalLayoutSingleFireListener, StickyHeader, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
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
