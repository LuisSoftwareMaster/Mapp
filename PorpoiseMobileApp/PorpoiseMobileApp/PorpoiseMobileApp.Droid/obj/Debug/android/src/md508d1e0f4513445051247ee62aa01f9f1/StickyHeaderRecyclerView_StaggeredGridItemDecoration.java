package md508d1e0f4513445051247ee62aa01f9f1;


public class StickyHeaderRecyclerView_StaggeredGridItemDecoration
	extends android.support.v7.widget.RecyclerView.ItemDecoration
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_getItemOffsets:(Landroid/graphics/Rect;Landroid/view/View;Landroid/support/v7/widget/RecyclerView;Landroid/support/v7/widget/RecyclerView$State;)V:GetGetItemOffsets_Landroid_graphics_Rect_Landroid_view_View_Landroid_support_v7_widget_RecyclerView_Landroid_support_v7_widget_RecyclerView_State_Handler\n" +
			"";
		mono.android.Runtime.register ("StickyHeader.StickyHeaderRecyclerView+StaggeredGridItemDecoration, StickyHeader, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", StickyHeaderRecyclerView_StaggeredGridItemDecoration.class, __md_methods);
	}


	public StickyHeaderRecyclerView_StaggeredGridItemDecoration () throws java.lang.Throwable
	{
		super ();
		if (getClass () == StickyHeaderRecyclerView_StaggeredGridItemDecoration.class)
			mono.android.TypeManager.Activate ("StickyHeader.StickyHeaderRecyclerView+StaggeredGridItemDecoration, StickyHeader, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void getItemOffsets (android.graphics.Rect p0, android.view.View p1, android.support.v7.widget.RecyclerView p2, android.support.v7.widget.RecyclerView.State p3)
	{
		n_getItemOffsets (p0, p1, p2, p3);
	}

	private native void n_getItemOffsets (android.graphics.Rect p0, android.view.View p1, android.support.v7.widget.RecyclerView p2, android.support.v7.widget.RecyclerView.State p3);

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
