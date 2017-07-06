using System;
using PorpoiseMobileApp.Client;

namespace PorpoiseMobileApp.Client
{
	public class RequestEmployeeResponseModel : ResponseModel<RequestEmployeePayload>
	{
		public RequestEmployeeResponseModel()
		{
		}

		public RequestEmployeeResponseModel(bool successful) : base(successful)
		{
		}
		public RequestEmployeeResponseModel(bool success, string message) : base(success)
		{

			this.Message = message;
		}




	}

	public class RequestEmployeePayload
	{


	}
}