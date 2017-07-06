using Foundation;
using MvvmCross.Binding.iOS.Views;
using MvvmCross.Binding.BindingContext;
using System;
using UIKit;
using PorpoiseMobileApp.Models;
using PorpoiseMobileApp.Converters;
using System.Threading.Tasks;
using System.Diagnostics;
using CoreGraphics;
namespace PorpoiseMobileApp.iOS
{
	public partial class OrganizationSearchItem : MvxTableViewCell
	{
		public static readonly NSString Key = new NSString("OrganizationSearchItem");
		public static readonly UINib Nib;


		public PorpoiseLabel Title { 
		
			get {
				return (PorpoiseLabel)this.title;
			}

			set {

				title = value;
			
			}
		
		}

        public UIImageView Check{

            get{

                return this.check;

            }
            set{

                this.check = value;

            }

        }

		public static OrganizationSearchItem Create()
		{
			return (OrganizationSearchItem)Nib.Instantiate(null, null)[0];
		}
		protected OrganizationSearchItem(string bindingText, IntPtr handle) : base(bindingText, handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}
		public  OrganizationSearchItem(IntPtr handle) : base(handle){
           
			this.DelayBind(() =>
			{
				UIImage image = Services.PorpoiseImage.getFromURL("https://s3.amazonaws.com/porpoise-cdn/mobile-assets/checked-symbol.png");
				this.check.Image = image;



				var set = this.CreateBindingSet<OrganizationSearchItem, Goal>();

				set.Bind(this.title).For(x => x.Text).To(vm => vm.Name);

				set.Apply();
			});



		}
	}
}
