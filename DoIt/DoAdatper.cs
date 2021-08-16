using CoreClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoIt
{
    public class DoAdatper
    {
        public static void Do()
        {
            IAction classAction = new ClassAdatper();
            classAction.Birth();
            classAction.Death();

            IAction objectAction = new ObjectAdatper();
            objectAction.Birth();
            objectAction.Death();

        }
    }
}
