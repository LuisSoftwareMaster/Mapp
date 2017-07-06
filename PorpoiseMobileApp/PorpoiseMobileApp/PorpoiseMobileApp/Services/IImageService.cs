using Amazon.S3.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PorpoiseMobileApp.Services
{
	public interface IImageService
	{

		Task<PutObjectResponse> ProcessImage(string keyName, Stream fileContent);
		Task<DeleteObjectResponse> RemoveImage(string keyName);
		Task<string> CopyImage(string sourceKey, string destinationKey);

		Task<Stream> DownloadImage(string keyName, bool webPost);

    }
}
