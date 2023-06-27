using Collections;
using System.Collections;

namespace MyArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Array<int> array = new();
            Collections.Stack<int> stack = new();
            array.Add(1);
            array.Add(3);
            array.Add(2);
            array.Add(3);
            array.Add(3);
            array.Add(4);
            array.Add(5);
            array.Add(5);
            array.Add(5);
            array.Add(1);
            array.Remove(1);
            //Console.WriteLine(array.RemoveAt(2));
            //Console.WriteLine(array.Insert(111, 2));
            array.Pop();
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine(array.Insert(0, 3));
            foreach (int number in array.Distinct())
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            Console.WriteLine(array[1]);
            Console.WriteLine(array[0]);
            Console.WriteLine(array.IsEmpty());
            array.Clear();
            Console.WriteLine(array.IsEmpty());
            Console.WriteLine();


            stack.Push(1);
            stack.Push(2);
            Console.WriteLine(stack.Peek());
            foreach (int i in stack)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine(stack.IsEmpty());
            stack.Clear();
            Console.WriteLine(stack.IsEmpty());
            //foreach (int i in stack)
            //{
            //    Console.Write(i + " ");
            //}
            //Console.WriteLine(stack.Peek());



            //System.Collections.Generic.Stack<int> stack2 = new();
            //stack2.Push(2);
            //stack2.Push(3);
            //foreach (int i in stack2)
            //{
            //    Console.Write(i + " ");
            //}
            //Console.WriteLine();
            //stack2.Clear();
            //foreach (int i in stack2)
            //{
            //    Console.Write(i + " ");
            //}
            //Console.WriteLine();
            //Console.WriteLine(stack2.Peek());
        }
    }
}
