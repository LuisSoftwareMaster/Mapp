using Newtonsoft.Json;
using PorpoiseMobileApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PorpoiseMobileApp.Client
{
    public class LogHoursResponseModel : ResponseModel<HourLog>
    {

        //public double? HoursAgainstGoal
        //{
        //    get
        //    {
        //        return Payload?.HoursAgainstGoal;
        //    }
        //}

        public LogHoursResponseModel()
        {

        }

        public LogHoursResponseModel(bool successful) : base(successful)
        {
            
        }


    }
    
}