using CoreClass.Behavioral;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DoIt
{
    public class DoMemento
    {
        public static void Do()
        {
            List<Girl> girls = new List<Girl>();
            girls.Add(new Girl() { Name = "zly", Age = 30, Status = 5 });
            girls.Add(new Girl() { Name = "yyl", Age = 26, Status = 8 });
            girls.Add(new Girl() { Name = "haq", Age = 35, Status = -1 });

            Collection c = new Collection(girls);

            Manager m = new Manager();


            var p1 = c.CreatePicture();

            m.Add(p1);
            Thread.Sleep(1000);

            girls.Where(s => s.Name == "zly").FirstOrDefault().Status = 0;
            girls.Remove(girls.Where(s => s.Name == "yyl").FirstOrDefault());
            girls.Where(s => s.Name == "haq").FirstOrDefault().Status = 1;

            var p2 = c.CreatePicture();

            m.Add(p2);
            Thread.Sleep(1000);

            girls.Add(new Girl() { Name = "zyy", Age = 28, Status = 2 });

            m.Add(c.CreatePicture());

            foreach(var pic in m.Pictures)
            {
                Console.WriteLine(pic.Key + ":");
                pic.Value.ShowCollection();
            }
        }
    }
}
