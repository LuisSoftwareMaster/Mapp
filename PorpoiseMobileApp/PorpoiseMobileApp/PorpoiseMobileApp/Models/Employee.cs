using PorpoiseMobileApp.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PorpoiseMobileApp.Models
{
    public class Employee : IDataObject

    {
        public Guid? Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }
        public string AccessCode { get; set; }
        public User User { get; set; }
        public Company Company { get; set; }
        public List<HourLog> TotalHoursGiven { get; set; }
    }
}
