using CoreClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoIt
{
    public class DoFlyweight
    {
        public static void Do()
        {
            List<string> swordNames = new List<string>();
            swordNames.Add("龙泉");
            swordNames.Add("墨眉");
            swordNames.Add("轩辕");

            SwordFactory mySwordF = new SwordFactory(swordNames);

            Weapon w1 = mySwordF.GetWeapon("墨眉");
            w1.Use();
            Weapon w2 = mySwordF.GetWeapon("轩辕");
            w2.Use();
            Weapon w3 = mySwordF.GetWeapon("天问");
            w3.Use();

        }
    }
}
