using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArray
{
    class CCArray<T>: IArray<T>
    {
        private T[] arr = new T[0];

        public void Add(T item)
        {
            throw new NotImplementedException();
        }

        public void Add(T item, int index)
        {
            throw new NotImplementedException();
        }

        public T Get(int index)
        {
            throw new NotImplementedException();
        }

        public void Replace(T item, int index)
        {
            throw new NotImplementedException();
        }

        public void Remove(int index)
        {
            throw new NotImplementedException();
        }
    }
}
