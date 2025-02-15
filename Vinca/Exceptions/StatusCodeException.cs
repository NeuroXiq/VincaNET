using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vinca.Exceptions
{
    public class StatusCodeException : Exception
    {
        public int StatusCode { get; set; }

        public StatusCodeException(System.Net.HttpStatusCode code, string message) : base(message) { }

        public StatusCodeException(System.Net.HttpStatusCode code) : base() { }
    }
}
