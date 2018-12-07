using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer {
    public class Trainer {
        private int id;

        private string name;
        private int badges;
        private List<Pokemon> pokemons;

        public Trainer(int id, string name) {
            this.id = id;
            this.name = name;
            this.badges = 0;
            this.pokemons = new List<Pokemon>();
        }
        public int Id {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Name {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Badges {
            get { return this.badges; }
            set { this.badges = value; }
        }
        public List<Pokemon> Pokemons {
            get { return this.pokemons; }
            set { this.pokemons = value; }
        }
        public void AddBadge() {
            this.badges += 1;
        }
        public void AddPokemon(Pokemon pokemon) {
            this.pokemons.Add(pokemon);
        }
        public void CheckForDeadPokemons() {
            this.pokemons = this.pokemons.FindAll(x => x.Health > 0).ToList();
        }
        public void Tournament(string element) {
            if (this.pokemons.FindAll(x => x.Element == element).Count == 0) {
                foreach (var pk in this.pokemons) {
                    pk.Health -= 10;
                }
            } else {
                this.AddBadge();
            }

        }
    }
}