using System;
using System.Linq;

namespace _01._Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] nums = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            int bestInd = 0;
            int bestLen = 0;

            int currLen = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if(nums[i] == nums[j])
                    {
                        currLen++;
                    }
                    else
                    {
                        if(currLen > bestLen)
                        {
                            bestLen = currLen;
                            bestInd = j - currLen;
                        }
                        break;
                    }
                }
            }
            for (int i = bestInd; i < bestLen - 2; i++)
            {
                Console.Write(nums[i] + " ");
            }
        }
    }
}