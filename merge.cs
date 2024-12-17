using System;
using System.Linq;

namespace merge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 4, 5 };
            int[] arr2 = { 5, 6, 7, 8, 9 };
            int[] arr3 = arr1.Concat(arr2).ToArray();
            Console.WriteLine(string.Join(", ", arr3));
        }
    }
}
