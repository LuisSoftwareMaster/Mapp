package md509cda68e2f10998543bb184436f8d443;


public class RoundedImageView
	extends android.widget.ImageView
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_drawableStateChanged:()V:GetDrawableStateChangedHandler\n" +
			"n_getScaleType:()Landroid/widget/ImageView$ScaleType;:GetGetScaleTypeHandler\n" +
			"n_setScaleType:(Landroid/widget/ImageView$ScaleType;)V:GetSetScaleType_Landroid_widget_ImageView_ScaleType_Handler\n" +
			"n_setImageDrawable:(Landroid/graphics/drawable/Drawable;)V:GetSetImageDrawable_Landroid_graphics_drawable_Drawable_Handler\n" +
			"n_setImageBitmap:(Landroid/graphics/Bitmap;)V:GetSetImageBitmap_Landroid_graphics_Bitmap_Handler\n" +
			"n_setImageResource:(I)V:GetSetImageResource_IHandler\n" +
			"n_setImageURI:(Landroid/net/Uri;)V:GetSetImageURI_Landroid_net_Uri_Handler\n" +
			"n_getBackground:()Landroid/graphics/drawable/Drawable;:GetGetBackgroundHandler\n" +
			"n_setBackground:(Landroid/graphics/drawable/Drawable;)V:GetSetBackground_Landroid_graphics_drawable_Drawable_Handler\n" +
			"n_setColorFilter:(Landroid/graphics/ColorFilter;)V:GetSetColorFilter_Landroid_graphics_ColorFilter_Handler\n" +
			"n_setBackgroundDrawable:(Landroid/graphics/drawable/Drawable;)V:GetSetBackgroundDrawable_Landroid_graphics_drawable_Drawable_Handler\n" +
			"";
		mono.android.Runtime.register ("RoundedImageView.RoundedImageView, PorpoiseMobileApp.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", RoundedImageView.class, __md_methods);
	}


	public RoundedImageView (android.content.Context p0) throws java.lang.Throwable
	{
		super (p0);
		if (getClass () == RoundedImageView.class)
			mono.android.TypeManager.Activate ("RoundedImageView.RoundedImageView, PorpoiseMobileApp.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}


	public RoundedImageView (android.content.Context p0, android.util.AttributeSet p1) throws java.lang.Throwable
	{
		super (p0, p1);
		if (getClass () == RoundedImageView.class)
			mono.android.TypeManager.Activate ("RoundedImageView.RoundedImageView, PorpoiseMobileApp.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Util.IAttributeSet, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0, p1 });
	}


	public RoundedImageView (android.content.Context p0, android.util.AttributeSet p1, int p2) throws java.lang.Throwable
	{
		super (p0, p1, p2);
		if (getClass () == RoundedImageView.class)
			mono.android.TypeManager.Activate ("RoundedImageView.RoundedImageView, PorpoiseMobileApp.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Util.IAttributeSet, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:System.Int32, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public RoundedImageView (android.content.Context p0, android.util.AttributeSet p1, int p2, int p3) throws java.lang.Throwable
	{
		super (p0, p1, p2, p3);
		if (getClass () == RoundedImageView.class)
			mono.android.TypeManager.Activate ("RoundedImageView.RoundedImageView, PorpoiseMobileApp.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Util.IAttributeSet, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:System.Int32, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e:System.Int32, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new java.lang.Object[] { p0, p1, p2, p3 });
	}


	public void drawableStateChanged ()
	{
		n_drawableStateChanged ();
	}

	private native void n_drawableStateChanged ();


	public android.widget.ImageView.ScaleType getScaleType ()
	{
		return n_getScaleType ();
	}

	private native android.widget.ImageView.ScaleType n_getScaleType ();


	public void setScaleType (android.widget.ImageView.ScaleType p0)
	{
		n_setScaleType (p0);
	}

	private native void n_setScaleType (android.widget.ImageView.ScaleType p0);


	public void setImageDrawable (android.graphics.drawable.Drawable p0)
	{
		n_setImageDrawable (p0);
	}

	private native void n_setImageDrawable (android.graphics.drawable.Drawable p0);


	public void setImageBitmap (android.graphics.Bitmap p0)
	{
		n_setImageBitmap (p0);
	}

	private native void n_setImageBitmap (android.graphics.Bitmap p0);


	public void setImageResource (int p0)
	{
		n_setImageResource (p0);
	}

	private native void n_setImageResource (int p0);


	public void setImageURI (android.net.Uri p0)
	{
		n_setImageURI (p0);
	}

	private native void n_setImageURI (android.net.Uri p0);


	public android.graphics.drawable.Drawable getBackground ()
	{
		return n_getBackground ();
	}

	private native android.graphics.drawable.Drawable n_getBackground ();


	public void setBackground (android.graphics.drawable.Drawable p0)
	{
		n_setBackground (p0);
	}

	private native void n_setBackground (android.graphics.drawable.Drawable p0);


	public void setColorFilter (android.graphics.ColorFilter p0)
	{
		n_setColorFilter (p0);
	}

	private native void n_setColorFilter (android.graphics.ColorFilter p0);


	public void setBackgroundDrawable (android.graphics.drawable.Drawable p0)
	{
		n_setBackgroundDrawable (p0);
	}

	private native void n_setBackgroundDrawable (android.graphics.drawable.Drawable p0);

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
