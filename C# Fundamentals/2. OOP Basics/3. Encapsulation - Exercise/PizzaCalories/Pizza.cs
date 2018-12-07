namespace PizzaCalories {
    using System.Collections.Generic;
    using System.Linq;
    using System;
    public class Pizza {
        private string name;
        private string dough;
        private List<Topping> toppings;

        public string Name { get => name; set => name = value; }
        public string Dough { get => dough; set => dough = value; }
    }
}