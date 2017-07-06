using System;
using PorpoiseMobileApp.Models;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace PorpoiseMobileApp.Client
{
	public class CompanyResultModel
    {
        private List<Goal> _goals;
        private List<Organisation> _organisations;

        public Guid Id { get; set; }
        public string Name { get; set; }

        public List<Goal> Goals {
            get {

                if(_goals == null)
                {
                    _goals = new List<Goal>();
                }

                return _goals;

            }
            set
            {
               _goals = value;
            }
        }

        public List<Organisation> Organisations
        {
            get { 
                if(_organisations == null)
                {
                _organisations = new List<Organisation>();
            }

                return _organisations;

        }
        set
            {
                _organisations = value;
            }
}

        public string Result { get; set; }
        public bool Successful { get; set; }
        public string Message { get; set; }

        public CompanyResultModel()
        {

        }

        public CompanyResultModel(bool successful)
        {
            this.Successful = successful;
        }
        public CompanyResultModel(string result, CompanyPayload paylod, string message)
        {
            if (string.Equals(result, Resource.Success))
            {
                this.Successful = true;
            };

            if(paylod != null)
            {
                /*this.Name = paylod.Name;
                this.Id = Guid.Parse(paylod.CompanyId);
                this.Goals = paylod.Goals;
                this.Organisations = paylod.Organisations;*/
            }

            this.Message = message;
        }
    }

	public class CompanyPayload
	{
		[JsonProperty("firstname")]
		public string FirstName { get; set; }

		[JsonProperty("lastname")]
		public string LastName { get; set; }

		[JsonProperty("company_uid")]
		public Guid CompanyId { get; set; }

		[JsonProperty("user_uid")]
		public Guid UserId { get; set; }

		[JsonProperty("profile_picture")]
		public string ProfilePicture { get; set; }

		public string Location { get; set; }

		[JsonProperty("total_hours_invested")]
		public double TotalHoursGiven { get; set; }

		[JsonProperty("latest_post")]
		public HourLog LatestPost { get; set; }

		[JsonProperty("goals")]
		public List<Goal> Goals { get; set; }
	}
}

