using CoreClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoIt
{
    public class DoCommand
    {
        public static void Do()
        {
            Programer p = new Programer();
            Command c = new RoobotComand(p);
            Productor pr = new Productor(c);
            pr.CallDuty();
            
        }
    }
}
