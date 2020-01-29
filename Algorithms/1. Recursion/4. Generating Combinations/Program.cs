using System;

namespace _4._Generating_Combinations
{
    class Program
    {
        static void Generate(int[] set, int[] vec,int index, int border)
        {
            if(index>= vec.Length)
            {
                Console.WriteLine(string.Join(" ",vec));
            }
            else
            {
                for(int i = border+1;i<set.Length;++i)
                {
                    vec[index] = set[i];
                    Generate(set, vec, index + 1, i);
                }
            }
        }
        static void Main(string[] args)
        {
            int[] nums = new[] { 1,2,3,4,5};
            int[] vec = new int[3];
            Generate(nums, vec, 0, -1);
        }
    }
}
