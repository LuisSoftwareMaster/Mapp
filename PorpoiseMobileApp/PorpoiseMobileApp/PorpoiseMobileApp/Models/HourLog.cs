using Newtonsoft.Json;
using PorpoiseMobileApp.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using System.Runtime.Serialization;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using PorpoiseMobileApp.Client;
using PorpoiseMobileApp.ViewModels;
using System.Diagnostics;
using Acr.Settings;

namespace PorpoiseMobileApp.Models
{
	public class HourLog : MvxViewModel,IDataObject
	{
		private Organisation _organisation;
		private Goal _goal;
		private string _dateString;
		private DateTime? _date;



		MvxCommand _editLogCommand;

		MvxCommand _deletePostCommand;

		MvxCommand _giveWelldoneCommand;

        MvxCommand _dotCommand;

		[JsonProperty("post_uid")]
		public Guid? Id { get; set; }



		[JsonProperty("poster_name")]
		public string EmployeeName { get; set; }

		[JsonProperty("post_hours")]
		public double ?NumberOfHours { get; set; }
		[JsonProperty("post_contribution_amount")]
		public double? ContributionAmount { get; set; }

		[JsonProperty("post_highlight")]
		public string Highlight { get; set; }

		[JsonProperty("goal_uid")]
		public Guid? GoalUid { get; set; }

		//TODO: need full organisation since its a dropdown and needs to have an ID and a Name
		//same for goal
		[JsonProperty("post_org")]
		public string OrganisationName { get; set; }

		[JsonIgnore]
		public Organisation Organisation { get; set; }

		[JsonProperty("goal_name")]
		public string GoalName { get; set; }

		[JsonProperty("other_goal_metric_label")]
		public string otherGoalMetricLabel { get; set; }


		[JsonProperty("goal_metric")]
		public string GoalMetric { get; set; }

		[JsonProperty("total_hours_against_goal")]
		public double HoursAgainstGoal { get; set; }

		[JsonProperty("post_well_dones_array")]
		Welldones[] _welldones;

		private IPorpoiseWebApiClient client;
		private ISettings _settings;
		public HourLog(IPorpoiseWebApiClient client, ISettings settings) : base()
		{
			this.client = client;
			this._settings = settings;
		}

		public Welldones[] WellDones
		{

			get
			{

				Debug.WriteLine("RETURNING WELLDONES "+_welldones.Length);

				return _welldones;

			}

			set
			{

					_welldones = value;

					Debug.WriteLine("New Value for Welldones "+_welldones.Length);


					RaisePropertyChanged(() => WellDones);

			}

		}

		private event EventHandler<SdkEventArgs> _editPostEvent;

		public event EventHandler<SdkEventArgs> EditPostEvent
		{
			add
			{
				_editPostEvent += value;
			}
			remove
			{
				_editPostEvent -= value;
			}
		}

		[JsonIgnore]
		public Goal Goal { get; set; }

		[JsonProperty("post_photo")]
		//path to the uploaded photo
		public string PhotoUrl { get; set; }

		[JsonProperty("post_type")]
		public string PostType { get; set; }



		[JsonProperty("date")]
		public string DateString
		{
			get
			{
				return _dateString;
			}
			set
			{
				this._dateString = value;
			}
		}

		[JsonIgnore]
		public DateTime? Date
		{
			get
			{
				if (string.IsNullOrEmpty(DateString))
				{
					return new DateTime();
				}
				return DateTime.Parse(DateString);
			}
			set
			{
				this._date = value;
			}
		}




		[JsonProperty("post_location")]
		public string Location { get; set; }

		[JsonProperty("company_name")]
		public string CompanyName { get; set; }
		[JsonProperty("company_logo")]
		public String CompanyLogo { get; set; }

		//TODO: NEED CLARIFICATION ON PROPERTY TYPES AND WHAT THEIR USE IS
		[JsonProperty("poster_uid")]
		public string PosterId { get; set; }

		[JsonProperty("post_published")]
		public string Published { get; set; }

		[JsonProperty("post_sticky")]
		public string PostSticky { get; set; }


		[JsonProperty("post_media_type")]
		public string MediaType { get; set; }

		[JsonProperty("post_youtube_video_thumbnail")]
		public string VideoThumbnail { get; set; }


		[JsonProperty("post_youtube_video_link")]
		public string VideoUrl { get; set; }

		[JsonProperty("post_highlight_background_color")]
		public string BackgroundColor {

			get;
			set;
		
		}


		[JsonProperty("poster_profile_pic")]
		public string ProfileImage
		{

			get;

			set;

		}

		[JsonIgnore]
		public EmployeeResponseModel Employee
		{

			get;

			set;

		}

		[JsonProperty("post_goal_is_active")]
		public bool GoalIsActive { get; set; }


		//Paste here post array

		public Action<Guid> OnEdit;
		//Delete post ID
		public Action<Guid> OnDelete;

		public Action<Guid> OnGiveWellDone;

        public Action<Guid> OnDot;


		public IMvxCommand DeletePostCommand
		{

			get
			{
                Debug.WriteLine("Executing delete command");
				return _deletePostCommand ?? (_deletePostCommand = new MvxCommand(DeletePost));

			}

		}

		public IMvxCommand GiveWellDoneCommand
		{

			get
			{
				Debug.WriteLine("EXECUTING BINDING");

				return _giveWelldoneCommand ?? (_giveWelldoneCommand = new MvxCommand(GiveWelldone));

			}
			 
		}

        public IMvxCommand DotCommand{

            get{
                Debug.WriteLine("Executing dot command "+this.Id.Value);
                return _dotCommand ?? (_dotCommand = new MvxCommand(Dot));

            }

        }

		void GiveWelldone()
		{

			if (OnGiveWellDone != null)
			{

				OnGiveWellDone(this.Id.Value);

			}

		}

        void Dot(){

            if (OnDot != null)
			{

                OnDot(this.Id.Value);

			}

        }


		void DeletePost()
		{

			if (OnDelete != null)
			{

				OnDelete(this.Id.Value);

			}

		}


		public IMvxCommand GoEditLogCommand
		{
			get

			{
				return _editLogCommand ?? (_editLogCommand = new MvxCommand(Edit));
			}
		}



		void Edit()
		{
			if (OnEdit != null)
			{
				OnEdit(this.Id.Value);
			}
		}

		public bool CanEdit
		{

			get
			{
				return this.GoalIsActive;
			}
		}

		public static explicit operator HourLog(Type v)
		{
			throw new NotImplementedException();
		}
	}

	}


	public class HourLogDeleteEventArgs : EventArgs
	{

		public Guid PostId
		{

			get;

			set;

		}

	}

	public class HourLogEditEventArgs : EventArgs
	{
		public Guid PostId
		{
			get;
			set;
		}
	}



