using System;
namespace PorpoiseMobileApp.Client
{
    public class SignupResponseModel: ResponseModel<SignupPayload>
    {
		public SignupResponseModel()
		{
		}

		public SignupResponseModel(bool successful) : base(successful)
        {
		}
		public SignupResponseModel(bool success, string message) : base(success)
        {

			this.Message = message;
		}


	}

	public class SignupPayload
	{


	}
}
