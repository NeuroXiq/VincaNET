using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vinca.Exceptions
{
    public class NotFoundException : StatusCodeException
    {
        public NotFoundException(string message) : base(System.Net.HttpStatusCode.NotFound, message) { }
        public NotFoundException() : this ("") { }
    }
}
