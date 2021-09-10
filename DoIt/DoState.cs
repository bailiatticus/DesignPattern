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

            me.PlayGames();

            BadState badState = new BadState();

            me.SetState(badState);
            me.PlayGames();
        }
    }
}
