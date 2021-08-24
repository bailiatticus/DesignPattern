using CoreClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoIt
{
    public class DoComposite
    {
        public static void Do()
        {
            AbstractFile file = new TxtFile("a.txt");
            file.ShowInfo();

            AbstractFile file2 = new PngFile("b.png");
            file2.ShowInfo();

            AbstractFile file3 = new TxtFile("c.txt");
            file3.ShowInfo();

            AbstractFile folder = new Folder("A");
            folder.AddF(file);
            folder.AddF(file3);
            folder.ShowInfo();

            AbstractFile folder2 = new Folder("B");
            folder2.AddF(folder);
            folder2.AddF(file2);
            folder2.AddF(file3);
            folder2.ShowInfo();

            folder2.RemoveF(folder);
            folder2.RemoveF(file3);
            folder2.ShowInfo();
            folder.AddF(folder2);
            folder.ShowInfo();
        }
    }
}
