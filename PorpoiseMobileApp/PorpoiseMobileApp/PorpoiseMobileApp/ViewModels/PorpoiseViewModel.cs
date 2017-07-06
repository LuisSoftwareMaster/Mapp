using Acr.Settings;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace PorpoiseMobileApp.ViewModels
{
	public class PorpoiseViewModel<TModel> : MvxViewModel where TModel : MvxViewModel
	{
		private ISettings settings;

        private bool fireEvent = false;

        public bool FireEvent
        {

            get
            {

                return fireEvent;

            }
            set
            {

                fireEvent = value;

                Debug.WriteLine("FIRE EVENT HAS CHANGED");

                RaisePropertyChanged(()=>FireEvent);

            }
        }

		public PorpoiseViewModel()
		{
			settings = Mvx.Resolve<ISettings>();
		}
		public void ForPropertyChange<T>(Expression<Func<TModel, T>> property, Action<T> action, bool fireIfReady = false)
		{
			LambdaExpression lambda = property as LambdaExpression;
			var body = lambda.Body as MemberExpression;
			var prop = body.Member as PropertyInfo;

			if (fireIfReady)
			{
				var currentValue = prop.GetValue(this);
				if (currentValue != null)
				{
					action((T)currentValue);
				}
			}

			this.PropertyChanged += (s, e) =>
			{
				if (e.PropertyName == body.Member.Name)
				{
					var obj = prop.GetValue(s);
					action((T)obj);
				}
			};
		}

	}
}
