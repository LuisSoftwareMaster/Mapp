using PorpoiseMobileApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PorpoiseMobileApp
{
	public class SdkEventArgs : EventArgs
	{
		public SdkEventArgs(bool successfull, string message = "")
		{
			this.Successful = successfull;
			this.Message = message;
		}

		public bool Successful { get; set; }

		public string Message { get; set; }
	}

	public class EditLogPostEventArgs : EventArgs

	{

		public EditLogPostEventArgs(Guid postId)
		{
			this.PostId = postId;

		}

		public Guid PostId
		{
			get;
			set;
		}
	}

    public class GoalClickEventArgs : EventArgs
    {
        public GoalClickEventArgs(Goal goal)
        {
            this.Goal = goal;
        }

        public Goal Goal { get; set; }
    }
}
