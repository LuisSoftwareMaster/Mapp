using System;
using System.IO;
using System.Threading.Tasks;
using PorpoiseMobileApp.ViewModels;

namespace PorpoiseMobileApp.iOS
{
	public class DummyImageRotator : IImageRotateService
	{
		public DummyImageRotator()
		{
		}



		public async Task<Stream> Rotate(Stream image, bool clockwise, byte[] bytes = null, string photoUrl = null, int degrees = 0)
		{
			return image;
		}
	}
}

