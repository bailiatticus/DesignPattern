using System;
using System.Collections.Generic;
using System.Text;

namespace CoreClass
{
    public abstract class Hero
    {
        public abstract void Show();
    }

    public class AntiMagic : Hero
    {
        public override void Show()
        {
            Console.WriteLine("魔法终结于此");
        }
    }

    public abstract class Decoration : Hero
    {
        protected Hero _hero;

        public Decoration(Hero hero)
        {
            this._hero = hero;
        }
        public override void Show()
        {
            if (_hero != null)
            {
                _hero.Show();
            }
        }
    }

    public class HelmetD : Decoration
    {
        public HelmetD(Hero deco) : base(deco)
        {
        }

        public override void Show()
        {
            ShowHelmet();
            base.Show();
        }

        private void ShowHelmet()
        {
            Console.Write("罪恶生还者头盔；");
        }
    }

    public class ArmourD : Decoration
    {
        public ArmourD(Hero deco) : base(deco)
        {
        }

        public override void Show()
        {
            ShowArmour();
            base.Show();
        }

        private void ShowArmour()
        {
            Console.Write("罪恶生还者铠甲；");
        }
    }
}
