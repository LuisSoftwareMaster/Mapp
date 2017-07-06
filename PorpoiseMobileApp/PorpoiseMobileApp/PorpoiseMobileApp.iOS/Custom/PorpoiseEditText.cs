using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using CoreGraphics;

namespace PorpoiseMobileApp.iOS
{
	public partial class PorpoiseEditText : UITextField
    {
       
		public PorpoiseEditText (IntPtr handle) : base (handle)
		{
		}
        [Export("textFieldShouldReturn:")]
        public bool TextFieldShouldReturn(UITextField textView)
        {
            Console.WriteLine("SHOULD RETURN");
            textView.ResignFirstResponder();
            return true;
        }

        [Export("textFieldDidChange:")]
        public void MyTextViewChanged(UITextField textView)
        {
            Console.WriteLine("Text changed");  
        }

		public override string Text
		{
			get
			{
				return base.Text;
			}
			set
			{
				base.Text = value;
				if (TextChanged != null)
				{
					TextChanged(this, new EventArgs());
				}
			}
		}
		CGColor GetBorderColor(bool enabled){
			return enabled ? PorpoiseColors.WhiteTransparency.CGColor : PorpoiseColors.Grey.CGColor;
		}

		public override bool Enabled{
			get { 
				return base.Enabled;
			}
			set{ 
				base.Enabled = value;
				Configure ();
			}
		}

		private void Configure(){
			if (!_inverse) {
				this.Bordered (_bordered ? 1f : 0f, GetBorderColor (Enabled));
			} else {
				this.Bordered (0f, UIColor.Clear.CGColor);
			}
		}

		private bool _inverse;

		[Export("Inverse")]
		public bool Inverse{
			get{ 
				return _inverse;
			}
			set { 
				_inverse = value;
				Configure ();
			}
		}

		private bool _bordered = true;

		[Export("Bordered")]
		public bool Bordered{
			get{ 
				return _bordered;
			}
			set { 
				_bordered = value;
				Configure ();
			}
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

			var a = layoutManager.BoundingRectForGlyphRange(glyphRange,textContainer);

			return a;

		}

		public event EventHandler TextChanged;
	}

}
