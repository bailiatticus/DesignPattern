using CoreClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoIt
{
    public class DoStragety
    {
        public static void Do()
        {
            Gamer2 gamer2 = new Gamer2(new NSPlatform());
            gamer2.PlayGames();

            gamer2.Platform = new PSPlatform();
            gamer2.PlayGames();
        }
    }
}
