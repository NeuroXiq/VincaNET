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
        public object JsonResult { get; set; }

        public StatusCodeException(System.Net.HttpStatusCode code)
        {
            StatusCode = (int)code;
        }

        public StatusCodeException(System.Net.HttpStatusCode code, object jsonResult)
        {
            StatusCode = (int)code;
            JsonResult = jsonResult;
        }
    }
}
