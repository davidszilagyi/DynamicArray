using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArray
{
    interface IArray<T>
    {
        void Add(T item);

        void Add(T item, int index);

        T Get(int index);

        void Replace(T item, int index);

        void Remove(int index);

        String ToString();
    }
}
