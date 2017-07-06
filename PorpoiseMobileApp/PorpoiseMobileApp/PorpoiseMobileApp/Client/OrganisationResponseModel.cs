using Newtonsoft.Json;
using PorpoiseMobileApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PorpoiseMobileApp.Client
{
    public class OrganisationResponseModel : ResponseModel<List<Organisation>>
    {
       

        public List<Organisation> Organisations
        {
            get
            {
                return Payload;
            }
        }
        

        public OrganisationResponseModel()
        {

        }

        public OrganisationResponseModel(bool successful)
        {
            this.Successful = successful;
        }
    }

    
   

}
