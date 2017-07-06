package md5fc9cb9f6aa8f85c65a03614b5176458b;


public class StickyScrollView
	extends android.widget.ScrollView
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onLayout:(ZIIII)V:GetOnLayout_ZIIIIHandler\n" +
			"n_setClipToPadding:(Z)V:GetSetClipToPadding_ZHandler\n" +
			"n_addView:(Landroid/view/View;)V:GetAddView_Landroid_view_View_Handler\n" +
			"n_addView:(Landroid/view/View;I)V:GetAddView_Landroid_view_View_IHandler\n" +
			"n_addView:(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V:GetAddView_Landroid_view_View_ILandroid_view_ViewGroup_LayoutParams_Handler\n" +
			"n_addView:(Landroid/view/View;II)V:GetAddView_Landroid_view_View_IIHandler\n" +
			"n_addView:(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V:GetAddView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_Handler\n" +
			"n_dispatchDraw:(Landroid/graphics/Canvas;)V:GetDispatchDraw_Landroid_graphics_Canvas_Handler\n" +
			"n_dispatchTouchEvent:(Landroid/view/MotionEvent;)Z:GetDispatchTouchEvent_Landroid_view_MotionEvent_Handler\n" +
			"n_onTouchEvent:(Landroid/view/MotionEvent;)Z:GetOnTouchEvent_Landroid_view_MotionEvent_Handler\n" +
			"n_onScrollChanged:(IIII)V:GetOnScrollChanged_IIIIHandler\n" +
			"";
		mono.android.Runtime.register ("stickyscrollviewxamarinandroid.StickyScrollView, PorpoiseMobileApp.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", StickyScrollView.class, __md_methods);
	}


	public StickyScrollView (android.content.Context p0) throws java.lang.Throwable
	{
		super (p0);
		if (getClass () == StickyScrollView.class)
			mono.android.TypeManager.Activate ("stickyscrollviewxamarinandroid.StickyScrollView, PorpoiseMobileApp.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}


	public StickyScrollView (android.content.Context p0, android.util.AttributeSet p1) throws java.lang.Throwable
	{
		super (p0, p1);
		if (getClass () == StickyScrollView.class)
			mono.android.TypeManager.Activate ("stickyscrollviewxamarinandroid.StickyScrollView, PorpoiseMobileApp.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Util.IAttributeSet, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0, p1 });
	}


	public StickyScrollView (android.content.Context p0, android.util.AttributeSet p1, int p2) throws java.lang.Throwable
	{
		super (p0, p1, p2);
		if (getClass () == StickyScrollView.class)
			mono.android.TypeManager.Activate ("stickyscrollviewxamarinandroid.StickyScrollView, PorpoiseMobileApp.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Util.IAttributeSet, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:System.Int32, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public StickyScrollView (android.content.Context p0, android.util.AttributeSet p1, int p2, int p3) throws java.lang.Throwable
	{
		super (p0, p1, p2, p3);
		if (getClass () == StickyScrollView.class)
			mono.android.TypeManager.Activate ("stickyscrollviewxamarinandroid.StickyScrollView, PorpoiseMobileApp.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Util.IAttributeSet, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:System.Int32, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e:System.Int32, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new java.lang.Object[] { p0, p1, p2, p3 });
	}


	public void onLayout (boolean p0, int p1, int p2, int p3, int p4)
	{
		n_onLayout (p0, p1, p2, p3, p4);
	}

	private native void n_onLayout (boolean p0, int p1, int p2, int p3, int p4);


	public void setClipToPadding (boolean p0)
	{
		n_setClipToPadding (p0);
	}

	private native void n_setClipToPadding (boolean p0);


	public void addView (android.view.View p0)
	{
		n_addView (p0);
	}

	private native void n_addView (android.view.View p0);


	public void addView (android.view.View p0, int p1)
	{
		n_addView (p0, p1);
	}

	private native void n_addView (android.view.View p0, int p1);


	public void addView (android.view.View p0, int p1, android.view.ViewGroup.LayoutParams p2)
	{
		n_addView (p0, p1, p2);
	}

	private native void n_addView (android.view.View p0, int p1, android.view.ViewGroup.LayoutParams p2);


	public void addView (android.view.View p0, int p1, int p2)
	{
		n_addView (p0, p1, p2);
	}

	private native void n_addView (android.view.View p0, int p1, int p2);


	public void addView (android.view.View p0, android.view.ViewGroup.LayoutParams p1)
	{
		n_addView (p0, p1);
	}

	private native void n_addView (android.view.View p0, android.view.ViewGroup.LayoutParams p1);


	public void dispatchDraw (android.graphics.Canvas p0)
	{
		n_dispatchDraw (p0);
	}

	private native void n_dispatchDraw (android.graphics.Canvas p0);


	public boolean dispatchTouchEvent (android.view.MotionEvent p0)
	{
		return n_dispatchTouchEvent (p0);
	}

	private native boolean n_dispatchTouchEvent (android.view.MotionEvent p0);


	public boolean onTouchEvent (android.view.MotionEvent p0)
	{
		return n_onTouchEvent (p0);
	}

	private native boolean n_onTouchEvent (android.view.MotionEvent p0);


	public void onScrollChanged (int p0, int p1, int p2, int p3)
	{
		n_onScrollChanged (p0, p1, p2, p3);
	}

	private native void n_onScrollChanged (int p0, int p1, int p2, int p3);

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
