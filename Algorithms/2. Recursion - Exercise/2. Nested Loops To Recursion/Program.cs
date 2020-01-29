using System;

namespace _2._Nested_Loops_To_Recursion
{
    class Program
    {
        static void LoopRecursion(int[] arr,int index, int n)
        {
            if(index >=n)
            {
                Console.WriteLine(string.Join(" ",arr));
            }
            else
            {
                for(int i = 1;i<=n;++i)
                {
                    arr[index] = i;
                    LoopRecursion(arr, index+1, n);
                }
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            LoopRecursion(new int[n],0,n);
        }
    }
}
