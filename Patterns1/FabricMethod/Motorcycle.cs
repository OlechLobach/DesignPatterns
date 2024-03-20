using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportFactory.Factories
{
    public class Motorcycle : ITransport
    {
        public string GetInfo()
        {
            return "This is a motorcycle.";
        }
    }
}
