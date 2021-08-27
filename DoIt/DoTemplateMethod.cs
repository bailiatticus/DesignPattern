using CoreClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoIt
{
    public class DoTemplateMethod
    {
        public static void Do()
        {
            PlayGames p1 = new NS();
            p1.Play();

            PlayGames p2 = new PS4();
            p2.Play();
        }
    }
}
