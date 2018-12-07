using System.Text;
using System;
using System.Reflection;
using System.Linq;
public class Spy
{
    public string StealFieldInfo(string className, params string[] inputFields)
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine($"Class under investigation: {className}");

        var type = Type.GetType(className);

        var hackerInstance = Activator.CreateInstance(type);

        for (int i = 0; i < inputFields.Length; i++)
        {
            var currentField = type.GetField(inputFields[i], BindingFlags.Public |
                BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic);

            var value = currentField.GetValue(hackerInstance);
            sb.AppendLine($"{currentField.Name} = {value}");
        }
        return sb.ToString().TrimEnd();
    }
    public string AnalyzeAcessModifiers(string className)
    {
        StringBuilder sb = new StringBuilder();

        var type = Type.GetType(className);

        var hackerInstance = Activator.CreateInstance(type);

        var allFields = type.GetFields();
        var privateMethods = type.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance).Where(x => x.Name.StartsWith("get"));
        var publicMethods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance).Where(x => x.Name.StartsWith("set"));

        foreach (var field in allFields)
        {
            sb.AppendLine($"{field.Name} must be private!");
        }
        foreach (var methodInfo in privateMethods)
        {
            sb.AppendLine($"{methodInfo.Name} have to be public!");
        }

        foreach (var methodInfo in publicMethods)
        {
            sb.AppendLine($"{methodInfo.Name} have to be private!");
        }

        return sb.ToString().TrimEnd();
    }

}