using System;
using System.Collections.Generic;
using System.Text;

namespace CoreClass
{
    public interface IFaviratorList<T>
    {
        public abstract Iiterator<T> GetIterator();
    }
    
    public interface Iiterator<T>
    {
        public bool isEnd();

        public T GetCurrent();

        public void Next();

        public void Reset();
    }

    public class BookStore : IFaviratorList<string>
    {
        private string[] booklist;

        public BookStore()
        {
            booklist = new string[3];
            booklist[0] = "一个陌生女人的来信";
            booklist[1] = "大卫科波菲尔";
            booklist[2] = "简爱";
        }

        public Iiterator<string> GetIterator()
        {
            return new BookIterator(this);
        }

        public string GetItem(int index)
        {
            return booklist[index];
        }

        public int GetLength()
        {
            return booklist.Length;
        }
    }

    public class BookIterator : Iiterator<string>
    {
        private int _index = 0;

        private BookStore _target;

        public BookIterator(BookStore target)
        {
            _target = target;
        }

        public string GetCurrent()
        {
            return _target.GetItem(_index);
        }

        public bool isEnd()
        {
            if (_index < _target.GetLength()) return false;
            else return true;
        }

        public void Next()
        {
            _index++;
        }

        public void Reset()
        {
            _index = 0;
        }
    }
}
