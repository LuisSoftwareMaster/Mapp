using Newtonsoft.Json;
using PorpoiseMobileApp.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PorpoiseMobileApp.Models
{
	public class Organisation : IDataObject
	{
		[JsonProperty("organization_uid")]
		public Guid? Id { get; set; }
		[JsonProperty("organization_name")]
		public string Name { get; set; }

		[JsonProperty("organization_location")]
		public string Location { get; set; }

		[JsonProperty("organization_published")]
		public bool Published { get; set; }



		public override string ToString()
		{
			return Name;
		}

        [JsonIgnore]
        public bool isEmpty { get; set; }
    }
}
