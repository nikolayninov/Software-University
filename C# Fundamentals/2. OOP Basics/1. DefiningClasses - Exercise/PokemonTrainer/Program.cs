using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer {
    class Program {
        static void Main(string[ ] args) {
            List<Trainer> trainers = new List<Trainer>();
            int count = 0;
            while (true) {
                var line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (line[0] == "Tournament") {
                    break;
                }
                string trainerName = line[0];
                string pokemonName = line[1];
                string element = line[2];
                decimal health = Decimal.Parse(line[3]);

                var trainer = trainers.Where(x => x.Name == trainerName).FirstOrDefault();

                if (trainer == null) {
                    trainer = new Trainer(count, trainerName);
                    trainers.Add(trainer);
                    count++;
                }
                Pokemon pokemon = new Pokemon(pokemonName, element, health);
                trainers.Find(x => x.Name == trainerName).AddPokemon(pokemon);

            }
            while (true) {
                var line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (line[0] == "End") {
                    break;
                }
                string element = line[0];
                foreach (var tr in trainers) {
                    tr.Tournament(element);
                    tr.CheckForDeadPokemons();
                }
            }
            trainers = trainers.OrderByDescending(x => x.Badges).ToList();
            foreach (var tr in trainers) {
                System.Console.WriteLine($"{tr.Name} {tr.Badges} {tr.Pokemons.Count}");
            }
        }
    }
}