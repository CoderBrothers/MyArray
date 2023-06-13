using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyArray
{
    internal class Array
    {
        private int[] _array;
        private int _length;

        public Array()
        {
            _length = 0;
            _array = new int[_length];
        }

        public void Print()
        {
            foreach (int element in _array)
            {
                Console.Write(element + "\t");
            }

            Console.WriteLine();
        }

        public void Clear()
        {
            _length = 0;
            _array = new int[_length];
        }

        public void Add(int value)
        {
            _length++;
            int[] tmp = new int[_length];
            for (int i = 0; i < _array.Length; i++)
            {
                tmp[i] = _array[i];
            }

            tmp[_length - 1] = value;
            _array = tmp;
        }

        public bool RemoveAt(int index)
        {
            if (index >= _length || index < 0) return false;
            _length--;
            int[] tmp = new int[_length];
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

        public bool Insert(int value, int index)
        {
            if (index >= _length || index < 0) return false;
            _length++;
            int[] tmp = new int[_length];
            for (int i = 0; i < index; i++)
                tmp[i] = _array[i];
            tmp[index] = value;
            for (int i = index; i < _array.Length; i++)
                tmp[i + 1] = _array[i];

            _array = tmp;
            return true;
        }
    }
}
