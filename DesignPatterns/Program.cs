using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new CarBuilder();
            var director = new CarDirector(builder);

            director.ConstructCLS();
            var cls = builder.GetCar();
            cls.Show();

            director.ConstructM5CS();
            var m5cs = builder.GetCar();
            m5cs.Show();

            Console.ReadLine(); 
        }
    }
}