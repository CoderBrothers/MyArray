using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyArray
{
    internal class Array
    {
        private int[] array;
        public Array()
        {
            array = new int[0];
        }
        public void Print()
        {
            foreach (int element in array)
            {
                Console.Write(element + "\t");
            }
            Console.WriteLine();
        }
        public void Clear()
        {
            array = new int[0];
        }
        public void Add(ref int[] array, int value, int index)
        {
            int[] newArray = new int[array.Length + 1];
            newArray[index] = value;
            for (int i = 0; i < index; i++)
            {
                newArray[i] = array[i];
            }
            for (int i = index; i < array.Length; i++)
            {
                newArray[i + 1] = array[i];
            }
            array = newArray;
        }
        public void Remove(ref int[] arrray, int index)
        {
            int[]newArray = new int[arrray.Length - 1];
            for (int i = 0;i < index; i++)
            {
                newArray[i] = arrray[i];
            }
            for (int i = index + 1; i < array.Length; i++)
            {
                newArray[i - 1] = array[i];
            }
            array = newArray;
        }
	public void Insert(int value, int index) 
        {
            int[] newArray = new int[array.Length + 1];
            newArray[index] = value;
            for (int i = 0; i < index; i++)
                newArray[i] = array[i];
            for(int i = index; i < array.Length; i++)
                newArray[i + 1] = array[i];

            array = newArray;
        }
    }
}
