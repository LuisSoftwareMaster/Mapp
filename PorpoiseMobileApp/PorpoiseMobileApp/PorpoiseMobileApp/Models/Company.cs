using PorpoiseMobileApp.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PorpoiseMobileApp.Models
{
    public class Company : IDataObject
    {
        public Guid? Id
        {
            get; set;
        }

        public string Name { get; set; }
        //wont use a logo for MVP since we're not display a company page
        public string LogoPath { get; set; }
        public List<Goal> Goals { get; set; }
        public List<Employee> Employees { get; set; }
        public List<Organisation> Organisations { get; set; }
    }
}
