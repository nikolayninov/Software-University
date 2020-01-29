using System;
using System.Linq;
namespace _1._Reverse_Array
{
    class Program
    {
        static int[] ReverseArray(int[] arr,int[] vec,int start,int num)
        {
            if (num < 0)
            {
                return vec;
            }
            vec[start++] = arr[num--];
            return ReverseArray(arr, vec, start, num);
        }
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray<int>();
            int[] vec = new int[arr.Length];
            Console.WriteLine(string.Join(" ",ReverseArray(arr,vec,0,arr.Length-1)));
        }
    }
}
