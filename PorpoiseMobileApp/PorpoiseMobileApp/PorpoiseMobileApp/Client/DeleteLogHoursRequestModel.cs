using System;
using Newtonsoft.Json;

namespace PorpoiseMobileApp.Client
{
	public class DeleteLogHoursRequestModel
	{
		
		[JsonProperty("post_uid")]
		public Guid PostId { get; set; }


	}

}
