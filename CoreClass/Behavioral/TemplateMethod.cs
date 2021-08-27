using System;
using System.Collections.Generic;
using System.Text;

namespace CoreClass
{
    public abstract class PlayGames
    {
        public void Play()
        {
            Console.WriteLine("游玩步骤开始：");
            Begin();
            Mid();
            End();
        }

        public abstract void Begin();

        public abstract void Mid();               

        public abstract void End();
    }

    public class NS : PlayGames
    {
        public override void Begin()
        {
            Console.WriteLine("NS Power On");
        }

        public override void End()
        {
            Console.WriteLine("NS Power Off");
        }

        public override void Mid()
        {
            Console.WriteLine("Playing NS Games");
        }
    }
    public class PS4 : PlayGames
    {
        public override void Begin()
        {
            Console.WriteLine("PS4 Power On");
        }

        public override void End()
        {
            Console.WriteLine("PS4 Power Off");
        }

        public override void Mid()
        {
            Console.WriteLine("Playing PS4 Games");
        }
    }
}
