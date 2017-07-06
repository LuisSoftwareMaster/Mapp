using System;
namespace PorpoiseMobileApp.Client
{
	public class GiveWelldoneResponseModel
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



		public GiveWelldoneResponseModel(bool successful)
		{

			this.Successful = successful;

		}
	}
}
