using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Maximum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var st = new Stack<int>(n);
           
            for (int i = 0; i < n; i++)
            {
                var command = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                if ( command[0] == 1 )
                {
                    st.Push(command[1]);
                }
                else if( command[0] == 2)
                {
                    st.Pop();
                }
                else
                {
                    if(st.Count > 0)
                    {
                        int biggestNum = int.MinValue;
                        foreach (var num in st)
                        {
                            if(num > biggestNum)
                            {
                                biggestNum = num;
                            }
                        }
                        Console.WriteLine(biggestNum);
                    }
                }
            }
        }
    }
}
