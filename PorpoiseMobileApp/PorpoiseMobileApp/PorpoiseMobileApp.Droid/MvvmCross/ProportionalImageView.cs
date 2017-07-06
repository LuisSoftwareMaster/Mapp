using Android.Content;
using Android.Graphics.Drawables;
using Android.Util;
using MvvmCross.Binding.Droid.Views;

namespace ProportionalImageView
{
	public class ProportionalImageView : MvxImageView
	{
		void Initialize()
		{
		}

		public ProportionalImageView(Context context) : base(context)
		{

			Initialize();
		}
		public ProportionalImageView(Context context, IAttributeSet attrs) : base(context, attrs)
		{
			Initialize();
		}

		public ProportionalImageView(Context context, IAttributeSet attrs, int defStyle) : base(context, attrs, defStyle)
		{
			Initialize();
		}


		protected override void OnMeasure(int widthMeasureSpec, int heightMeasureSpec)
		{
			Drawable d = Drawable;
			if (d != null)
			{
				int w = MeasureSpec.GetSize(widthMeasureSpec);
				int h = w * d.IntrinsicHeight / d.IntrinsicWidth;
				SetMeasuredDimension(w, h);
			}
			else base.OnMeasure(widthMeasureSpec, heightMeasureSpec);
		}
	}
}
