namespace PizzaCalories {
    using System.Collections.Generic;
    using System;

    public class Dough {
        public IReadOnlyDictionary<string, double> Types { get; } = new IReadOnlyDictionary<string, double> { { "White", 1.5 },
            { "Wholegrain", 1.0 },
            { "Crispy", 0.9 },
            { "Chewy", 1.1 },
            { "Homemade", 1.0 }
        };
        private string flourType;
        private double flourMultiplier;
        private string bakingTechnique;
        private double bakingMultiplier;
        private double weight;

        public Dough(string flourType, string bakingTechnique, double weight) {

            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
        }

        public string FlourType {
            get { return this.flourType; }
            set {
                if (value != "White" || value != "Wholegrain") {
                    throw new ArgumentException("Invalid type of dough.");
                }
                switch (value) {
                    case "White":
                        this.flourMultiplier = this.Types[value];
                        break;
                    case "Wholegrain":
                        this.flourMultiplier = this.Types[value];
                        break;
                }
                this.flourType = value;
            }
        }
        public string BakingTechnique {
            get { return this.bakingTechnique; }
            set {
                if (value != "Crispy" || value != "Chewy" || value != "Homemade") {
                    throw new ArgumentException("Invalid type of dough.");
                }
                switch (value) {
                    case "Crispy":
                        this.flourMultiplier = this.Types[value];
                        break;
                    case "Chewy":
                        this.flourMultiplier = this.Types[value];
                        break;
                    case "Homemade":
                        this.flourMultiplier = this.Types[value];
                        break;
                }
                this.bakingTechnique = value;
            }
        }
        public double Weight {
            private get { return this.weight; } set {
                if (value < 1 || 200 < value) {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                this.weight = value;
            }
        }

        public double CalculateCalories() {
            return 2.0 * this.Weight * this.flourMultiplier * this.bakingMultiplier;
        }
    }
}