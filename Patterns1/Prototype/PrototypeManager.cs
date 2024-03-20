using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.Generic;

namespace PrototypePattern
{
    public class PrototypeManager
    {
        private Dictionary<string, IPrototype> prototypes = new Dictionary<string, IPrototype>();

        public IPrototype this[string key]
        {
            get { return prototypes[key]; }
            set { prototypes[key] = value; }
        }
    }
}
