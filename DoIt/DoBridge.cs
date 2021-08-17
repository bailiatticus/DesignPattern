using CoreClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoIt
{
    public class DoBridge
    {
        public static void Do()
        {
            HumanPAct humanPAct = new HumanPAct();

            HumanAct jack = new HumanAct();
            jack.SetPAct(humanPAct);
            jack.Learn();
            jack.Listen();

            AnimalPAct animalPAct = new AnimalPAct();

            AnimalAct animalAct = new AnimalAct();
            animalAct.SetPAct(animalPAct);
            animalAct.Learn();
            animalAct.Listen();

            HumanAct frack = new HumanAct();
            frack.SetPAct(animalPAct);
            frack.Learn();
            frack.Listen();
        }
    }
}
