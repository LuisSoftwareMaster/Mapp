using Newtonsoft.Json;
using PorpoiseMobileApp.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PorpoiseMobileApp.Models
{
    public class Gift : IDataObject
    {
        [JsonIgnore]
        public Guid? Id { get; set; }

        [JsonIgnore]
        public string Value { get; set; }
    }
}
