using System;

namespace _3._Combinations_with_Repetition
{
    class Program
    {
        static void GenCombs(int[] arr, int index, int num, int n)
        {
            if (index >= arr.Length)
            {
                Console.WriteLine(string.Join(" ", arr));
            }
            else
            {
                for (int i = num; i <= n; ++i)
                {
                    arr[index] = i;
                    GenCombs(arr, index + 1, i+1, n);
                }
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            GenCombs(new int[k], 0, 1, n);
        }
    }
}
