using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7.Balanced_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Trim();

            var brackets = new Stack<char>(input.Length);

            if(input.Length % 2 != 0)
            {
                Console.WriteLine("NO");
            }

            foreach (var ch in input)
            {
                switch (ch)
                {
                    case '{':
                        brackets.Push(ch);
                        break;
                    case '}':
                        if(brackets.Count > 0)
                        {
                            if (brackets.Peek() == '{')
                            {
                                brackets.Pop();
                            }
                        }
                        break;
                    case '[':
                        brackets.Push(ch);
                        break;
                    case ']':
                        if (brackets.Count > 0)
                        {
                            if (brackets.Peek() == '[')
                            {
                                brackets.Pop();
                            }
                        }
                        break;
                    case '(':
                        brackets.Push(ch);
                        break;
                    case ')':
                        if (brackets.Count > 0)
                        {
                            if (brackets.Peek() == '(')
                            {
                                brackets.Pop();
                            }
                        }
                        break;
                }
            }
            if (brackets.Count > 0)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
        }
    }
}
