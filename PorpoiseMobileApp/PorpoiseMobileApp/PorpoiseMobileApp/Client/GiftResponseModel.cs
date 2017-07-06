using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PorpoiseMobileApp.Client
{
   public class GiftResponseModel : ResponseModel<GiftPayload>
    {
        public Guid Id {
            get
            {
                return Guid.Parse(Payload.GiftId);
            }
        }
       public string Value {
            get
            {
                return Payload.Value;
            }
        }

        public GiftResponseModel()
        {

        }


        public GiftResponseModel(bool successful) : base(successful)
        {
        }
    }

    public class GiftPayload
    {
        public string GiftId { get; set; }
        public string Value { get; set; }
    }
}

