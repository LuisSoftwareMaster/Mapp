using Foundation;
using System;
using UIKit;
using CoreGraphics;

namespace PorpoiseMobileApp.iOS
{
    public partial class PorpoiseLabel : UILabel
    {
        public PorpoiseLabel (IntPtr handle) : base (handle)
        {
        }

		public void resizeLabel()
		{

			UIFont font = this.Font;

			float width = (float)this.Bounds.Width;

			string text = this.Text;

			this.Frame = new CGRect(this.Bounds.X, this.Bounds.Y, this.Bounds.Width, this.heightForLabel(font, width, text)*2);

		}

		private nfloat heightForLabel(UIFont font, float width, string text)
		{

			UILabel label = new UILabel();

			label.Frame = new CGRect(0, 0, width, float.MaxValue);

			label.Lines = 0;

			label.LineBreakMode = UILineBreakMode.WordWrap;

			label.Font = font;

			label.Text = text;

			label.SizeToFit();



			return label.Frame.Height;

		}

		public static nfloat heightForLabelGlobal(UIFont font, float width, string text)
		{

			UILabel label = new UILabel();

			label.Frame = new CGRect(0, 0, width, float.MaxValue);

			label.Lines = 0;

			label.LineBreakMode = UILineBreakMode.WordWrap;

			label.Font = font;

			label.Text = text;

			label.SizeToFit();



			return label.Frame.Height;

		}

		public CGRect boundingRectForCharacter(NSRange range)
		{

			NSTextStorage textStorage = new NSTextStorage();

			textStorage.SetString(this.AttributedText);

			NSLayoutManager layoutManager = new NSLayoutManager();

			textStorage.AddLayoutManager(layoutManager);

			NSTextContainer textContainer = new NSTextContainer(this.Bounds.Size);

			textContainer.LineFragmentPadding = 0f;

			layoutManager.AddTextContainer(textContainer);

			NSRange glyphRange;

			glyphRange = layoutManager.CharacterRangeForGlyphRange(range);

			return layoutManager.BoundingRectForGlyphRange(glyphRange, textContainer);


				}
    }
}