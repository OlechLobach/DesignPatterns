using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace TransportFactory.Factories
{
    public class MotorcycleFactory : ITransportFactory
{
    public ITransport CreateTransport()
    {
        return new Motorcycle();
    }
}
}