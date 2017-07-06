using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmCross.Platform.Converters;
using PorpoiseMobileApp.Models;

namespace PorpoiseMobileApp.Droid.Converters
{


    public class BlankDropdownValueConverter<T> : IMvxValueConverter
    {
        private readonly T blankEntry;

        public BlankDropdownValueConverter(T empty)
        {
            this.blankEntry = empty;
        }
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var original = value as List<T>;
            var newList = new List<T>(original);
            newList.Insert(0, blankEntry);
            var orgList = value as List<Organisation>;
            if (orgList != null && orgList.FirstOrDefault(x => x.Name == PorpoiseMobileApp.Resource.Other) == null)
            {
                var otherOrg = new Organisation
                {
                    Name = PorpoiseMobileApp.Resource.Other,
                    Id = new Guid()
                };

                (newList as List<Organisation>).Insert(newList.Count, otherOrg);
            }
            return newList;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}