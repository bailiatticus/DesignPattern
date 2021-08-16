using System;
using System.Collections.Generic;
using System.Text;

namespace CoreClass
{
    public sealed class SingletonBase
    {
        private static SingletonBase instance = null;

        private SingletonBase()
        {

        }

        public static SingletonBase Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SingletonBase();
                }
                return instance;
            }
        }
    }

    public sealed class SingletonThreadSafe
    {
        private static SingletonThreadSafe instance = null;
        private static readonly object _lock = new Object();

        private SingletonThreadSafe()
        {

        }

        public static SingletonThreadSafe Instance
        {
            get
            {
                lock (_lock)
                {
                    if (instance == null)
                    {
                        instance = new SingletonThreadSafe();
                    }
                }
                return instance;
            }
        }
    }

    public sealed class SingletonDoubleLock
    {
        private static SingletonDoubleLock instance = null;
        private static readonly object _lock = new Object();

        private SingletonDoubleLock()
        {

        }

        public static SingletonDoubleLock Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (_lock)
                    {
                        if (instance == null)
                        {
                            instance = new SingletonDoubleLock();
                        }
                    }
                }
                return instance;
            }
        }
    }

    public sealed class SingletonStatic
    {
        private SingletonStatic()
        {

        }

        public static SingletonStatic Instance { get; } = new SingletonStatic();
    }

    public sealed class SingletonStaticIntial
    {
        private class Nested
        {
            public static readonly SingletonStaticIntial instance = new SingletonStaticIntial();
        }

        private SingletonStaticIntial() { }
        public static SingletonStaticIntial Instance { get; }
            = Nested.instance;
    }

    public sealed class SingletonLazy
    {
        private static readonly Lazy<SingletonLazy> sl = new Lazy<SingletonLazy>(() => new SingletonLazy());

        private SingletonLazy() { }
        public static SingletonLazy Instance { get; }
            = sl.Value;
    }
}
