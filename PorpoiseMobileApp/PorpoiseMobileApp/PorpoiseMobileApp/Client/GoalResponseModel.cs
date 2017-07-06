using PorpoiseMobileApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PorpoiseMobileApp.Client
{
    public class GoalResponseModel : ResponseModel<List<Goal>>
    {
        public List<Goal> Goals
        {
            get
            {
                return Payload;

            }
        }

        public GoalResponseModel()
        {

        }

        public GoalResponseModel(bool successful)
        {
            this.Successful = successful;
        }
    }

}
