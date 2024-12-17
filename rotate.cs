using System;
using System.Linq;

namespace rotate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int number = 2;
            int len = arr.Length;
            int[] arr2 = new int[len];
            Array.Copy(arr, len - number, arr2, 0, number);
            Array.Copy(arr, 0, arr2, number, len - number);
            Console.WriteLine(string.Join(", ", arr2));
        }
    }
}
