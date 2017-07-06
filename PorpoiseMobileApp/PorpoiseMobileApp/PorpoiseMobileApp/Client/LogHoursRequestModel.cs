using Newtonsoft.Json;
using PorpoiseMobileApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PorpoiseMobileApp.Client
{
	public class LogHoursRequestModel
	{
		[JsonProperty("post_uid")]
		public Guid PostId { get; set; }

		[JsonProperty("post_hours")]
		public double NumberOfHours { get; set; }
		[JsonProperty("post_contribution_amount")]
		public double PostContributionAmount {

			get;set;
		
		}

		[JsonProperty("post_date")]
		public DateTime Date { get; set; }

		[JsonProperty("post_organization")]
		public string OrganisationName { get; set; }

		[JsonProperty("post_goal_uid")]
		public Guid GoalId { get; set; }

		[JsonProperty("post_highlight")]
		public string Highlight { get; set; }

		[JsonProperty("post_photo_s3_url")]
		public string PhotoS3Url { get; set; }

		[JsonProperty("post_photo_file_name")]
		public string FileName { get; set; }

		[JsonProperty("post_photo_content_type")]
		public string PhotoContentType { get; set; }

		[JsonProperty("post_photo_file_size")]
		public string PhotoFileSize { get; set; }

		[JsonProperty("post_photo_updated_at")]
		public DateTime PhotoUpdatedTime { get; set; }
        [JsonProperty("allow_social_share")]
        public bool AllowSocialShare{get;set; } 

	}

}
