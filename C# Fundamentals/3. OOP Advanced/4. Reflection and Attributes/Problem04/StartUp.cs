using System;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Problem04
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var type = typeof(Rich);

            // var fields = type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static);
            // // var fields = type.GetFields((BindingFlags)62);

            // var constructorInfo = type.GetConstructor(new Type[] {typeof(string)});
            // constructorInfo.Invoke(new object[]{"Address 123"});


            // var allMethods = type.GetMethods(BindingFlags.Public | BindingFlags.NonPublic |
            //                                 BindingFlags.Instance | BindingFlags.Static | BindingFlags.FlattenHierarchy);
            // // var allMethod = type.GetMethods((BindingFlags)60);

            // foreach (var item in allMethods)
            // {
            //     System.Console.WriteLine(item.Name);
            // }

            // var instance = Activator.CreateInstance(type);
            var instance = Activator.CreateInstance(type, new object[] { "new address" });

            var firstMethod = type.GetMethod("Hello", new Type[] { typeof(string) });

            var res = firstMethod.Invoke(instance, new object[] { "Stoyan" });
            System.Console.WriteLine(res);
        }
    }
}
