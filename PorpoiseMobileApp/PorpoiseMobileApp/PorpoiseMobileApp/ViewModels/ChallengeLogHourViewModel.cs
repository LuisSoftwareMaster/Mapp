using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Acr.Settings;
using MvvmCross.Core.ViewModels;
using PorpoiseMobileApp.Client;

namespace PorpoiseMobileApp.ViewModels
{
	public class ChallengeLogHourViewModel : PorpoiseViewModel<ChallengeLogHourViewModel>
	{

		private bool _inFlight;

		private IPorpoiseWebApiClient client;
		private ISettings _settings;

		private IMvxCommand _backCommand;

		private List<Models.Goal> _goals;

		private Models.Goal _goal;

        private List<Models.Goal> goalList;

        private IMvxCommand _cancelCommand;

        public IMvxCommand CancelCommand{

            get{

                _cancelCommand = new MvxCommand(Cancel);

                return _cancelCommand;

            }

        }

        void Cancel(){

            ShowViewModel<HomeViewModel>();

        }

		public Models.Goal Goal { 
		
			get {
				return _goal;
			}
			set {
				_goal = value;
			
			}
		
		}

		public IMvxCommand BackCommand
		{

			get
			{
				_backCommand = _backCommand ?? new MvxCommand(this.Back);
				return _backCommand;

			}

		}

		public async void Init(EditParameters editParams)
		{
			await this.LoadChallenges("");
			LogPost.goal = null;
		
		}

		private void Back() {

            if (this.Goal != null)
            {
                var param = new System.Collections.Generic.Dictionary<string, string>();

                param.Add("goal", Goal.Id.Value.ToString());

                ShowViewModel<LogHourPhotoViewModel>(param);
            }
		}


		public List<Models.Goal> Goals { 
		
			get {

				if (_goals != null)
				{
					return _goals;
				}
				else
				{
					return new List<Models.Goal>();
				}

			}
			set {

				_goals = value;
				RaisePropertyChanged(() => Goals);

			}
		
		}

		public async Task LoadChallenges(string search) {

            if (goalList == null)
            {
                var list = await client.GetCompanyGoals();

                if(list != null && list.Successful){

                    goalList = list.Goals;

                    int temporaryIndex = 0;

                    if(this.GoalId != null){

                        for (int i = 0; i < goalList.Count; i++){

                            if(goalList[i].Id.Value.Equals(GoalId)){

                                temporaryIndex = i;

                                break;

                            }

                        }

                    }

                    Models.Goal aux = goalList[0];

                    goalList[0] = goalList[temporaryIndex];

                    goalList[temporaryIndex] = aux;

                }

            }



				if (search == null || search.Equals(""))
				{

                Goals = goalList;
					Debug.WriteLine("LOADING CHALLENGES IN VIEW MODEL " + Goals.Count);
				}
				else {

					Goals = new List<Models.Goal>();

					foreach (Models.Goal goal in goalList) {

						if (goal.Name.ToLower().Contains(search.ToLower())) {

							Goals.Add(goal);

						}
					
					}
				
				}

			
		
		}

		public bool InFlight
		{
			get
			{
				return _inFlight;
			}
			set
			{
				_inFlight = value;
				RaisePropertyChanged(() => InFlight);
			}
		}

		public  void navigateLogPostOrganisation() {

			if (Goal != null)
			{
				LogPost.goal = this.Goal;

				LogPost.action = "add";

				

			}
		
		}

        private Guid goalId;

        public Guid GoalId{

            get{

                return goalId;

            }

            set{

                goalId = value;

                RaisePropertyChanged(() => GoalId);

            }

        }




        protected override void InitFromBundle(IMvxBundle parameters)
        {
            if(parameters.Data.ContainsKey("goal")){

                goalId = Guid.Parse(parameters.Data["goal"]);

                Debug.WriteLine("GOALNAME: "+goalId.ToString());

            }

            base.InitFromBundle(parameters);
        }

		public  ChallengeLogHourViewModel(IPorpoiseWebApiClient client, ISettings settings) : base()
		{
			this.client = client;
			this._settings = settings;
			//this.LoadChallenges();
		}


	}
}
