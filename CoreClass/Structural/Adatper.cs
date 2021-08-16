using System;
using System.Collections.Generic;
using System.Text;

namespace CoreClass
{
    public interface IAction
    {
        public void Birth();

        public void Death();
    }

    public class Roboot
    {
        public void Create()
        {
            Console.WriteLine("Roboot Create");
        }
        public void Run()
        {
            Console.WriteLine("Roboot Run");
        }
        public void Stop()
        {
            Console.WriteLine("Roboot Stop");
        }
    }


    public class ClassAdatper : Roboot, IAction
    {
        public void Birth()
        {
            this.Create(); 
            this.Run();
        }

        public void Death()
        {
            this.Stop();
        }
    }

    public class Alien
    {
        public void Begin()
        {
            Console.WriteLine("Alien Begin");
        }
        public void End()
        {
            Console.WriteLine("Alien End");
        }
    }

    public class ObjectAdatper : IAction
    {
        private Alien alien_007 = new Alien();

        public void Birth()
        {
            alien_007.Begin();
        }

        public void Death()
        {
            alien_007.End();
        }
    }

}
