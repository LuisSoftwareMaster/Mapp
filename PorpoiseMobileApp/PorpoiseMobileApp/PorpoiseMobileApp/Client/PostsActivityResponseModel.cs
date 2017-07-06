using PorpoiseMobileApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PorpoiseMobileApp.Client
{
    public class PostsActivityResponseModel : ResponseModel<List<HourLog>>
    {
        public List<HourLog> Posts
        {
            get
            {
                return Payload;
            }
        }
        public PostsActivityResponseModel()
        {

        }


        public PostsActivityResponseModel(bool successful) : base(successful)
        {

        }
    }


}
