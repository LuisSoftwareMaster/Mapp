using System;
using UIKit;
using CoreGraphics;

namespace PorpoiseMobileApp.iOS
{
	internal static class PorpoiseColors
	{
		public static readonly UIColor Turquoise = UIColor.FromRGB(65, 193, 201);
		public static readonly UIColor Pink = UIColor.FromRGB(239, 82, 133);
		public static readonly UIColor Grey = UIColor.FromRGB(211, 211, 211);
		public static readonly UIColor DarkGrey = UIColor.FromRGB(172, 172, 172);
		public static readonly UIColor NewDark = UIColor.FromRGB(109,109,109);
		public static readonly UIColor companyNameLocationLabel = UIColor.FromRGB(139, 139, 139);
		public static readonly UIColor lightGrey = UIColor.FromRGB(220, 220, 220);
		public static readonly UIColor WhiteTransparency = UIColor.FromRGBA(255, 255, 255, 0.8f);
		public static readonly UIColor LightErrorRed = UIColor.FromRGB(252, 133, 133);
		public static readonly UIColor ErrorBoldRed = UIColor.FromRGB(239, 74, 74);
		public static readonly UIColor Golden = UIColor.FromRGB(255, 212, 63);
		public static readonly UIColor DarkTurquoise = UIColor.FromRGB(34, 165, 168);
		public static readonly UIColor Orange = UIColor.FromRGB(225, 100, 33);
		public static readonly UIColor LogPhotoHeader = UIColor.FromRGB(240, 148, 148);
		public static readonly UIColor LightGrey = UIColor.FromRGB(238, 238, 238);

		public static readonly UIColor LogPostGalleryHeader = UIColor.FromRGB(255,204,204);
		//primary = turquoise  
		//darker prime = dark turquoise
		//lighter prime= light turquoise
		//accent colour = porpoise pink
		//darker accent = darker porpoise pink
		//lighter accent = lighter porppise pink
		//error red = pastel red

		public static UIColor FromHex(int hexValue)
		{
			return UIColor.FromRGB(
				(((float)((hexValue & 0xFF0000) >> 16)) / 255.0f),
				(((float)((hexValue & 0xFF00) >> 8)) / 255.0f),
				(((float)(hexValue & 0xFF)) / 255.0f)
			);
		}
	}
}

