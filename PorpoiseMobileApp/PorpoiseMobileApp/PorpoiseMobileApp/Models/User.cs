using PorpoiseMobileApp.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PorpoiseMobileApp.Models
{
    public class User : IDataObject
    {
        public Guid? Id { get; set; }
        public string ProviderId { get; set; }
        public string Provider { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
