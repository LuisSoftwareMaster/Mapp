using Newtonsoft.Json;
using PorpoiseMobileApp.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using MvvmCross.Core.ViewModels;

namespace PorpoiseMobileApp.Models
{
    public class Goal : MvxNotifyPropertyChanged ,IDataObject
    {
        [JsonProperty("goal_uid")]
        public Guid? Id { get; set; }

        [JsonProperty("goal_metric")]
        public string MetricName { get; set; }



        [JsonProperty("other_goal_metric_label")]
        public string otherGoalMetricLabel { get; set; }

        [JsonProperty("goal_name")]
        public string Name { get; set; }

        [JsonProperty("organization_required_to_post")]
        public bool? IsRequired { get; set; }

        [JsonIgnore]
        public double HoursToAchieve { get; set; }

        [JsonProperty("goal_hours")]
        public double Hours { get; set; }

        [JsonProperty("goal_amount")]
        public double GoalAmount { get; set; }

        [JsonProperty("goal_type")]
        public string GoalType { get; set; }

        [JsonProperty("challenge_type")]
        public string ChallengeType { get; set; }

		[JsonProperty("current_investment")]
		public double hoursAgainstGoal;
        [JsonProperty("goal_cumulative_total")]
        public double GoalAcumulativeTotal;

        [JsonIgnore]
        public bool isEmpty { get; set; }

        [JsonProperty("goal_gift")]
        public string GiftName { get; set; }

        [JsonProperty("goal_is_active")]
        public bool Active { get; set; }

        [JsonProperty("goal_description")]
        public string Description { get; set; }
        public override string ToString()
        {
            return Name;
        }

        [JsonProperty("end_date")]
        public string EndDate{

            get;set;

        }

		public double HoursAgainstGoal { 
		
			get {

				return this.hoursAgainstGoal;

			}
			set {

				this.hoursAgainstGoal = value;

				RaisePropertyChanged(() => HoursAgainstGoal);

			}
		
		}


    }
}
