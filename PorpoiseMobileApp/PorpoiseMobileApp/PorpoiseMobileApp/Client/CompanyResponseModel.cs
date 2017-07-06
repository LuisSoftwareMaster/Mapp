using System;
using System.Collections.Generic;

namespace PorpoiseMobileApp.Client
{
	public class CompanyResponseModel : ResponseModel<List<Models.Company>>
	{
		public CompanyResponseModel()
		{
		}
		public List<Models.Company> Goals
		{
			get
			{
				return Payload;

			}
		}

		public CompanyResponseModel(bool successful)
		{
			this.Successful = successful;
		}
	}
}
