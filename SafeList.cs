using System;
using System.Collections.Generic;
using System.Text;

namespace C__Advanced_01
{
    internal class SafeList<T>
    {
        private T[] items;

        public SafeList(int size)
        {
            items = new T[size];
        }

        public T Get(int index)
        {
            if (index < 0 || index >= items.Length)
            {
                return default;
            }

            return items[index];
        }

        public void Add(int index, T value)
        {
            if (index >= 0 && index < items.Length)
            {
                items[index] = value;
            }
        }
    }
}
