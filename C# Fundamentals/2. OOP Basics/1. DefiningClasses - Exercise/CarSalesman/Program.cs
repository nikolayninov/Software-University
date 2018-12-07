using System;
using System.Collections.Generic;
using System.Linq;
namespace CarSalesman {
    public class Program {
        static void Main(string[ ] args) {
            int n = Int32.Parse(Console.ReadLine());

            var cars = new Dictionary<string, Car>();
            var engines = new Dictionary<string, Engine>();

            for (int i = 0; i < n; i++) {
                var line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                string model = line[0];
                double power = double.Parse(line[1]);
                Engine engine = new Engine(model, power);

                if (line.Length == 3) {
                    if (double.TryParse(line[2], out _)) {
                        engine.Displacement = line[2];

                    } else {
                        engine.Efficiency = line[2];
                    }
                } else if (line.Length == 4) {
                    engine.Displacement = line[2];
                    engine.Efficiency = line[3];
                }
                engines.Add(model, engine);
            }

            int m = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++) {
                var line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                string model = line[0];
                Engine engine = engines[line[1]];
                Car car = new Car(model, engine);

                if (line.Length == 3) {
                    if (double.TryParse(line[2], out _)) {
                        car.Weight = line[2];

                    } else {
                        car.Color = line[2];
                    }
                } else if (line.Length == 4) {
                    car.Weight = line[2];
                    car.Color = line[3];
                }
                cars.Add(model, car);
            }
            cars.Values.ToList().ForEach(Console.WriteLine);
        }
    }
}