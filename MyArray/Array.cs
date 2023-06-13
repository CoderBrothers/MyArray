﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyArray
{
    internal class Array<T>
    {
        private T[] _array;
        private int _length;

        public Array()
        {
            _length = 0;
            _array = new T[_length];
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
            _length = 0;
            _array = new T[_length];
        }

        public void Add(T value)
        {
            _length++;
            T[] tmp = new T[_length];
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
            T[] tmp = new T[_length];
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
            _length--;
            T[] tmp = new T[_length];
            for (int i = 0; i < _length; i++)
            {
                tmp[i] = _array[i];
            }

            _array = tmp;
        }

        public bool Insert(T value, int index)
        {
            if (index >= _length || index < 0) return false;
            _length++;
            T[] tmp = new T[_length];
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
