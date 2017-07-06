package md508d1e0f4513445051247ee62aa01f9f1;


public class StickyHeaderRecyclerView_RecyclerScrollListener
	extends android.support.v7.widget.RecyclerView.OnScrollListener
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onScrolled:(Landroid/support/v7/widget/RecyclerView;II)V:GetOnScrolled_Landroid_support_v7_widget_RecyclerView_IIHandler\n" +
			"";
		mono.android.Runtime.register ("StickyHeader.StickyHeaderRecyclerView+RecyclerScrollListener, StickyHeader, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", StickyHeaderRecyclerView_RecyclerScrollListener.class, __md_methods);
	}


	public StickyHeaderRecyclerView_RecyclerScrollListener () throws java.lang.Throwable
	{
		super ();
		if (getClass () == StickyHeaderRecyclerView_RecyclerScrollListener.class)
			mono.android.TypeManager.Activate ("StickyHeader.StickyHeaderRecyclerView+RecyclerScrollListener, StickyHeader, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onScrolled (android.support.v7.widget.RecyclerView p0, int p1, int p2)
	{
		n_onScrolled (p0, p1, p2);
	}

	private native void n_onScrolled (android.support.v7.widget.RecyclerView p0, int p1, int p2);

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
