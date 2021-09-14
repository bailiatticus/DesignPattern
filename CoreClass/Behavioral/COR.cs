using System;
using System.Collections.Generic;
using System.Text;

namespace CoreClass
{
    public class Ask
    {
        public string Thing { get; set; }

        public int Count { get; set; }

        public void Asking()
        {
            Console.WriteLine($"Asking thing, name:{Thing},Count:{Count}");
        }
    }

    public abstract class Approve
    {
        public Approve NextApprove { get; set; }

        protected string _approveName;

        public Approve(string approveName)
        {
            _approveName = approveName;
        }

        public abstract void Approving(Ask ask);
    }

    public class ApproveLv1 : Approve
    {
        public ApproveLv1(string approveName) : base(approveName)
        {
            
        }

        public override void Approving(Ask ask)
        {
            if(ask.Count <= 1)
            {
                Console.WriteLine($"{this._approveName} is approved");
            }
            else
            {
                NextApprove.Approving(ask);
            }
        }
    }

    public class ApproveLv0 : Approve
    {
        public ApproveLv0(string approveName) : base(approveName)
        {

        }

        public override void Approving(Ask ask)
        {
            Console.WriteLine($"{this._approveName} is approved");
        }
    }
}
