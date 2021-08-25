using CoreClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoIt
{
    public class DoFacade
    {
        public static void Do()
        {
            Facade fa = new Facade();
            fa.Method();
        }
    }
}
