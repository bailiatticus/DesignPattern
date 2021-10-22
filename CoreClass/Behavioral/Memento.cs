using System;
using System.Collections.Generic;
using System.Text;

namespace CoreClass.Behavioral
{
    [Serializable]
    public class Girl
    {
        public string Name { get; set; }
        public Int32 Age { get; set; }
        public Int32 Status { get; set; }
    }

    public class Collection
    {
        public List<Girl> Girls { set; get; }

        public Collection(List<Girl> girls)
        {
            Girls = girls;
        }

        public void ReloadPicture(Picture picture)
        {
            if (picture != null && picture.Info != null)
            {
                Girls = picture.Info;
            }
        }

        public Picture CreatePicture()
        {
            //string temp = PackReflectionEntity<List<Girl>>.GetEntityToString(Girls);
            return new Picture(Girls);
        }

        public void ShowCollection()
        {
            foreach (var girl in Girls)
            {
                Console.WriteLine($"{girl.Name} is {girl.Age}, Status is {girl.Status}");
            }
            Console.WriteLine();
        }
    }

    public class Picture
    {
        public List<Girl> Info { set; get; }

        public Picture(List<Girl> info)
        {
            List<Girl> NewL = new List<Girl>();
            foreach(var old in info)
            {
                NewL.Add(new Girl() { Name = old.Name, Age = old.Age, Status = old.Status });
            }

            Info = NewL;
        }

        /*
        public void Snapshot(Collection collection)
        {
            if(collection != null)
            {
                Info = new List<Girl>(collection.Girls);
            }
        }
        */

        public void ShowCollection()
        {
            foreach (var girl in Info)
            {
                Console.WriteLine($"{girl.Name} is {girl.Age}, Status is {girl.Status}");
            }
            Console.WriteLine();
        }
    }

    public class Manager
    {
        public Dictionary<string, Picture> Pictures { get; set; } = new Dictionary<string, Picture>();

        public void Add(Picture p)
        {
            this.Pictures.Add(DateTime.Now.ToString(), p);
        }
    }
}
