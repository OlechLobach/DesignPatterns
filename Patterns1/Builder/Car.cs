using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Engine { get; set; }
        public int Doors { get; set; }

        public void Show()
        {
            Console.WriteLine($"Brand: {Brand}, Model: {Model}, Engine: {Engine}, Doors: {Doors}");
        }
    }
}
