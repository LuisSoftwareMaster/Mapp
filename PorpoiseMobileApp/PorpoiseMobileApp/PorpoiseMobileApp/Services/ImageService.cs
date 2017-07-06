using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon.S3.Model;
using Amazon.S3;
using Amazon.CognitoIdentity;
using Amazon.S3.Transfer;
using Amazon;
using System.Diagnostics;

namespace PorpoiseMobileApp.Services
{
    public class ImageService : IImageService
    {
        private IAmazonS3 _s3Client { get; set; }
		//production-mobileuploads
        private const string BUCKETNAME = "production-mobileuploads";
        private const string S3_IDENTITYPOOL = "us-east-1:aaf0322a-8436-4a51-8c12-64ddd80919a2";
        // private AmazonS3Client s3Client;
        private TransferUtility transferUtility;

        public ImageService()
        {
            CognitoAWSCredentials credentials = new CognitoAWSCredentials(
               S3_IDENTITYPOOL, // Your identity pool ID
                RegionEndpoint.USEast1 // Region
);
            _s3Client = new AmazonS3Client(credentials, RegionEndpoint.USEast1);

            transferUtility = new TransferUtility(_s3Client);
        }



        public async Task<PutObjectResponse> ProcessImage(string keyName, Stream fileContent)
		{
				PutObjectResponse response;
				var putRequest = new PutObjectRequest
				{
					BucketName = BUCKETNAME,
					Key = keyName,
					InputStream = fileContent,
					CannedACL = S3CannedACL.PublicReadWrite,
					ContentType = "image/jpeg"

				};
				response = await _s3Client.PutObjectAsync(putRequest);
				return response;

        	}

        public async Task<DeleteObjectResponse> RemoveImage(string keyName)
        {
            var deleteRequest = new DeleteObjectRequest
            {
                BucketName = BUCKETNAME,
                Key = keyName
            };

            DeleteObjectResponse response;
            response = await _s3Client.DeleteObjectAsync(deleteRequest);
            return response;

        }

        public async Task<string> CopyImage(string sourceKey, string destinationKey)
        {
            CopyObjectRequest request = new CopyObjectRequest()
            {
                SourceBucket = BUCKETNAME,
                SourceKey = sourceKey,
                DestinationBucket = BUCKETNAME,
                DestinationKey = destinationKey,
                CannedACL = S3CannedACL.PublicReadWrite
            };
            CopyObjectResponse response = await _s3Client.CopyObjectAsync(request);
            return string.Format("https://{0}.s3.amazonaws.com/{1}", BUCKETNAME, destinationKey);
        }

        public virtual async Task<Stream> DownloadImage(string keyName, bool webPost)
        {
            try
			{if (!webPost)
				{
					Debug.WriteLine("KEYNAME in S3 " + keyName);

					var request = new GetObjectRequest();
					request.BucketName = BUCKETNAME;
					request.Key = keyName;
					var response = await _s3Client.GetObjectAsync(request);
					return response.ResponseStream;
				}
			else{
				        Debug.WriteLine("WEBAPP POST KEYNAME: "+keyName);
					var request = new GetObjectRequest();
					request.BucketName = "porpoise-production";
					request.Key = keyName;
					var response = await _s3Client.GetObjectAsync(request);
					return response.ResponseStream;
			}
            }
			catch (Exception ex){
			throw;
            }
        }
    }
}
