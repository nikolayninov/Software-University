using System;
using System.Collections.Generic;
using System.Linq;

namespace Google {
    public class Relative {
        private string name;
        private string birthDate;

        public Relative(string name, string birthDate) {
            this.name = name;
            this.birthDate = birthDate;
        }
        public string Name {
            get { return this.name; }
            set { this.name = value; }
        }
        public string BirthDate {
            get { return this.name; }
            set { this.name = value; }
        }
        public override string ToString() {
            return $"{this.name} {this.birthDate}";
        }
    }
}