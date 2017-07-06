using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PorpoiseMobileApp.Client
{
    public class ClientRequestResult
    {
        public ClientRequestResult(bool successful)
        {
            this.Successful = successful;
            this.Message = null;
            this.StatusCode = successful ? HttpStatusCode.OK : HttpStatusCode.Ambiguous;
        }

        public ClientRequestResult(bool successful, Tuple<int, string> result)
        {
            this.Successful = successful;
            this.Message = result.Item2;
            this.StatusCode = (HttpStatusCode)result.Item1;
        }

        public bool Successful { get; protected set; }

        public string Message { get; protected set; }

        public HttpStatusCode StatusCode { get; protected set; }
        
    }
}
