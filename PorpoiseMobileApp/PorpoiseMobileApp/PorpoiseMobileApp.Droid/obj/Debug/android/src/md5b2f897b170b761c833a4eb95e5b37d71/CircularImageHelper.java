package md5b2f897b170b761c833a4eb95e5b37d71;


public class CircularImageHelper
	extends android.graphics.drawable.Drawable
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_draw:(Landroid/graphics/Canvas;)V:GetDraw_Landroid_graphics_Canvas_Handler\n" +
			"n_onBoundsChange:(Landroid/graphics/Rect;)V:GetOnBoundsChange_Landroid_graphics_Rect_Handler\n" +
			"n_getIntrinsicWidth:()I:GetGetIntrinsicWidthHandler\n" +
			"n_getIntrinsicHeight:()I:GetGetIntrinsicHeightHandler\n" +
			"n_setAlpha:(I)V:GetSetAlpha_IHandler\n" +
			"n_getOpacity:()I:GetGetOpacityHandler\n" +
			"n_setColorFilter:(Landroid/graphics/ColorFilter;)V:GetSetColorFilter_Landroid_graphics_ColorFilter_Handler\n" +
			"";
		mono.android.Runtime.register ("PorpoiseMobileApp.Droid.Helpers.CircularImageHelper, PorpoiseMobileApp.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", CircularImageHelper.class, __md_methods);
	}


	public CircularImageHelper () throws java.lang.Throwable
	{
		super ();
		if (getClass () == CircularImageHelper.class)
			mono.android.TypeManager.Activate ("PorpoiseMobileApp.Droid.Helpers.CircularImageHelper, PorpoiseMobileApp.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public CircularImageHelper (android.graphics.Bitmap p0) throws java.lang.Throwable
	{
		super ();
		if (getClass () == CircularImageHelper.class)
			mono.android.TypeManager.Activate ("PorpoiseMobileApp.Droid.Helpers.CircularImageHelper, PorpoiseMobileApp.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Graphics.Bitmap, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}


	public void draw (android.graphics.Canvas p0)
	{
		n_draw (p0);
	}

	private native void n_draw (android.graphics.Canvas p0);


	public void onBoundsChange (android.graphics.Rect p0)
	{
		n_onBoundsChange (p0);
	}

	private native void n_onBoundsChange (android.graphics.Rect p0);


	public int getIntrinsicWidth ()
	{
		return n_getIntrinsicWidth ();
	}

	private native int n_getIntrinsicWidth ();


	public int getIntrinsicHeight ()
	{
		return n_getIntrinsicHeight ();
	}

	private native int n_getIntrinsicHeight ();


	public void setAlpha (int p0)
	{
		n_setAlpha (p0);
	}

	private native void n_setAlpha (int p0);


	public int getOpacity ()
	{
		return n_getOpacity ();
	}

	private native int n_getOpacity ();


	public void setColorFilter (android.graphics.ColorFilter p0)
	{
		n_setColorFilter (p0);
	}

	private native void n_setColorFilter (android.graphics.ColorFilter p0);

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
