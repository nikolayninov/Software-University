using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Tagram
{
    class Program
    {
        static void Main(string[] args)
        {
            string command;
            var data = new Dictionary<string, Dictionary<string, long>>();

            while ((command = Console.ReadLine()) != "end")
            {
                if(command.Substring(0,3).ToString() == "ban")
                {                       
                    string personToBan = command.Split(' ').ToArray()[1];    
                    if(data.ContainsKey(personToBan))
                    {
                        data.Remove(personToBan);
                    }
                }
                else
                {
                    var attrs = command.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                    string name = attrs[0];
                    string tag = attrs[1];
                    int likes = Int32.Parse(attrs[2]);

                    if(!data.ContainsKey(name))
                    {
                        data.Add(name, new Dictionary<string,long>());
                    }
                    if(!data[name].ContainsKey(tag))
                    {
                        data[name][tag] = 0;
                    }
                    data[name][tag] += likes;
                }
            }

            data = data
                .OrderByDescending(x => x.Value.Values.Sum())
                .ThenBy(x => x.Value.Keys.Count)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var person in data)
            {
                System.Console.WriteLine($"{person.Key}");
                foreach (var tag in person.Value)
                {
                    System.Console.WriteLine($"- {tag.Key}: {tag.Value}");
                }
            }
        }
    }
}
