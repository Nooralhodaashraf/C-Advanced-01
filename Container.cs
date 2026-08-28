using System;
using System.Collections.Generic;
using System.Text;

namespace C__Advanced_01
{
    internal class Container<T>
    {
        private T value;
        public void Add(T item)
        {
            value = item;
        }

        public T Get()
        {
            return value;
        }
    }
}
