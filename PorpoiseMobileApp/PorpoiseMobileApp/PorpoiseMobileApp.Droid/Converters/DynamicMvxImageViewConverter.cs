using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmCross.Platform.Converters;
using MvvmCross.Binding.Droid.Views;

namespace PorpoiseMobileApp.Droid.Converters
{
    public class DynamicMvxImageViewConverter : IMvxValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var image = value as MvxImageView;
            if(image != null)
            {
                var widthMeasureSpec = image.MeasuredWidth;
                var heightMeasureSpec = image.MeasuredHeight;
                var width = Android.Views.View.MeasureSpec.GetSize(widthMeasureSpec);
                var height =(int) Math.Ceiling(width * (float)image.Drawable.IntrinsicHeight / (float)image.Drawable.IntrinsicWidth);
                var canvas = new Android.Graphics.Canvas();
                canvas.SetViewport(width, height);;
                image.Drawable.Draw(canvas);
                return image;
            }
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}