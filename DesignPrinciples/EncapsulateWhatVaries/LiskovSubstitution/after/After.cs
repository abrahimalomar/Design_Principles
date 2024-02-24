using System;

namespace LiskovSubstitution.after
{
    public class Animal
    {
        public Animal()
        {

        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Making a sound");
        }
    }

    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Howling");
        }
    }

    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meowing");
        }
    }

    public class UsingAnimal
    {
        public static void Make(Animal animal)
        {
            animal.MakeSound();
        }
    }
}
