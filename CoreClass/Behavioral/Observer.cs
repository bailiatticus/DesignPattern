using System;
using System.Collections.Generic;
using System.Text;

namespace CoreClass
{
    public abstract class AWuXingFaZhen
    {

        public string Info { get; set; }

        public AWuXingFaZhen(string info)
        {
            Info = info;
        }

        private List<IObserver> _observers = new List<IObserver>();
        

        public void AddObserver(IObserver target)
        {
            _observers.Add(target);
        }

        public void RemoveObserver(IObserver target)
        {
            _observers.Remove(target);
        }

        public void CallEmergence()
        {
            foreach(var observer in _observers)
            {
                observer.CallbackEmergence(this);
            }
        }
    }
    
    public class HumanWuXingFaZhan : AWuXingFaZhen
    {
        public HumanWuXingFaZhan(string info) : base(info)
        {

        }
    }

    public interface IObserver
    {
        public void CallbackEmergence(AWuXingFaZhen aWuXingFaZhen);
    }

    public class WuXingShiZhe : IObserver
    {
        public string Name { get; set; }

        public WuXingShiZhe(string name)
        {
            Name = name;
        }

        public void CallbackEmergence(AWuXingFaZhen aWuXingFaZhen)
        {
            Console.WriteLine(aWuXingFaZhen.Info + $"|{Name} is Known");
        }
    }
}
