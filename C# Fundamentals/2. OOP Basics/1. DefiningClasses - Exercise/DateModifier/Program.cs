using System;
using System.Collections.Generic;
using System.Linq;

namespace DateModifier {
    class Program {
        static void Main (string[] args) {
            var first = Console.ReadLine ().Split (' ').Select (Int32.Parse).ToArray ();
            var second = Console.ReadLine ().Split (' ').Select (Int32.Parse).ToArray ();

            var a = new DateTime (first[0], first[1], first[2]);
            var b = new DateTime (second[0], second[1], second[2]);

            var diff = new DateModifier (a, b);
            System.Console.WriteLine (diff.Difference);
        }
    }
}