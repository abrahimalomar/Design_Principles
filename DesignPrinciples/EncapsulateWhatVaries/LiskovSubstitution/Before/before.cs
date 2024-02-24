using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitution.Before
{
    public class Animaal
    {
        public Animaal()
        {

        }
        public virtual void MakSound()
        {

        }
    }
    public class Dogg2 : Animaal
    {
        public override void MakSound()
        {
            Console.WriteLine("Dog is making sound");
        }
    }

    public class Cat2 : Animaal
    {
        public override void MakSound()
        {
            Console.WriteLine("Cat is making sound");
        }
    }

    public class UsingAnimall2
    {
        public void Mak(Animaal animaal)
        {
            animaal.MakSound();
        }
    }
    public class Animal

    {
        public Animal()
        {

        }
        public void MakSound()
        {
            Console.WriteLine("Animal is making sound");
        }
    }
    public class Dog : Animal
    {
        public void MakeHowling()
        {
            Console.WriteLine("Dog is howling");
        }
    }
    public class Cat : Animal
    {
        public void MakeTheApostate()
        {
            Console.WriteLine("Cat is making the apostate");
        }
    }
    public class UsingAnimal
    {
        public static void Make(Animal animal)
        {
            if (animal is Cat)
            {
                Cat t = (Cat)animal;
                t.MakeTheApostate();
            }
            else if (animal is Dog)
            {
                Dog dog = (Dog)animal;
                dog.MakeHowling();
            }
            else if (!(animal is Cat) && !(animal is Dog))
            {
                animal.MakSound();
            }
        }
    }
}
