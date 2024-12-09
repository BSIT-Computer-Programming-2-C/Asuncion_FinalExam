using System;

namespace AnimalSound
{
    public abstract class Animal
    {
        public abstract void MakeSound();
    }

    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog: Arf! Arf!");
        }
    }

    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Cat: Meow! Meow!");
        }
    }

    public class Dragon : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dragon: Graaaah! Graaaah!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal myDog = new Dog();
            Animal myCat = new Cat();
            Animal myDragon = new Dragon();

            myDog.MakeSound();
            myCat.MakeSound();
            myDragon.MakeSound();

            // Prevent the console from closing immediately
            Console.ReadKey();
        }
    }
}
