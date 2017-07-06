using System;
using System.Threading.Tasks;

namespace PorpoiseMobileApp.ViewModels
{
	public class SupportViewModel : PorpoiseViewModel<SupportViewModel>
	{
		public SupportViewModel()
		{

		}
	

		public string SupportEmailAddress
		{
			get { return "sos@getporpoise.com"; }
		}
	}
}