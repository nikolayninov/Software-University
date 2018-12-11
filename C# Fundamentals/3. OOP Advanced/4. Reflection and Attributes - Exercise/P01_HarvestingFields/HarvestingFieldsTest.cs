namespace P01_HarvestingFields
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class HarvestingFieldsTest
    {
        public static void Main()
        {
            var type = typeof(HarvestingFields);

            string input;
            while ((input = Console.ReadLine().ToLower()) != "harvest")
            {
                Func<FieldInfo, bool> condition = x => true;

                if (input == "public")
                    condition = x => x.IsPublic;
                else if (input == "protected")
                    condition = x => x.IsFamily;
                else if (input == "private")
                    condition = x => x.IsPrivate;

                FieldInfo[] fields = type.GetFields((BindingFlags)60);

                foreach (var field in fields.Where(condition))
                {
                    System.Console.WriteLine($"{field.Attributes.ToString().ToLower().Replace("family", "protected")} {field.FieldType.Name} {field.Name}");
                }
            }
        }
    }
}
