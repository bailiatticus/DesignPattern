using CoreClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoIt
{
    public class DoMediator
    {
        public static void Do()
        {
            Translator xiaobawang = new Translator();

            Speaker s1 = new ChineseSpeaker(xiaobawang);
            Speaker s2 = new NiHonSpeaker(xiaobawang);
            Speaker s3 = new EnglishSpeaker(xiaobawang);

            xiaobawang.Speaker1 = s1;
            xiaobawang.Speaker2 = s2;
            xiaobawang.Speaker3 = s3;

            xiaobawang.Tanslate(s1);
        }
    }
}
