using CoreClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoIt
{
    public class DoObserver
    {
        public static void Do()
        {
            HumanWuXingFaZhan humanWuXingFaZhan = new HumanWuXingFaZhan("人类的五行法阵");
            WuXingShiZhe sz1 = new WuXingShiZhe("火使者");
            WuXingShiZhe sz2 = new WuXingShiZhe("风使者");
            humanWuXingFaZhan.AddObserver(sz1);
            humanWuXingFaZhan.AddObserver(sz2);

            humanWuXingFaZhan.CallEmergence();

        }
    }
}
