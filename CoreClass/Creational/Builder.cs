using System;
using System.Collections.Generic;
using System.Text;

namespace CoreClass
{
    public abstract class Builder
    {
        public abstract void InstallStep1();
        public abstract void InstallStep2();
        public abstract void InstallStep3();

        public abstract GumdanProduct GetGumdan();
    }

    public class Gundam00 : Builder
    {
        private GumdanProduct _00 = new GumdanProduct();
        public override GumdanProduct GetGumdan()
        {
            return _00;
        }

        public override void InstallStep1()
        {
            Console.WriteLine("Gundam00 install step 1");
            _00.Install("00 Part 1");
        }

        public override void InstallStep2()
        {
            Console.WriteLine("Gundam00 install step 2");
            _00.Install("00 Part 2");
        }

        public override void InstallStep3()
        {
            Console.WriteLine("Gundam00 install step 3");
            _00.Install("00 Part 3");
        }
    }

    public class GundamUC : Builder
    {
        private GumdanProduct uc = new GumdanProduct();

        public override GumdanProduct GetGumdan()
        {
            return uc;
        }

        public override void InstallStep1()
        {
            Console.WriteLine("GundamUC install step 1");
            uc.Install("UC part 1");
        }

        public override void InstallStep2()
        {
            Console.WriteLine("GundamUC install step 2");
            uc.Install("UC part 2");
        }

        public override void InstallStep3()
        {
            Console.WriteLine("GundamUC install step 3");
            uc.Install("UC part 3");
        }
    }

    public class GumdanProduct
    {
        private List<string> partLists = new List<string>();

        public void Install(string part)
        {
            partLists.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("Begin install...");
            foreach (var part in partLists)
            {
                Console.WriteLine($"part:{part} is installing");
            }
            Console.WriteLine("installing is finish");
        }
    }

    public class Director
    {
        public GumdanProduct Command(Builder bu)
        {
            bu.InstallStep1();
            bu.InstallStep2();
            bu.InstallStep3();
            return bu.GetGumdan();
        }
    }
}
