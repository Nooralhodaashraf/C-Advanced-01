using System;
using System.Collections.Generic;
using System.Text;

namespace C__Advanced_01
{
    internal class Factory<T> where T : new()
    {
         public T Create()
            {
                return new T();
            }
        }
    }
