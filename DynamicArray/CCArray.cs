using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArray
{
    class CCArray<T> : IArray<T>
    {
        private T[] arr = new T[0];

        public void Add(T item)
        {
            ValidObject(item);
            Resize();
            arr[arr.Length - 1] = item;
        }

        public void Add(T item, dynamic index)
        {
            ValidObject(item);
            ValidIndex(index);
            Resize();
            T[] temp = arr;
            for (dynamic i = 0; i < arr.Length; i++)
            {
                if (i == index)
                {
                    for (dynamic k = i + 1; k <= arr.Length - 1; k++)
                    {
                        temp[k] = arr[k];
                    }
                    temp[i] = item;
                }
                break;
            }
            arr = temp;
        }

        public T Get(dynamic index)
        {
            ValidIndex(index);
            dynamic counter = 0;
            foreach (T item in arr)
            {
                if (counter == index)
                {
                    return item;
                }
                counter++;
            }
            return default(T);
        }

        public void Replace(T item, dynamic index)
        {
            ValidObject(item);
            ValidIndex(index);
            for (dynamic i = 0; i < arr.Length; i++)
            {
                if (i == index)
                {
                    arr[i] = item;
                }
            }
        }

        public void Remove(dynamic index)
        {
            ValidIndex(index);
            T[] temp = new T[arr.Length - 1];
            dynamic counter = 0;
            for (dynamic i = 0; i < arr.Length; i++)
            {
                if (i != index)
                {
                    temp[counter] = arr[i];
                    counter++;
                }
            }
            arr = temp;
        }

        public override String ToString()
        {
            String array = "[ ";
            foreach (T item in arr)
            {
                array += item;
                if (!item.Equals(arr[arr.Length - 1]))
                {
                    array += ", ";
                }
            }
            return array += " ]";
        }

        private void ValidIndex(dynamic index)
        {
            if (index >= arr.Length)
            {
                throw new IndexOutOfRangeException("Index is bigger than array size");
            }
        }

        private void Resize()
        {
            T[] temp = new T[arr.Length + 1];
            for (dynamic i = 0; i < arr.Length; i++)
            {
                temp[i] = arr[i];
            }
            arr = temp;
        }

        private void ValidObject(object item)
        {
            if (!(item is T))
            {
                throw new ArrayTypeMismatchException(string.Format("Only {0} can be added to this array!", arr.GetType()));
            }
        }
    }
}
