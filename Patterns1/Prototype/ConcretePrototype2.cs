using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public class ConcretePrototype2 : IPrototype
    {
        public string State { get; set; }

        public ConcretePrototype2(string state)
        {
            State = state;
        }

        public IPrototype Clone()
        {
            return new ConcretePrototype2(State);
        }
    }
}