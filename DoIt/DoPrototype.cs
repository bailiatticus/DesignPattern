using CoreClass;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoIt
{
    public static class DoPrototype
    {
        public static void Do()
        {
            Naruto n_real = new Naruto();
            NinJa n_fake = n_real.NinJaCopy();
            Sasuke s_real = new Sasuke();
            NinJa s_fake = s_real.NinJaCreate();
            Console.WriteLine("begin");
            Console.WriteLine(JsonConvert.SerializeObject(n_real));
            Console.WriteLine(JsonConvert.SerializeObject(n_fake)); 
            Console.WriteLine(JsonConvert.SerializeObject(s_real)); 
            Console.WriteLine(JsonConvert.SerializeObject(s_fake));

            Console.WriteLine("change n_real");
            n_real.Skill1 = "Shuilongdan";
            n_real.attributeSkill.Attribution = "mizu";
            Console.WriteLine("n_real:" + JsonConvert.SerializeObject(n_real));
            Console.WriteLine("n_fake:" + JsonConvert.SerializeObject(n_fake));

            Console.WriteLine("change n_real2");
            n_real.attributeSkill = new AttributeSkill() { Attribution = "ka", BaseSkill = "Haohuoqiu" };
            Console.WriteLine("n_real:" + JsonConvert.SerializeObject(n_real));
            Console.WriteLine("n_fake:" + JsonConvert.SerializeObject(n_fake));

            Console.WriteLine("change s_real");
            s_real.Skill1 = "Dapubu";
            s_real.attributeSkill.Attribution = "moku";
            Console.WriteLine("s_real:" + JsonConvert.SerializeObject(s_real));
            Console.WriteLine("s_fake:" + JsonConvert.SerializeObject(s_fake));

            Console.WriteLine("change s_fake");
            s_fake.attributeSkill = new AttributeSkill() { Attribution = "ka", BaseSkill = "Huolongyangdan" };
            Console.WriteLine("s_real:" + JsonConvert.SerializeObject(s_real));
            Console.WriteLine("s_fake:" + JsonConvert.SerializeObject(s_fake));

            /*
            Console.WriteLine("change n_real");
            n_real.Skill1 = "Shuilongdan";
            n_real.attributeSkill.Attribution = "mizu";
            Console.WriteLine("n_real:" + JsonConvert.SerializeObject(n_real));
            Console.WriteLine("n_fake:" + JsonConvert.SerializeObject(n_fake));
            Console.WriteLine("s_real:" + JsonConvert.SerializeObject(s_real));
            Console.WriteLine("s_fake:" + JsonConvert.SerializeObject(s_fake));

            Console.WriteLine("change n_fake");
            n_fake.Skill1 = "Shiziliandan";
            n_fake.attributeSkill.Attribution = "mizu";
            Console.WriteLine("n_real:" + JsonConvert.SerializeObject(n_real));
            Console.WriteLine("n_fake:" + JsonConvert.SerializeObject(n_fake));
            Console.WriteLine("s_real:" + JsonConvert.SerializeObject(s_real));
            Console.WriteLine("s_fake:" + JsonConvert.SerializeObject(s_fake));

            Console.WriteLine("change s_real");
            s_real.Skill1 = "Xuzuo";
            s_real.attributeSkill.Attribution = "ki";
            Console.WriteLine("n_real:" + JsonConvert.SerializeObject(n_real));
            Console.WriteLine("n_fake:" + JsonConvert.SerializeObject(n_fake));
            Console.WriteLine("s_real:" + JsonConvert.SerializeObject(s_real));
            Console.WriteLine("s_fake:" + JsonConvert.SerializeObject(s_fake));

            Console.WriteLine("change s_fake");
            s_fake.Skill1 = "Xuzuo";
            s_fake.attributeSkill.Attribution = "ki";
            Console.WriteLine("n_real:" + JsonConvert.SerializeObject(n_real));
            Console.WriteLine("n_fake:" + JsonConvert.SerializeObject(n_fake));
            Console.WriteLine("s_real:" + JsonConvert.SerializeObject(s_real));
            Console.WriteLine("s_fake:" + JsonConvert.SerializeObject(s_fake));
            */
        }
    }
}
