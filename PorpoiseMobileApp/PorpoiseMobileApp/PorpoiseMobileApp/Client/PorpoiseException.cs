using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PorpoiseMobileApp.Client
{
    public class PorpoiseException : Exception
    {
        private Error error;

        public PorpoiseException(string message) : base(message)
        {
        }

        public PorpoiseException(Error error)
            : base(string.IsNullOrEmpty(error.ExceptionMessage) ? error.Message : error.ExceptionMessage)
        {
            this.error = error;
        }

        public override string StackTrace
        {
            get
            {
                return error.StackTrace;
            }
        }
    }
}
