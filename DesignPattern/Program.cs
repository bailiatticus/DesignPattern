﻿using DoIt;
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

            Console.ReadKey();
        }
    }
}
