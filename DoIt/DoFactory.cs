using CoreClass;
using System;

namespace DoIt
{
    public class DoFactory
    {
        public static void Do()
        {
            Console.WriteLine("simple factory design");
            Food f1 = FoodFactory.CreateFood("vegetable");
            Food f2 = FoodFactory.CreateFood("Meat");
            f1.GetFood();
            f2.GetFood();

            Console.WriteLine("\n\rfactory design");
            Animal a1 = new DogShop().SendAnimal();
            Animal a2 = new CatShop().SendAnimal();
            a1.GetAnimal();
            a2.GetAnimal();

            Console.WriteLine("\n\rabstract factory design");
            var n1 = new CreateWarmth();
            Color c1 = n1.FindColor();
            Shape s1 = n1.SeeSharp();
            var n2 = new CreateEthereal();
            Color c2 = n2.FindColor();
            Shape s2 = n2.SeeSharp();

            c1.CheckOut();
            s1.See();
            c2.CheckOut();
            s2.See();
        }
    }
}
