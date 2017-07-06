using System;
using UIKit;
namespace PorpoiseMobileApp.iOS.Custom
{
    public class PorpoiseTableDelegate: UITableViewDelegate
    {
        public PorpoiseTableDelegate()
        {
        }

        public override void Scrolled(UIScrollView scrollView)
        {
            Console.WriteLine("SCROLLING");

            base.Scrolled(scrollView);
        }


    }
}
