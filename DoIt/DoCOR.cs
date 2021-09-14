using CoreClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoIt
{
    public class DoCOR
    {
        public static void Do()
        {
            Ask a1 = new Ask() { Count = 1, Thing = "Computer" };
            a1.Asking();

            Ask a2 = new Ask() { Count = 10, Thing = "Computer" };
            a2.Asking();

            ApproveLv1 ap1 = new ApproveLv1("manager");            
            ApproveLv0 ap0 = new ApproveLv0("CEO");

            ap1.NextApprove = ap0;

            ap1.Approving(a1);
            ap1.Approving(a2);
        }
    }
}
