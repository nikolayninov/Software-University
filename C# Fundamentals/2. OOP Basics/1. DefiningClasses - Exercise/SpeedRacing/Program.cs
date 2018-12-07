using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing {
    public class Program {
        static void Main (string[] args) {
            int n = Int32.Parse (Console.ReadLine ());

            var cars = new Dictionary<string, Car> ();

            for (int i = 0; i < n; i++) {
                var ln = Console.ReadLine ().Split (' ').ToArray ();

                string model = ln[0];
                decimal fuelAmount = Decimal.Parse (ln[1]);
                decimal fuelPerKm = Decimal.Parse (ln[2]);

                var car = new Car (model, fuelAmount, fuelPerKm);
                cars.Add (model, car);
            }

            while (true) {
                var ln = Console.ReadLine ().Split (' ').ToArray ();

                if (ln[0] == "End") {
                    break;
                }
                string model = ln[1];
                decimal km = Decimal.Parse (ln[2]);
                cars[model].Drive (km);
            }
            foreach (var cr in cars) {
                System.Console.WriteLine ($"{cr.Value.Model} {cr.Value.FuelAmount:f2} {cr.Value.Distance}");
            }
        }
    }
}