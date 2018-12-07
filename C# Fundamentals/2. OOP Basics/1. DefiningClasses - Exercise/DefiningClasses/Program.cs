using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses {
    public class StartUp {
        public static void Main (string[] args) {
            Family family = new Family ();
            int n = Int32.Parse (Console.ReadLine ());

            for (int i = 0; i < n; i++) {
                var line = Console.ReadLine ().Split (' ').ToArray ();
                if (Int32.Parse (line[1]) > 0) {

                    var member = new Person (line[0], Int32.Parse (line[1]));
                    family.AddMember (member);
                }
            }
            if (family.Members.Count > 0) {
                var oldestMembers = family.GetMembersOlderThan (30);

                oldestMembers.Sort ((x, y) => x.Name.CompareTo (y.Name));
                foreach (var m in oldestMembers) {

                    System.Console.WriteLine ($"{m.Name} - {m.Age}");
                }
            }
        }
    }
}