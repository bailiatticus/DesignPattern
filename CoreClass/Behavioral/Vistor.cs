using System;
using System.Collections.Generic;
using System.Text;

namespace CoreClass.Behavioral
{
    public abstract class Car
    {
        public string Name { get; set; }

        public abstract void Run();

        public abstract void BeUsed(Genies genies);
    }

    public class RealCar : Car
    {
        public override void BeUsed(Genies genies)
        {
            genies.UseReal(this);
        }

        public override void Run()
        {
            Console.WriteLine("real car is running");
        }
    }

    public class ToyCar : Car
    {
        public override void BeUsed(Genies genies)
        {
            genies.UseToy(this);
        }

        public override void Run()
        {
            Console.WriteLine("playing toy car is happy");
        }
    }

    public abstract class Genies
    {
        public abstract void UseToy(ToyCar toyCar);

        public abstract void UseReal(RealCar realCar);
    }

    public class ZtGenies : Genies
    {
        public override void UseReal(RealCar realCar)
        {
            Console.WriteLine($"realCar:{realCar.Name} is using");
            realCar.Run();
            Console.WriteLine("------");
        }

        public override void UseToy(ToyCar toyCar)
        {
            Console.WriteLine($"toycar:{toyCar.Name} is using");
            toyCar.Run();
            Console.WriteLine("------");
        }
    }

    public class CarManager
    {
        public List<Car> ListCar { get; set; } = new List<Car>();

        public CarManager()
        {
            int i = 1, ia = 0;
            Random a = new Random(int.Parse(DateTime.Now.ToString("HHmmss")));
            while (i <= 5)
            {
                ia = a.Next(10);
                Console.WriteLine("随机数：" + ia);
                if(ia >= 5)
                {
                    ListCar.Add(new RealCar(){ Name = $"toycar{i}" });
                }
                else
                {
                    ListCar.Add(new ToyCar(){ Name = $"toycar{i}" });
                }
                i++;

            }
        }
    }


}
