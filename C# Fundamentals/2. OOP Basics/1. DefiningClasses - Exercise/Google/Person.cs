using System;
using System.Collections.Generic;
using System.Linq;

namespace Google {
    public class Person {
        private string name;
        private Company company;
        private List<Relative> parents;
        private List<Relative> children;
        private List<Pokemon> pokemons;
        private Car car;

        public Person(string name) {
            this.name = name;
            this.parents = new List<Relative>();
            this.children = new List<Relative>();
            this.pokemons = new List<Pokemon>();
        }
        public string Name {
            get { return this.name; }
            set { this.name = value; }
        }
        public Company Company {
            get { return this.company; }
            set { this.company = value; }
        }
        public List<Relative> Parents {
            get { return this.parents; }
            set { this.parents = value; }
        }
        public List<Relative> Cildren {
            get { return this.children; }
            set { this.children = value; }
        }
        public List<Pokemon> Pokemons {
            get { return this.pokemons; }
            set { this.pokemons = value; }
        }
        public Car Car {
            get { return this.car; }
            set { this.car = value; }
        }
        public override string ToString() {
            string output = $"{this.name}\n" +
                $"Company:\n";
            if (this.company != null) {
                output += $"{this.company.ToString()}\n";
            }
            output += $"Car:\n";
            if (this.car != null) {
                output += $"{this.car.ToString()}\n";
            }
            output += $"Pokemon:\n";
            if (this.pokemons.Count > 0) {
                foreach (var pk in this.pokemons) {
                    output += $"{pk.ToString()}\n";
                }
            }
            output += $"Parents:\n";
            if (this.parents.Count > 0) {
                foreach (var pk in this.parents) {
                    output += $"{pk.ToString()}\n";
                }
            }
            output += $"Children:\n";
            if (this.children.Count > 0) {
                foreach (var pk in this.children) {
                    output += $"{pk.ToString()}\n";
                }
            }
            return output;

        }

    }
}