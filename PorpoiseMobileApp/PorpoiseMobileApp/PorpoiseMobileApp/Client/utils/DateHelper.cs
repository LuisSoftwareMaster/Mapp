using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PorpoiseMobileApp.Client.utils
{
    class DateHelper
    {
        public static string NowISO8601()
        {
            return DateTime.UtcNow.ToString("yyyyMMdd'T'HHmmss'Z'");
        }
    }
}
