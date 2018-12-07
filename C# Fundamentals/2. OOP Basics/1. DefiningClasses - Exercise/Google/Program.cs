using System;
using System.Collections.Generic;
using System.Linq;

namespace Google {
    class Program {
        static void Main(string[] args) {
            List<Person> people = new List<Person>();
            while (true) {
                var input = Console.ReadLine().Split(' ').ToArray();
                if (input[0] == "End") {
                    break;
                }
                string name = input[0];
                if (people.Where(x => x.Name == name).FirstOrDefault() == null) {
                    people.Add(new Person(name));
                }
                if (input[1] == "company") {
                    AddCompany(input, people, name);
                } else if (input[1] == "car") {
                    AddCar(input, people, name);
                } else if (input[1] == "pokemon") {
                    AddPokemon(input, people, name);
                } else if (input[1] == "parents") {
                    AddParent(input, people, name);
                } else if (input[1] == "children") {
                    AddChild(input, people, name);
                }
            }
            string askedPerson = Console.ReadLine();
            System.Console.WriteLine(people.Where(x => x.Name == askedPerson).First().ToString());
        }
        static void AddCompany(string[] input, List<Person> people, string personName) {
            string name = input[2];
            string department = input[3];
            decimal salary = Decimal.Parse(input[4]);

            Company company = new Company(name, department, salary);
            people.Where(x => x.Name == personName).First().Company = company;
        }
        static void AddCar(string[] input, List<Person> people, string personName) {
            string model = input[2];
            long speed = long.Parse(input[3]);

            Car car = new Car(model, speed);
            people.Where(x => x.Name == personName).First().Car = car;
        }
        static void AddPokemon(string[] input, List<Person> people, string personName) {
            string name = input[2];
            string type = input[3];

            Pokemon pokemon = new Pokemon(name, type);
            people.Where(x => x.Name == personName).First().Pokemons.Add(pokemon);
        }
        static void AddParent(string[] input, List<Person> people, string personName) {
            string name = input[2];
            string birthDate = input[3];

            Relative relative = new Relative(name, birthDate);
            people.Where(x => x.Name == personName).First().Parents.Add(relative);
        }
        static void AddChild(string[] input, List<Person> people, string personName) {
            string name = input[2];
            string birthDate = input[3];

            Relative relative = new Relative(name, birthDate);
            people.Where(x => x.Name == personName).First().Cildren.Add(relative);
        }

    }
}