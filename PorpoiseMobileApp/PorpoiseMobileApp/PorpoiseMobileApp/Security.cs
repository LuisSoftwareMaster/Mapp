using MvvmCross.Core.ViewModels;
using PorpoiseMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PorpoiseMobileApp
{
    public class Security : MvxNavigatingObject
    {
        private static Security singleton = new Security();

		public static DateTime? LastInteraction { get; set; }

        public static void Touch()
        {
            LastInteraction = DateTime.Now;
        }

        public static void Check()
        {
            if (LastInteraction + TimeSpan.FromMinutes(2) < DateTime.Now)
            {
                Touch();
                singleton.ShowViewModel<LoadingViewModel>(new MvxBundle(), new MvxBundle(), new MvxRequestedBy());
            }
        }

        protected Security() { }
    }
}
