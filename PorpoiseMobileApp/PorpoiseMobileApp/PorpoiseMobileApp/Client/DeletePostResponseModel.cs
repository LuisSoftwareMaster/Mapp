using System;
namespace PorpoiseMobileApp.Client
{
	public class DeletePostResponseModel
	{

		private bool _successful;

		public bool Successful { 
		
			get {

				return string.Equals(Result, Resource.Success);
			
			}
			set {

				_successful = value;
			
			}
		
		}

		public string Result {

			get;set;
		
		}

		public string Message {

			get;set;
		
		}

		public DeletePostResponseModel(bool successful)
		{

			this.Successful = successful;

		}
	}
}
