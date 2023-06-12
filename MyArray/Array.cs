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
    }
}
