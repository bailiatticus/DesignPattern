using CoreClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoIt
{
    public class DoIterator
    {
        public static void Do()
        {
            IFaviratorList<string> myBS = new BookStore();
            Iiterator<string> myBSI = myBS.GetIterator();

            while(myBSI.isEnd() == false)
            {
                Console.WriteLine(myBSI.GetCurrent());
                myBSI.Next();
            }
            myBSI.Reset();

        }
    }
}
