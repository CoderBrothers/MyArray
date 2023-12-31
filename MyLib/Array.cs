﻿using System;
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
        public T this[int index]
        {
            get => _array[index];
            set => _array[index] = value;
        }

        public Array()
        {
            Length = 0;
            _array = new T[Length];
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

        public T Pop()
        {
            Length--;
            T[] tmp = new T[Length];
            for (int i = 0; i < Length; i++)
            {
                tmp[i] = _array[i];
            }
            T removed = _array[Length];
            _array = tmp;
            return removed;
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

	    public bool Remove(T value) => RemoveAt(IndexOf(value));

        public int IndexOf(T value)
        {
            for (int i = 0; i < Length; i++)
            {
                if (_array[i].Equals(value))
                {
                    return i;
                }
            }
            return -1;
        } 

	    public IEnumerable<T> Distinct()
        {
            for (int i = 0; i < _array.Length; i++)
            {
                bool isUnique = true;
                for (int j = i + 1; j < _array.Length; j++)
                {
                    if (Equals(_array[i], _array[j]))
                    {
                        isUnique = false;
                        break;
                    }
                }

                if (isUnique)
                {
                    yield return _array[i];
                }
            }
        }

        public bool IsEmpty() => !(_array.Length > 0);

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
