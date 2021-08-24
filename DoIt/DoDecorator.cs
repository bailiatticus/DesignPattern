using CoreClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoIt
{
    public class DoDecorator
    {
        public static void Do()
        {
            Hero h1 = new AntiMagic();
            h1.Show();

            Decoration h2 = new HelmetD(h1);
            h2.Show();

            Decoration h3 = new ArmourD(h1);
            h3.Show();

            Decoration h4 = new HelmetD(h1);
            Decoration h5 = new ArmourD(h4);
            h5.Show();
        }
    }
}
