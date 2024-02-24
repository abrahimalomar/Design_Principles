using LiskovSubstitution.after;
using System;

namespace LiskovSubstitution
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // UsingAnimall2 example
            UsingAnimall2 usingAnimall2 = new UsingAnimall2();
            Animaal dog2 = new Dogg2();
            Animaal cat2 = new Cat2();
            usingAnimall2.Mak(dog2);
            usingAnimall2.Mak(cat2);

            Console.WriteLine("--------------------");

            // UsingAnimal example
            UsingAnimal.Make(new Dog());
            UsingAnimal.Make(new Cat());
            UsingAnimal.Make(new Animal());

            */
            //After
            // Create instances of Dog and Cat
            Dog dog = new Dog();
            Cat cat = new Cat();

            // Call the Make method with Dog and Cat objects
            UsingAnimal.Make(dog);
            UsingAnimal.Make(cat);

            // You can also pass Animal objects
            Animal animal = new Animal();
            UsingAnimal.Make(animal);
            Console.ReadKey();
        }
    }
}
