using System;
using System.Collections.Generic;
using System.Linq;

namespace RectangleIntersection {
    class Program {
        static void Main (string[] args) {
            var ln = Console.ReadLine ().Split (' ').Select (Int32.Parse).ToArray ();

            int n = ln[0];
            int m = ln[1];

            var rects = new Dictionary<string, Rectangle> ();

            for (int i = 0; i < n; i++) {
                var line = Console.ReadLine ().Split (' ').ToArray ();

                string id = line[0];

                decimal width = long.Parse (line[1]);
                decimal height = long.Parse (line[2]);

                decimal x = Decimal.Parse (line[3]);
                decimal y = Decimal.Parse (line[4]);

                Rectangle rect = new Rectangle (id, width, height, x, y);
                rects.Add (id, rect);
            }

            for (int i = 0; i < m; i++) {
                var command = Console.ReadLine ().Split (' ').ToArray ();

                if (rects.ContainsKey (command[0]) && rects.ContainsKey (command[1])) {
                    if (rects[command[0]].IntersectsWith (rects[command[1]])) {
                        System.Console.WriteLine ("true");
                    } else {
                        System.Console.WriteLine ("false");
                    }
                } else {
                    System.Console.WriteLine ("false");
                }

            }
        }
    }
}