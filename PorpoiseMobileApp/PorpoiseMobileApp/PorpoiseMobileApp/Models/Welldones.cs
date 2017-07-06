using System;
using Newtonsoft.Json;
using PorpoiseMobileApp.Common;

namespace PorpoiseMobileApp.Models
{
	public class Welldones: IDataObject
	{
		public Welldones()
		{
		}

		public Guid? Id
		{
			get;
			set;
		}

		[JsonProperty("welldone_user_uid")]
		public string UserId {

			get;
			set;
		
		}

		[JsonProperty("welldone_creator_logo")]
		public string CreatorLogo 
		{

			get;
			set;

		}

		[JsonProperty("welldone_creator_name")]
		public string CreatorName {

			get;
			set;
		
		}


	}
}
