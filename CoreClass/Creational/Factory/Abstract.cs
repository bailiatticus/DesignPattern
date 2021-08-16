using System;
using System.Collections.Generic;
using System.Text;

namespace CoreClass
{
    public abstract class Color
    {
        public abstract void CheckOut();                          
    }

    public abstract class Shape
    {
        public abstract void See();
    }

    public class EtherealColer : Color
    {
        public override void CheckOut()
        {
            Console.WriteLine("Blue says Hi~");
        }
    }

    public class EtherealShape : Shape
    {
        public override void See()
        {
            Console.WriteLine("I'm diamond");
        }
    }


    public class WarmthColor : Color
    {
        public override void CheckOut()
        {
            Console.WriteLine("Red says hello~");
        }
    }

    public class WarmthShape : Shape
    {
        public override void See()
        {
            Console.WriteLine("Circle is speaking");
        }
    }

    public abstract class Create
    {
        public abstract Color FindColor();
        public abstract Shape SeeSharp();
    }

    public class CreateWarmth : Create
    {
        public override Color FindColor()
        {
            return new WarmthColor();
        }

        public override Shape SeeSharp()
        {
            return new WarmthShape();
        }
    }

    public class CreateEthereal : Create
    {
        public override Color FindColor()
        {
            return new EtherealColer();
        }

        public override Shape SeeSharp()
        {
            return new EtherealShape();
        }
    }
}
