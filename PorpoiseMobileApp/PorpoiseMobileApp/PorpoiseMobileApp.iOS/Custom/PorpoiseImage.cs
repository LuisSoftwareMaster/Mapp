using System;
using UIKit;
using CoreGraphics;
namespace PorpoiseMobileApp.iOS.Custom
{
    public static class PorpoiseImage
    {
       
        public static UIImage correctlyOrientedImage(UIImage image) {
            if (image.Orientation == UIImageOrientation.Up) {
                return image;
	        }
            UIGraphics.BeginImageContextWithOptions(image.Size, false, image.CurrentScale);
            image.DrawAsPatternInRect(new CGRect(0, 0, image.Size.Width, image.Size.Height));


            UIImage normalizedImage = UIGraphics.GetImageFromCurrentImageContext();
            UIGraphics.EndImageContext();
            return normalizedImage;
        }

        public static UIImage resized(CGSize newSize, UIImage image) {

            nfloat scale = UIScreen.MainScreen.Scale;
			/*You can remove the below comment if you dont want to scale the image in retina   device .Dont forget to comment UIGraphicsBeginImageContextWithOptions*/
			UIGraphics.BeginImageContext(newSize);
			UIGraphics.BeginImageContextWithOptions(newSize, false, scale);

            image.DrawAsPatternInRect(new CGRect(0, 0, newSize.Width, newSize.Height));

	
            UIImage newImage = UIGraphics.GetImageFromCurrentImageContext();

	UIGraphics.EndImageContext();
    return newImage;

	    }

        public static UIImage resizeImage( UIImage image, nfloat newWidth) {

            nfloat scale = newWidth / image.Size.Width;

            nfloat newHeight = image.Size.Height * scale;

            UIGraphics.BeginImageContext(new CGSize(newWidth, newHeight));

            image.DrawAsPatternInRect(new CGRect(0, 0, newWidth, newHeight));
            var newImage = UIGraphics.GetImageFromCurrentImageContext();

            UIGraphics.EndImageContext();

            return newImage;
	}



    }
}
