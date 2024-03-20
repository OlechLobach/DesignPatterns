using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public interface ICarBuilder
    {
        void SetBrand(string brand);
        void SetModel(string model);
        void SetEngine(string engine);
        void SetDoors(int doors);
        Car GetCar();
    }

    public class CarBuilder : ICarBuilder
    {
        private Car car = new Car();

        public void SetBrand(string brand)
        {
            car.Brand = brand;
        }

        public void SetModel(string model)
        {
            car.Model = model;
        }

        public void SetEngine(string engine)
        {
            car.Engine = engine;
        }

        public void SetDoors(int doors)
        {
            car.Doors = doors;
        }

        public Car GetCar()
        {
            return car;
        }
    }
}
