package md509cda68e2f10998543bb184436f8d443;


public class RoundedDrawable
	extends android.graphics.drawable.Drawable
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_isStateful:()Z:GetIsStatefulHandler\n" +
			"n_onStateChange:([I)Z:GetOnStateChange_arrayIHandler\n" +
			"n_onBoundsChange:(Landroid/graphics/Rect;)V:GetOnBoundsChange_Landroid_graphics_Rect_Handler\n" +
			"n_draw:(Landroid/graphics/Canvas;)V:GetDraw_Landroid_graphics_Canvas_Handler\n" +
			"n_getOpacity:()I:GetGetOpacityHandler\n" +
			"n_getAlpha:()I:GetGetAlphaHandler\n" +
			"n_setAlpha:(I)V:GetSetAlpha_IHandler\n" +
			"n_getColorFilter:()Landroid/graphics/ColorFilter;:GetGetColorFilterHandler\n" +
			"n_setColorFilter:(Landroid/graphics/ColorFilter;)V:GetSetColorFilter_Landroid_graphics_ColorFilter_Handler\n" +
			"n_setDither:(Z)V:GetSetDither_ZHandler\n" +
			"n_setFilterBitmap:(Z)V:GetSetFilterBitmap_ZHandler\n" +
			"n_getIntrinsicWidth:()I:GetGetIntrinsicWidthHandler\n" +
			"n_getIntrinsicHeight:()I:GetGetIntrinsicHeightHandler\n" +
			"";
		mono.android.Runtime.register ("RoundedImageView.RoundedDrawable, PorpoiseMobileApp.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", RoundedDrawable.class, __md_methods);
	}


	public RoundedDrawable () throws java.lang.Throwable
	{
		super ();
		if (getClass () == RoundedDrawable.class)
			mono.android.TypeManager.Activate ("RoundedImageView.RoundedDrawable, PorpoiseMobileApp.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public RoundedDrawable (android.graphics.Bitmap p0) throws java.lang.Throwable
	{
		super ();
		if (getClass () == RoundedDrawable.class)
			mono.android.TypeManager.Activate ("RoundedImageView.RoundedDrawable, PorpoiseMobileApp.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Graphics.Bitmap, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}


	public boolean isStateful ()
	{
		return n_isStateful ();
	}

	private native boolean n_isStateful ();


	public boolean onStateChange (int[] p0)
	{
		return n_onStateChange (p0);
	}

	private native boolean n_onStateChange (int[] p0);


	public void onBoundsChange (android.graphics.Rect p0)
	{
		n_onBoundsChange (p0);
	}

	private native void n_onBoundsChange (android.graphics.Rect p0);


	public void draw (android.graphics.Canvas p0)
	{
		n_draw (p0);
	}

	private native void n_draw (android.graphics.Canvas p0);


	public int getOpacity ()
	{
		return n_getOpacity ();
	}

	private native int n_getOpacity ();


	public int getAlpha ()
	{
		return n_getAlpha ();
	}

	private native int n_getAlpha ();


	public void setAlpha (int p0)
	{
		n_setAlpha (p0);
	}

	private native void n_setAlpha (int p0);


	public android.graphics.ColorFilter getColorFilter ()
	{
		return n_getColorFilter ();
	}

	private native android.graphics.ColorFilter n_getColorFilter ();


	public void setColorFilter (android.graphics.ColorFilter p0)
	{
		n_setColorFilter (p0);
	}

	private native void n_setColorFilter (android.graphics.ColorFilter p0);


	public void setDither (boolean p0)
	{
		n_setDither (p0);
	}

	private native void n_setDither (boolean p0);


	public void setFilterBitmap (boolean p0)
	{
		n_setFilterBitmap (p0);
	}

	private native void n_setFilterBitmap (boolean p0);


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
