using System;
using System.Collections.Generic;
using System.Text;

namespace CoreClass
{
    public class Facade
    {
        private SystemA sa = new SystemA();
        private SystemB sb = new SystemB();
        private SystemC sc = new SystemC();

        public void Method()
        {
            sa.Method();
            sb.Method();
            sc.Method();
        }
    }

    public class SystemA
    {
        public void Method()
        {
            Console.WriteLine("SystemA:Method()");
        }
    }

    public class SystemB
    {
        public void Method()
        {
            Console.WriteLine("SystemB:Method()");
        }
    }

    public class SystemC
    {
        public void Method()
        {
            Console.WriteLine("SystemC:Method()");
        }
    }
}
