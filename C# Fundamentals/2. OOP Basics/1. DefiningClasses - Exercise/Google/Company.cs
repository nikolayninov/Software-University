using System;
using System.Collections.Generic;
using System.Linq;

namespace Google {
    public class Company {
        private string name;
        private string department;
        private decimal salary;
        public Company(string name, string department, decimal salary) {
            this.name = name;
            this.department = department;
            this.salary = salary;
        }
        public string Name {
            get { return this.name; }
            set { this.name = value; }
        }
        public string Department {
            get { return this.department; }
            set { this.department = value; }
        }
        public decimal Salary {
            get { return this.salary; }
            set { this.salary = value; }
        }
        public override string ToString() {
            return $"{this.name} {this.department} {this.salary:f2}";
        }
    }
}