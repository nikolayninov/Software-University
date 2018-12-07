namespace ShoppingSpree {
    using System.Collections.Generic;
    using System.Linq;
    using System;
    public class Person {
        private string name;
        private decimal money;
        private List<Product> products;

        public string Name {
            get { return this.name; }
            set {
                if (value.Trim() == "")
                    throw new ArgumentException("Name cannot be empty");
                this.name = value;
            }
        }
        public decimal Money {
            get { return this.money; }
            set {
                if (value < 0)
                    throw new ArgumentException("Money cannot be negative");
                this.money = value;
            }
        }
        public Person(string name, decimal money) {
            this.Name = name;
            this.Money = money;
            this.products = new List<Product>();
        }
        private void AddProduct(Product product) {
            this.products.Add(product);
        }
        public void BuyProduct(Product product) {
            if (this.Money >= product.Cost) {
                this.money -= product.Cost;
                this.AddProduct(product);
                System.Console.WriteLine($"{this.Name} bought {product.Name}");
            } else {
                System.Console.WriteLine($"{this.Name} can't afford {product.Name}");
            }
        }
        public override string ToString() {
            string boughtProducts = (this.products.Count > 0) ? String.Join(", ", this.products.Select(p => p.Name).ToList()) : "Nothing bought";
            return $"{this.Name} - {boughtProducts}";
        }
    }
}