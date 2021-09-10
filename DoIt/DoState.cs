using CoreClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoIt
{
    public class DoState
    {
        public static void Do()
        {
            Gamer me = new Gamer("百里");
            for(int i =0; i < 21; i++)
            {
                me.PlayGames();
            }

        }
    }
}
