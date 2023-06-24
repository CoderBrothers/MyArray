using Collections;
namespace MyArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Array<int> array = new();
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
            array.Print();
            //Console.WriteLine(array.RemoveAt(2));
            //Console.WriteLine(array.Insert(111, 2));
            array.Pop();
            array.Print();
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
        }
    }
}
