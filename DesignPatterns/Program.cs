using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton instance1 = Singleton.GetInstance();
            Singleton instance2 = Singleton.GetInstance();

            Console.WriteLine($"Instance 1 reference: {instance1.GetHashCode()}");
            Console.WriteLine($"Instance 2 reference: {instance2.GetHashCode()}");
            Console.WriteLine($"Are both instances the same object? {instance1 == instance2}");

            instance1.PrintMessage();
        }
    }
}