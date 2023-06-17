using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyArray
{
    internal class Array<T>
    {
        private T[] _array;
        public int Length { get; set; }

        public Array()
        {
            Length = 0;
            _array = new T[Length];
        }

        public void Print()
        {
            foreach (T element in _array)
            {
                Console.Write(element + "\t");
            }

            Console.WriteLine();
        }

        public void Clear()
        {
            Length = 0;
            _array = new T[Length];
        }

        public void Add(T value)
        {
            Length++;
            T[] tmp = new T[Length];
            for (int i = 0; i < _array.Length; i++)
            {
                tmp[i] = _array[i];
            }

            tmp[Length - 1] = value;
            _array = tmp;
        }

        public bool RemoveAt(int index)
        {
            if (index >= Length || index < 0) return false;
            Length--;
            T[] tmp = new T[Length];
            for (int i = 0; i < index; i++)
            {
                tmp[i] = _array[i];
            }

            for (int i = index + 1; i < _array.Length; i++)
            {
                tmp[i - 1] = _array[i];
            }

            _array = tmp;
            return true;
        }

        public void Remove()
        {
            Length--;
            T[] tmp = new T[Length];
            for (int i = 0; i < Length; i++)
            {
                tmp[i] = _array[i];
            }

            _array = tmp;
        }

        public bool Insert(T value, int index)
        {
            if (index >= Length || index < 0) return false;
            Length++;
            T[] tmp = new T[Length];
            for (int i = 0; i < index; i++)
                tmp[i] = _array[i];
            tmp[index] = value;
            for (int i = index; i < _array.Length; i++)
                tmp[i + 1] = _array[i];

            _array = tmp;
            return true;
        }
        public interface IEnumerable
        {
            IEnumerator GetEnumerator();
        }
    }
}
