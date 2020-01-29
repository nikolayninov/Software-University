using System;

namespace _1._Array_Sum
{
    class Program
    {
        static int Sum(int[] arr,int index)
        {
            if (index == arr.Length)
            {
                return 0;
            }
            return arr[index] + Sum(arr, index+1);
        }
        static void Main(string[] args)
        {
            var numbers = new[] { 1, 2, 3, 4, 5 ,1,1,1,1,1,1,1,1,1,1};
            var sum = Sum(numbers, 0);
            Console.WriteLine(sum);
        }
    }
}
