using System;
namespace PorpoiseMobileApp.Client
{
    public class InviteCoworkerRequestModel
    {
        public Guid employee_uid { get; set; }

        public string name { get; set; }

        public string email { get; set; }
    }
}
