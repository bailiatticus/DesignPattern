using System;
using System.Collections.Generic;
using System.Text;

namespace CoreClass
{
    public abstract class AbstractFile
    {
        public string Name { get; set; }

        public AbstractFile(string name)
        {
            Name = name;
        }

        public abstract void ShowInfo(int sub = 0);

        public abstract void AddF(AbstractFile target);
        public abstract void RemoveF(AbstractFile target);
    }

    public class TxtFile : AbstractFile
    {
        public TxtFile(string name) : base(name)
        {

        }

        public override void AddF(AbstractFile target)
        {            
        }

        public override void RemoveF(AbstractFile target)
        {            
        }

        public override void ShowInfo(int sub)
        {
            Console.WriteLine(new string('-', sub) + $"This is Txt File: {Name}");
        }
    }

    public class PngFile : AbstractFile
    {
        public PngFile(string name) : base(name)
        {

        }

        public override void AddF(AbstractFile target)
        {           
        }

        public override void RemoveF(AbstractFile target)
        {            
        }

        public override void ShowInfo(int sub)
        {
            Console.WriteLine(new string('-', sub) + $"This is Png File: {Name}");
        }
    }

    public class Folder : AbstractFile
    {
        private List<AbstractFile> items = new List<AbstractFile>();

        public Folder(string name) : base(name)
        {

        }

        public override void AddF(AbstractFile target)
        {
            items.Add(target);
        }

        public override void RemoveF(AbstractFile target)
        {
            items.Remove(target);
        }

        public override void ShowInfo(int sub)
        {
            Console.WriteLine(new string('-', sub) + $"This is Folder: {Name}");
            foreach(var item in items)
            {
                item.ShowInfo(sub + 1);
            }
        }
    }
}
