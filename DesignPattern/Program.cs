using DoIt;
using System;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\r DoFactory.Do()");
            DoFactory.Do();
            Console.WriteLine("\n\r DoPrototype.Do()");
            DoPrototype.Do();
            Console.WriteLine("\n\r DoBuilder.Do()");
            DoBuilder.Do();
            Console.WriteLine("\n\r DoAdatper.Do()");
            DoAdatper.Do();
            Console.WriteLine("\n\r DoBridge.Do()");
            DoBridge.Do();
            Console.WriteLine("\n\r DoDecorator.Do()");
            DoDecorator.Do();
            Console.WriteLine("\n\r DoComposite.Do()");
            DoComposite.Do();
            Console.WriteLine("\n\r DoFacade.Do()");
            DoFacade.Do();
            Console.WriteLine("\n\r DoFlyweight.Do()");
            DoFlyweight.Do();

            Console.ReadKey();
        }
    }
}
