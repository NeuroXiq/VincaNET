using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vinca.Exceptions
{
    public class BadRequestException : StatusCodeException
    {
        public BadRequestException(string message) : base(System.Net.HttpStatusCode.BadRequest, message) { }
    }
}
