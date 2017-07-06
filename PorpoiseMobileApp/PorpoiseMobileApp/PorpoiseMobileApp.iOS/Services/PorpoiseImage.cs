using System;
using Foundation;
using UIKit;

namespace PorpoiseMobileApp.iOS.Services
{
    public static class PorpoiseImage
    {
        public static UIKit.UIImage getFromURL(string urlString){

			using (var url = new NSUrl(urlString))
			using (var data = NSData.FromUrl(url))
				return UIImage.LoadFromData(data);

        }

        public static string PorpoiseLogo = "https://s3.amazonaws.com/porpoise-mobile-assets/Image+1.png";

        public static nfloat getAppropriateWidth(UIImage image, nfloat newHeight){

            nfloat scale = image.Size.Height / image.Size.Width;

            Console.WriteLine("Scale "+scale+ " New Height "+newHeight);

            nfloat width = scale/newHeight;



            return (newHeight/scale);

        }

        public static UIImage resizeImage(UIImage image, nfloat newWidth)
        {


            nfloat scale = newWidth / image.Size.Width;

            nfloat newHeight = image.Size.Height * scale;
            image = image.Scale(new CoreGraphics.CGSize(newWidth,newHeight));
            UIGraphics.BeginImageContext(new CoreGraphics.CGSize(newWidth, newHeight));

            image.DrawAsPatternInRect(new CoreGraphics.CGRect(0, 0, newWidth, newHeight));

            UIImage newImage = UIGraphics.GetImageFromCurrentImageContext();

            UIGraphics.EndImageContext();

            return newImage;

        }
    }
}
