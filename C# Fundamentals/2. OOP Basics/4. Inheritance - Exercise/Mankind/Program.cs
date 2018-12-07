using System;
using System.Linq;

namespace Mankind
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentInpt = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var workerInpt = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            try
            {
                Student student = new Student(studentInpt[0], studentInpt[1], studentInpt[2]);
                Worker worker = new Worker(workerInpt[0], workerInpt[1], decimal.Parse(workerInpt[2]), decimal.Parse(workerInpt[3]));
                System.Console.WriteLine(student);
                System.Console.WriteLine(worker);
            }
            catch (ArgumentException ex)
            {
                System.Console.WriteLine(ex.Message);
            }

        }
    }
}