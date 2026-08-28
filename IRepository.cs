using System;
using System.Collections.Generic;
using System.Text;

namespace C__Advanced_01
{
    internal interface IRepository<T> where T : struct
    {
        void Add(T item);
        T Get(int id);
        void Delete(int id);
    }
}
