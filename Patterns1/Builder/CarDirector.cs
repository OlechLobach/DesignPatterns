using BuilderPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class CarDirector
    {
        private CarBuilder builder;

        public CarDirector(CarBuilder builder)
        {
            this.builder = builder;
        }

        public void ConstructCLS()
        {
            builder.SetBrand("Mercedes");
            builder.SetModel("CLS");
            builder.SetEngine("V6");
            builder.SetDoors(4);
        }

        public void ConstructM5CS()
        {
            builder.SetBrand("BMW");
            builder.SetModel("M5 CS");
            builder.SetEngine("V8");
            builder.SetDoors(4);
        }
    }
}
