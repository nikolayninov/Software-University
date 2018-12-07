using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData {
    class Program {
        static void Main (string[] args) {
            int n = Int32.Parse (Console.ReadLine ());
            var cars = new List<Car> ();

            for (int i = 0; i < n; i++) {
                var line = Console.ReadLine ().Split (' ').ToArray ();

                string model = line[0];

                //  Engine
                long engSpeed = long.Parse (line[1]);
                long engPower = long.Parse (line[2]);
                Engine engine = new Engine (engSpeed, engPower);
                //  Cargo
                decimal crgoWeight = Decimal.Parse (line[3]);
                string crgoType = line[4];
                Cargo cargo = new Cargo (crgoWeight, crgoType);
                //  Tires
                decimal t1Pressure = Decimal.Parse (line[5]);
                long t1Age = long.Parse (line[6]);
                Tire t1 = new Tire (t1Pressure, t1Age);

                decimal t2Pressure = Decimal.Parse (line[7]);
                long t2Age = long.Parse (line[8]);
                Tire t2 = new Tire (t2Pressure, t2Age);

                decimal t3Pressure = Decimal.Parse (line[9]);
                long t3Age = long.Parse (line[10]);
                Tire t3 = new Tire (t3Pressure, t3Age);

                decimal t4Pressure = Decimal.Parse (line[11]);
                long t4Age = long.Parse (line[12]);
                Tire t4 = new Tire (t4Pressure, t4Age);

                List<Tire> tires = new List<Tire> () { t1, t2, t3, t4 };
                Car car = new Car (model, engine, cargo, tires);
                cars.Add (car);
            }
            string command = Console.ReadLine ();
            if (command == "fragile") {
                cars = cars.FindAll (x => x.Cargo.Type == command).FindAll (x => x.Tires.FindAll (y => y.Pressure < 1).Count > 0).ToList ();
            } else {
                cars = cars.FindAll (x => x.Cargo.Type == command).FindAll (x => x.Engine.Power > 250).ToList ();
            }
            foreach (var cr in cars) {
                System.Console.WriteLine (cr.Model);
            }
        }
    }
}