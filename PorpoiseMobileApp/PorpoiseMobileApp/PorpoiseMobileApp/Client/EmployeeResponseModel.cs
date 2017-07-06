using Newtonsoft.Json;
using PorpoiseMobileApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PorpoiseMobileApp.Client
{

	public class EmployeeResponseModel : ResponseModel<EmployeePayload>
	{

		public Guid? UserId
		{
			get
			{
				return Payload.UserId;
			}
		}

		public string LastName
		{
			get
			{
				//new null check with VS2015
				return Payload.LastName;
			}
		}

		public string FirstName
		{
			get
			{
				return Payload.FirstName;
			}
		}

		public Guid CompanyId
		{
			get
			{
				return Payload.CompanyId;
			}
		}

		public string ProfilePicture
		{
			get
			{
				return Payload.ProfilePicture;
			}
		}

		public string Location
		{
			get
			{
				return Payload.Location;
			}
		}

		public double TotalHoursGiven
		{
			get
			{
				return Payload.TotalHoursGiven;
			}
		}

		public HourLog LatestPost
		{
			get
			{
				return Payload.LatestPost;
			}
		}

		public List<Goal> CompanyGoals
		{
			get
			{
				return Payload.Goals;
			}
		}

		public EmployeeResponseModel()
		{

		}

		public EmployeeResponseModel(bool successful) : base(successful)
		{
		}
	}

	public class EmployeePayload
	{
		[JsonProperty("firstname")]
		public string FirstName { get; set; }

		[JsonProperty("lastname")]
		public string LastName { get; set; }

		[JsonProperty("company_uid")]
		public Guid CompanyId { get; set; }

		[JsonProperty("user_uid")]
		public Guid UserId { get; set; }

        [JsonProperty("employee_uid")]
        public Guid EmployeeUid { get; set; }

		[JsonProperty("profile_picture")]
		public string ProfilePicture { get; set; }

		public string Location { get; set; }

		[JsonProperty("total_hours_invested")]
		public double TotalHoursGiven { get; set; }

		[JsonProperty("latest_post")]
		public HourLog LatestPost { get; set; }

		[JsonProperty("goals")]
		public List<Goal> Goals { get; set; }

		[JsonProperty("company_name")]
		public string CompanyName { get; set; }
        [JsonProperty("total_contribution_amount_invested")]
        public double totalContributionAmountInvested { get; set; }
	}
}
