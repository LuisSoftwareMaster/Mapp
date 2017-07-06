using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PorpoiseMobileApp.Client
{
    public class ResponseModel<T>
    {
        private bool _successful;

        public string Result
        {
            get; set;
        }
        public bool Successful
        {
            get
            {
                return string.Equals(Result, Resource.Success.ToLower());
            }
            set
            {
                _successful = value;
            }
        }
        public string Message { get; set; }
        
        public T Payload { get; set; }

        public ResponseModel(bool successful)
        {
            this.Successful = successful;
        }

        public ResponseModel()
        {

        }
    }
}
