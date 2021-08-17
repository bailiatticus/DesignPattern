using System;
using System.Collections.Generic;
using System.Text;

namespace CoreClass
{
    public interface IPositiveAct
    {
        public void Voice();

        public void Action();
    }

    public class HumanPAct : IPositiveAct
    {
        public void Action()
        {
            Console.WriteLine("人类游戏");
        }

        public void Voice()
        {
            Console.WriteLine("人类说话");
        }
    }

    public class AnimalPAct : IPositiveAct
    {
        public void Action()
        {
            Console.WriteLine("动物叫");
        }

        public void Voice()
        {
            Console.WriteLine("动物打闹");
        }
    }

    public abstract class NagtiveAction
    {
        protected IPositiveAct _positiveAct;
        public void SetPAct(IPositiveAct positiveAct)
        {
            _positiveAct = positiveAct;
        }
        public abstract void Listen();

        public abstract void Learn();
    }

    public class HumanAct : NagtiveAction
    {
        public override void Learn()
        {
            Console.Write("Human Learn | ");
            _positiveAct.Voice();
        }

        public override void Listen()
        {
            Console.Write("Human Listen | ");
            _positiveAct.Action();
        }
    }

    public class AnimalAct : NagtiveAction
    {
        public override void Learn()
        {
            Console.Write("Animal Learn | ");
            _positiveAct.Action();
        }

        public override void Listen()
        {
            Console.Write("Animal Listen | ");
            _positiveAct.Voice();
        }
    }
}
