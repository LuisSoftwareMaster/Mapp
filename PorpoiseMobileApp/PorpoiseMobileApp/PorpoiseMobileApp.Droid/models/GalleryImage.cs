using System;
namespace PorpoiseMobileApp.Droid.models
{
    public class GalleryImage
    {
        public GalleryImage()
        {
        }

		public GalleryImage(string Thumbnail, string Image, string Caption)
		{
            this.Thumbnail = Thumbnail;

            this.Image = Image;

            this.Caption = Caption;

		}

        private string Thumbnail { get; set; }

        private string Image { get; set; }

        private string Caption { get; set; }
    }
}
