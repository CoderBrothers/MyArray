using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Collections
{
    public class Array<T> : IEnumerable<T>
    {
        private T[] _array;
        private int _length;
        public int Length
        {
            get => _length;
            private set { _length = value; } 
        }

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

        public void Pop()
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

        public bool Contains(T value)
        {
            foreach (T item in _array)
            {
                if (item.Equals(value)) return true;

            }
            return false;
        }

        //public  bool Distinct(T value)
        //{
           
        //}

       
        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)_array).GetEnumerator();
        }

        IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _array.GetEnumerator();
        }
    }
}
