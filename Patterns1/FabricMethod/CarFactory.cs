using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportFactory.Factories
{
    public class CarFactory : ITransportFactory
    {
        public ITransport CreateTransport()
        {
            return new Car();
        }
    }
}
