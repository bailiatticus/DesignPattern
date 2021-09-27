using CoreClass.Behavioral;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoIt
{
    public class DoVistor
    {
        public static void Do()
        {
            CarManager carManager = new CarManager();

            Genies genies = new ZtGenies();

            foreach(var car in carManager.ListCar)
            {
                car.BeUsed(genies);
            }
        }
    }
}
