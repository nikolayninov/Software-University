namespace P02_BlackBoxInteger
{
    using System;
    using System.Reflection;
    using System.Linq;
    public class BlackBoxIntegerTests
    {
        public static void Main()
        {
            var type = typeof(BlackBoxInteger);
            var flags = BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static;

            var constructor = type.GetConstructor(flags, null, new Type[] { typeof(int) }, null);
            var instance = (BlackBoxInteger)constructor.Invoke(new object[] { 0 });

            var field = type.GetField("innerValue", flags);

            string[] input = Console.ReadLine().Split('_').ToArray();
            while (input[0] != "END")
            {
                int value = Int32.Parse(input[1]);

                MethodInfo method = type.GetMethod(input[0], flags);
                method.Invoke(instance, new object[] { value });

                System.Console.WriteLine(field.GetValue(instance));

                input = Console.ReadLine().Split('_').ToArray();
            }
        }
    }
}
