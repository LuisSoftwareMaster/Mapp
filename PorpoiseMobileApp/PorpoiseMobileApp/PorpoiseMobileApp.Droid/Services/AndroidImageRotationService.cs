using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using PorpoiseMobileApp.ViewModels;
using Android.Graphics;
using Android.Util;
using PorpoiseMobileApp.Client;
using Java.IO;
using Java.Net;
using UniversalImageLoader.Core;
using System.Threading.Tasks;
using Android.Views.Animations;

namespace PorpoiseMobileApp.Droid.Services
{
    public class AndroidImageRotationService : IImageRotateService
    {
        private ImageLoader loader;

        public AndroidImageRotationService()
        {

        }



        public async Task<Stream> Rotate(Stream image, bool clockwise, byte[] bytes = null, string imageUrl = null, int degrees = 0)
        {
           
            if (image != null)
            {
                try
                {
                    bool isNewImage = false;                              
                    this.loader = ImageLoader.Instance;
                    Bitmap bitmap = await Task.Run(() => loader.LoadImageSync(imageUrl));
                    if(bitmap == null)
                    {
                        using (MemoryStream mStream = new MemoryStream())
                        {
                            mStream.Write(bytes, 0, bytes.Length);
                            mStream.Seek(0, SeekOrigin.Begin);

                            bitmap= await Task.Run(() => BitmapFactory.DecodeStreamAsync(mStream));
                            isNewImage = true;
                        }
                    }
                    if (bitmap != null)
                    {
                        if (isNewImage)
                        {
                            degrees = clockwise ? 90 : -90;
                        }
                        var targetWidth = bitmap.Height;
                        var targetHeight = bitmap.Width;

                        Bitmap targetBitmap = Bitmap.CreateBitmap(targetWidth, targetHeight, bitmap.GetConfig());
                        Matrix matrix = new Matrix();
                        
                        //center the source image
                        matrix.SetTranslate(-bitmap.Width / 2, -bitmap.Height / 2);

                        //rotate the image
                        matrix.PostRotate(degrees);
                        //now move it to the center of your final image
                        matrix.PostTranslate(targetBitmap.Width / 2, targetBitmap.Height / 2);

                        //now draw the image
                        var rotated = Bitmap.CreateBitmap(bitmap, 0, 0, bitmap.Width, bitmap.Height, matrix, true);
                        MemoryStream ms = new MemoryStream();
                        rotated.Compress(Bitmap.CompressFormat.Png, 100, ms);
                        ms.Seek(0, SeekOrigin.Begin);                       
                        return ms;
                    }
                    else
                    {
                        throw new PorpoiseException("The image is too large to rotate. Please try uploading another image or editing your image outside of Porpoise and try uploading it again.");
                    }

                }
                catch (Exception ex)
                {


                }

            }
            return image;


        }




    }
}