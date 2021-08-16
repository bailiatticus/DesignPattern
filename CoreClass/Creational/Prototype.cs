using System;
using System.Collections.Generic;
using System.Text;

namespace CoreClass
{
    public class AttributeSkill
    {
        public string Attribution { get; set; }
        public string BaseSkill { get; set; }
    }

    public abstract class NinJa
    {
        public string Skill1 { get; set; }
        public string Skill2 { get; set; }
        public AttributeSkill attributeSkill { get; set; }

        // 影分身 浅拷贝
        public abstract NinJa NinJaCopy();

        // 转身术 深拷贝
        public abstract NinJa NinJaCreate();
    }

    public class Naruto : NinJa
    {
        public Naruto()
        {
            Skill1 = "Luoxuanwan";
            Skill2 = "Yingfenshen";
            attributeSkill = new AttributeSkill() { Attribution = "kaze", BaseSkill = Skill1 };
        }

        public override NinJa NinJaCopy()
        {
            return (Naruto)this.MemberwiseClone();
        }

        public override NinJa NinJaCreate()
        {
            Console.WriteLine("I cannot do that");
            return null;
        }
    }

    public class Sasuke : NinJa
    {
        public Sasuke()
        {
            Skill1 = "Qianniao";
            Skill2 = "Haohuoqiu";
            attributeSkill = new AttributeSkill() { Attribution = "kaminali", BaseSkill = Skill2 };
        }

        public override NinJa NinJaCopy()
        {
            return (NinJa)this.MemberwiseClone();
        }

        public override NinJa NinJaCreate()
        {
            Sasuke sasuke2 = (Sasuke)this.MemberwiseClone();

            // 类新建，复杂类可以使用序列化 反序列化
            sasuke2.attributeSkill = new AttributeSkill();
            sasuke2.attributeSkill.BaseSkill = this.attributeSkill.BaseSkill;
            sasuke2.attributeSkill.Attribution = this.attributeSkill.Attribution;

            return (NinJa)sasuke2;
        }
    }
}
