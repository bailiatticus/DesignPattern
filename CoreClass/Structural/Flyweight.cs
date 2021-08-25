using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CoreClass
{
    public abstract class Weapon
    {
        public abstract void Use();
    }

    public class Sword : Weapon
    {
        private string _name;

        public Sword(string name)
        {
            _name = name;
        }
        public override void Use()
        {
            Console.WriteLine($"{_name} is Using");
        }
    }

    public class SwordFactory
    {
        private Hashtable swords = new Hashtable();

        public SwordFactory(List<string> names)
        {
            foreach(var name in names)
            {
                swords.Add(name, new Sword(name));
            }

            /*
            swords.Add("龙泉", new Sword("龙泉"));
            swords.Add("轩辕", new Sword("轩辕"));
            swords.Add("墨梅", new Sword("墨梅"));
            */
        }

        public Weapon GetWeapon(string name)
        {
            if (swords.ContainsKey(name)) return swords[name] as Weapon;
            else return new Sword(name);
        }
    }
}
