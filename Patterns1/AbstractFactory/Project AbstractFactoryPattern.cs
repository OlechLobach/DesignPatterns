using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public interface IAnimal
    {
        string MakeSound();
    }

    public class Lion : IAnimal
    {
        public string MakeSound()
        {
            return "Roar";
        }
    }

    public class Tiger : IAnimal
    {
        public string MakeSound()
        {
            return "Growl";
        }
    }

    public class Dog : IAnimal
    {
        public string MakeSound()
        {
            return "Woof";
        }
    }

    public class Cat : IAnimal
    {
        public string MakeSound()
        {
            return "Meow";
        }
    }

    public interface IAnimalFactory
    {
        IAnimal GetAnimal(string animalType);
    }

    public class WildAnimalFactory : IAnimalFactory
    {
        public IAnimal GetAnimal(string animalType)
        {
            switch (animalType)
            {
                case "Lion":
                    return new Lion();
                case "Tiger":
                    return new Tiger();
                default:
                    throw new ApplicationException($"Animal '{animalType}' cannot be created by WildAnimalFactory");
            }
        }
    }

    public class PetAnimalFactory : IAnimalFactory
    {
        public IAnimal GetAnimal(string animalType)
        {
            switch (animalType)
            {
                case "Dog":
                    return new Dog();
                case "Cat":
                    return new Cat();
                default:
                    throw new ApplicationException($"Animal '{animalType}' cannot be created by PetAnimalFactory");
            }
        }
    }
}