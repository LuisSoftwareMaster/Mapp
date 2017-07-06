using Newtonsoft.Json;
using PorpoiseMobileApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PorpoiseMobileApp.Client
{


	public class LoginResponseModel : ResponseModel<LoginPayload>
	{
		public Guid Token
		{
			get
			{
				return Payload.Token;
			}
		}

		public LoginResponseModel()
		{

		}

		public LoginResponseModel(bool successful) : base(successful)
		{
		}
		public LoginResponseModel(bool success, string message) : base(success)
		{

			this.Message = message;
		}
	}

	public class LoginPayload
	{

		[JsonProperty("token")]
		public Guid Token { get; set; }

        [JsonProperty("show_profile_tutorial")]
        public bool show_profile_tutorial;

        [JsonProperty("show_posting_tutorial")]
        public bool show_posting_tutorial;

		public string FirstName { get; set; }
		public string LastName { get; set; }

		[JsonProperty("company_uid")]
		public Guid CompanyId { get; set; }

		[JsonProperty("user_uid")]
		public Guid UserId { get; set; }

		[JsonProperty("photo_s3_url")]
		public string ProfilePicture { get; set; }

		public string City { get; set; }
		public string Province { get; set; }
		public string Country { get; set; }

		[JsonProperty("total_hours_given")]
		public double TotalHoursGiven { get; set; }
		public List<HourLog> Posts { get; set; }




	}
}
