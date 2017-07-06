using Foundation;
using System;
using UIKit;
using CoreGraphics;
using CoreAnimation;

namespace PorpoiseMobileApp.iOS
{
    public partial class PorpoiseView : UIView
    {
        public PorpoiseView (IntPtr handle) : base (handle)
        {
        }

        public void changeBackgroundImage(string image) {

            UIImage imageSource = new UIImage(image);
			UIColor color = UIColor.FromPatternImage(imageSource);

            this.BackgroundColor = UIColor.FromPatternImage(imageSource);
            
        }

        public void roundCorners(UIRectCorner corners, nfloat width, nfloat height)
        {

            UIBezierPath path = UIBezierPath.FromRoundedRect(this.Bounds, corners, new CoreGraphics.CGSize(width, height));

			CAShapeLayer maskLayer = new CAShapeLayer();

			maskLayer.Frame = this.Bounds;

			maskLayer.Path = path.CGPath;

			this.Layer.Mask = maskLayer;



		}
    }
}