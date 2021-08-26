using System;
using System.Collections.Generic;
using System.Text;

namespace CoreClass
{
    public abstract class Star
    {
        public abstract void Activity();
    }

    public class Joey : Star
    {
        public override void Activity()
        {
            Console.WriteLine("How are you doing");
        }
    }

    public class Proxy : Star
    {
        private Joey _joey;

        public Proxy()
        {
            _joey = new Joey();
        }

        public override void Activity()
        {
            Console.WriteLine("proxyer arrange a screen test");
            _joey.Activity();
        }        
    }
}
