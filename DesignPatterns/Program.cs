using System;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IAnimalFactory wildAnimalFactory = new WildAnimalFactory();
            IAnimal lion = wildAnimalFactory.GetAnimal("Lion");
            IAnimal tiger = wildAnimalFactory.GetAnimal("Tiger");

            Console.WriteLine("Wild Animals:");
            Console.WriteLine(lion.GetType().Name + ": " + lion.MakeSound());
            Console.WriteLine(tiger.GetType().Name + ": " + tiger.MakeSound());

            IAnimalFactory petAnimalFactory = new PetAnimalFactory();
            IAnimal dog = petAnimalFactory.GetAnimal("Dog");
            IAnimal cat = petAnimalFactory.GetAnimal("Cat");

            Console.WriteLine("\nPet Animals:");
            Console.WriteLine(dog.GetType().Name + ": " + dog.MakeSound());
            Console.WriteLine(cat.GetType().Name + ": " + cat.MakeSound());

            Console.ReadLine();
        }
    }
}