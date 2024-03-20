using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportFactory.Factories
{
    public interface ITransportFactory
    {
        ITransport CreateTransport();
    }
}
