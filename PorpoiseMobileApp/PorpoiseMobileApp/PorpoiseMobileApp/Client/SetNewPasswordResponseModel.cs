using System;
namespace PorpoiseMobileApp.Client
{
    public class SetNewPasswordResponseModel: ResponseModel<LoginPayload>
    {
		public Guid Token
		{
			get
			{
				return Payload.Token;
			}
		}

		public SetNewPasswordResponseModel()
		{

		}

		public SetNewPasswordResponseModel(bool successful) : base(successful)
        {
		}
		public SetNewPasswordResponseModel(bool success, string message) : base(success)
        {

			this.Message = message;
		}
    }
}
