using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public class ConcretePrototype1 : IPrototype
    {
        public string State { get; set; }

        public ConcretePrototype1(string state)
        {
            State = state;
        }

        public IPrototype Clone()
        {
            return new ConcretePrototype1(State);
        }
    }
}