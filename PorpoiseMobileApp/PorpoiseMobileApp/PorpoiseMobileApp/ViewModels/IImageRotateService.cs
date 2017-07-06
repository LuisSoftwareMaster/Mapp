using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PorpoiseMobileApp.ViewModels
{
    public interface IImageRotateService
    {
        // Stream Rotate(Stream image, bool clockwise, byte[] bytes = null);
        Task<Stream> Rotate(Stream image, bool clockwise, byte[] bytes = null, string photoUrl = null, int degrees = 0);
    }
}
