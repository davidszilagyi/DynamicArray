using System;

namespace DynamicArray
{
    interface IArray<T>
    {
        void Add(T item);

        void Add(T item, dynamic index);

        T Get(dynamic index);

        void Replace(T item, dynamic index);

        void Remove(dynamic index);

        String ToString();
    }
}
