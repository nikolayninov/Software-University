using System;
using System.Linq;
using System.Reflection;

namespace Problem01
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var assembly = Assembly.LoadFile(@"P:\C#\C# Fundamentals\3. OOP Advanced\4. Reflection and Attributes\Demo\MyCrazyApp.dll");

            //Find all classes
            var allTypes = assembly.GetTypes();
            var asd = Activator.CreateInstance(allTypes[1]);
            System.Console.WriteLine(asd.ToString());
            foreach (var currentType in allTypes)
            {
                Console.WriteLine(currentType.Name);

                foreach (var propertyInfo in currentType.GetProperties())
                {
                    Console.WriteLine(propertyInfo.Name);
                }

                foreach (var methodInfo in currentType.GetMethods())
                {
                    Console.WriteLine(methodInfo.Name);
                }
            }

            //Create instance

            //Invoke method
        }
    }
}
