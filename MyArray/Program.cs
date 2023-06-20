using MyLib;
namespace MyArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Array<int> array = new();
            array.Add(1);
            array.Add(2);
            array.Add(3);
            array.Add(4);
            array.Add(5);
            array.Print();
            //Console.WriteLine(array.RemoveAt(2));
            //Console.WriteLine(array.Insert(111, 2));
            array.Pop();
            array.Print();
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
        }
    }
}
