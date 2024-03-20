using System;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PrototypeManager manager = new PrototypeManager();

            manager["object1"] = new ConcretePrototype1("Initial state");
            manager["object2"] = new ConcretePrototype2("Initial state");

            IPrototype clonedObject1 = manager["object1"].Clone();
            IPrototype clonedObject2 = manager["object2"].Clone();

            Console.WriteLine("Original prototype 1 state: " + manager["object1"].State);
            Console.WriteLine("Cloned prototype 1 state: " + clonedObject1.State);

            Console.WriteLine("\nOriginal prototype 2 state: " + manager["object2"].State);
            Console.WriteLine("Cloned prototype 2 state: " + clonedObject2.State);

            (clonedObject1 as ConcretePrototype1).State = "Modified state 1";
            (clonedObject2 as ConcretePrototype2).State = "Modified state 2";

            Console.WriteLine("\nOriginal prototype 1 state after modification: " + manager["object1"].State);
            Console.WriteLine("Modified cloned prototype 1 state: " + clonedObject1.State);

            Console.WriteLine("\nOriginal prototype 2 state after modification: " + manager["object2"].State);
            Console.WriteLine("Modified cloned prototype 2 state: " + clonedObject2.State);
        }
    }
}