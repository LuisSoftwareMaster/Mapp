using System;
namespace PorpoiseMobileApp
{

	[AttributeUsage(AttributeTargets.All)]
	public class HelpAttribute: System.Attribute
	{

		public readonly string Url;

		private string topic;

		public string Topic { 
		
			get {

				return topic;
			
			}
			set {

				topic = value;
			
			}
		
		}

		public HelpAttribute(string url) {


			this.Url = url;
		
		}

	}
}
