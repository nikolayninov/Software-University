using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonsInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Team team = new Team("Team");
            var lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                var cmdArgs = Console.ReadLine().Split();
                var person = new Person(cmdArgs[0],
                                        cmdArgs[1],
                                        int.Parse(cmdArgs[2]),
                                        decimal.Parse(cmdArgs[3]));

                team.AddPlayer(person);
            }
            System.Console.WriteLine($"First team has {team.FirstTeam.Count}");
            System.Console.WriteLine($"Reserve team has {team.ReserveTeam.Count}");

        }
    }
}
