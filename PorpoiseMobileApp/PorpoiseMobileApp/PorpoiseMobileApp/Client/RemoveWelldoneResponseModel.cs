using System;
namespace PorpoiseMobileApp.Client
{
	public class RemoveWelldoneResponseModel
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

			get;
			set;
		
		}


		public string Message {

			get;

			set;
		
		}

		public RemoveWelldoneResponseModel(bool successful)
		{

			this.Successful = successful;

		}
	}
}
