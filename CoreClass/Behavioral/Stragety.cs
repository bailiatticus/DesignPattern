using System;
using System.Collections.Generic;
using System.Text;

namespace CoreClass
{
    public class Gamer2
    {
        public Platform Platform { set; get; }

        public Gamer2(Platform platform)
        {
            Platform = platform;
        }

        public void PlayGames()
        {
            Platform.ShowPlayform();
        }
    }

    public abstract class Platform
    {
        public abstract void ShowPlayform();
    }

    public class NSPlatform : Platform
    {
        public override void ShowPlayform()
        {
            Console.WriteLine("ns game is great");
        }
    }

    public class PSPlatform : Platform
    {
        public override void ShowPlayform()
        {
            Console.WriteLine("ps game is good");
        }
    }
}
