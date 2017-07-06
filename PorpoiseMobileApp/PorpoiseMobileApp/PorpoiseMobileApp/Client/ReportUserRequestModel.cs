using System;
namespace PorpoiseMobileApp
{
    public class ReportUserRequestModel
    {
        public Guid post_uid{ get; set; }

        public Guid user_uid { get; set; }

        public string reason { get; set;  }

    }
}
