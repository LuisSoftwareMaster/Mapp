using System;
namespace PorpoiseMobileApp.iOS
{


[AttributeUsage(AttributeTargets.All)]
	public class HelpAttribute : System.Attribute
	{
		public readonly string Url;

		public string Topic               // Topic is a named parameter
		{
			get
			{
				return topic;
			}
			set
			{

				topic = value;
			}
		}

		public HelpAttribute(string url)  // url is a positional parameter
		{
			this.Url = url;
		}

		private string topic;
	}
	
}

