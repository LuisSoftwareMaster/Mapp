using System.Collections.Specialized;
using System.Windows.Input;
using Android.App;
using Android.Views;
using Android.Widget;
using MvvmCross.Platform.IoC;
using PorpoiseMobileApp.ViewModels;
using Acr.Settings;
using PorpoiseMobileApp.Client;
using PorpoiseMobileApp.Services;

namespace PorpoiseMobileApp.Droid
{
    // This class is never actually executed, but when Xamarin linking is enabled it does how to ensure types and properties
    // are preserved in the deployed app
    public class LinkerPleaseInclude
    {
        public void Include(Button button)
        {
            button.Click += (s,e) => button.Text = button.Text + "";
        }

        public void Include(CheckBox checkBox)
        {
            checkBox.CheckedChange += (sender, args) => checkBox.Checked = !checkBox.Checked;
        }
        
        public void Include(Switch @switch)
        {
            @switch.CheckedChange += (sender, args) => @switch.Checked = !@switch.Checked;
        }

        public void Include(View view)
        {
            view.Click += (s, e) => view.ContentDescription = view.ContentDescription + "";
        }

        public void Include(TextView text)
        {
            text.TextChanged += (sender, args) => text.Text = "" + text.Text;
            text.Hint = "" + text.Hint;
        }
        
        public void Include(CheckedTextView text)
        {
            text.TextChanged += (sender, args) => text.Text = "" + text.Text;
            text.Hint = "" + text.Hint;
        }

        public void Include(CompoundButton cb)
        {
            cb.CheckedChange += (sender, args) => cb.Checked = !cb.Checked;
        }

        public void Include(SeekBar sb)
        {
            sb.ProgressChanged += (sender, args) => sb.Progress = sb.Progress + 1;
        }

        public void Include(Activity act)
        {
            act.Title = act.Title + "";
        }

        public void Include(INotifyCollectionChanged changed)
        {
            changed.CollectionChanged += (s,e) => { var test = ""+e.Action+""+e.NewItems+""+e.NewStartingIndex+""+e.OldItems+""+e.OldStartingIndex+""; };
        }

        public void Include(ICommand command)
        {
            command.CanExecuteChanged += (s, e) => { if (command.CanExecute(null)) command.Execute(null); };
        }
        
        public void Include(MvxPropertyInjector injector)
        {
            injector = new MvxPropertyInjector ();
        } 

        public void Include(System.ComponentModel.INotifyPropertyChanged changed)
        {
            changed.PropertyChanged += (sender, e) =>  {
                var test = e.PropertyName;
            };
        }

        //public void Include(ISettings settings)
        //{
        //    var vm = new LoadingViewModel(settings);
        //}

        public void Include(IPorpoiseWebApiClient client)
        {
            ISettings ss = null;
            IEncryptionService es = null;
            IImageRotateService rotator = null;
            var vm = new LoginViewModel(client, ss, es);
			var vm1 = new LogHoursViewModel (client);
            var vm2 = new LoadingViewModel(ss, client);
            //var vm2 = new SignUpViewModel(sdk, ss);
            //var vm3 = new AllowanceViewModel(sdk, ss);
            //var vm4 = new UpdateAllowanceViewModel(sdk, ss);
            //var vm5 = new TermsOfServiceViewModel();
            //var vm6 = new ResetPasswordViewModel(sdk, ss);
            //var vm7 = new AccountHomeViewModel();
            //var vm8 = new AccountInfoViewModel(new SdkServiceImpl("", "", null));

        }
    }
}
