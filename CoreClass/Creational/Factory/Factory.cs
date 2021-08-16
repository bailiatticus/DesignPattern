using System;
using System.Collections.Generic;
using System.Text;

namespace CoreClass
{
    public class Animal
    {
        public virtual void GetAnimal()
        {
            Console.WriteLine("Animal is Good!");
        }
    }

    public class Dog : Animal
    {
        public override void GetAnimal()
        {
            Console.WriteLine("Dog is Happy!");
        }
    }

    public class Cat : Animal
    {
        public override void GetAnimal()
        {
            Console.WriteLine("Cat is Simling~");
        }
    }

    public abstract class AnimalShop
    {
        public abstract Animal SendAnimal();
    }

    public class DogShop : AnimalShop
    {
        public override Animal SendAnimal()
        {
            return new Dog();
        }
    }

    public class CatShop : AnimalShop
    {
        public override Animal SendAnimal()
        {
            return new Cat();
        }
    }
}
