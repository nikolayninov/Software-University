using System;

namespace _3._0_1_Vector
{
    class Program
    {
        static void Generate(int maxNum,int index, int[] arr)
        {
            if (index >= arr.Length)
            {
                Console.WriteLine(string.Join(" ",arr));
            }
            else
            {
                for(int i =0;i<= maxNum; ++i)
                {
                    arr[index] = i;
                    Generate(maxNum,index + 1, arr);
                }
            }

        }
        static void Main(string[] args)
        {
            var arr = new int[8];
            Generate(3,0, arr);
        }
    }
}
