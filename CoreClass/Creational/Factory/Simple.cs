using System;
using System.Collections.Generic;
using System.Text;

namespace CoreClass
{
    public abstract class Food
    {
        public abstract void GetFood();
    }

    public class MeatFood : Food
    {
        public override void GetFood()
        {
            Console.WriteLine("Here's the meat food");
        }
    }

    public class VegetableFood : Food
    {
        public override void GetFood()
        {
            Console.WriteLine("Here's the vegetable food");
        }
    }

    public class FoodFactory
    {
        public static Food CreateFood(string foodType)
        {
            if (foodType.ToUpper().Equals("VEGETABLE"))
            {
                return new VegetableFood();
            }
            else if (foodType.ToUpper().Equals("MEAT"))
            {
                return new MeatFood();
            }
            else
            {
                throw new Exception("not find food");
            }
        }
    }
}
