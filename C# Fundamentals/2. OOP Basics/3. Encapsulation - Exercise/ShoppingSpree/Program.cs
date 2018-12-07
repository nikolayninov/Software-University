using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree {
    class Program {
        static void Main(string[] args) {
            try {
                Dictionary<string, Person> people = new Dictionary<string, Person>();
                Dictionary<string, Product> products = new Dictionary<string, Product>();

                InitializePeople(people);
                InitializeProducts(products);
                while (true) {
                    var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                    if (input[0].ToLower() == "end") {
                        break;
                    }
                    string person = input[0];
                    string product = input[1];
                    people[person].BuyProduct(products[product]);
                }
                PrintPeople(people);
            } catch (System.Exception ex) {
                System.Console.WriteLine(ex.Message);
            }

        }
        static void PrintPeople(Dictionary<string, Person> people) {
            foreach (var p in people) {
                System.Console.WriteLine(p.Value.ToString());
            }
        }
        static void InitializePeople(Dictionary<string, Person> people) {
            var input = Console.ReadLine()
                .Split(';', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            foreach (var person in input) {
                string[] personAttrs = person.Split('=').ToArray();
                people.Add(personAttrs[0], new Person(personAttrs[0], decimal.Parse(personAttrs[1])));
            }
        }

        static void InitializeProducts(Dictionary<string, Product> products) {
            var input = Console.ReadLine()
                .Split(';', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            foreach (var product in input) {
                string[] productAttrs = product.Split('=').ToArray();
                products.Add(productAttrs[0], new Product(productAttrs[0], decimal.Parse(productAttrs[1])));
            }
        }
    }
}