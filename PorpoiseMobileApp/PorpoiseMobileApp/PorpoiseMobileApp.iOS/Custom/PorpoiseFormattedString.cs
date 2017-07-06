using System;
using UIKit;
using Foundation;

namespace PorpoiseMobileApp.iOS
{
    public class PorpoiseFormattedString: NSMutableAttributedString
    {
        public PorpoiseFormattedString(): base()
        {
        }

        public NSMutableAttributedString normal(NSString text){

            NSAttributedString normal = new NSAttributedString(text);

            this.Append(normal);

            return this;

        }
    }
}
