namespace CompanyRoster {
    public class Employee {
        private string name;
        private decimal salary;
        private string position;
        private string department;
        private string email;
        private int age;
        public Employee (string name, decimal salary, string position, string department, string email = "n/a", int age = -1) {
            this.name = name;
            this.salary = salary;
            this.position = position;
            this.department = department;
            this.email = email;
            this.age = age;
        }
        public string Name {
            get { return this.name; }
            set { this.name = value; }
        }
        public string Positon {
            get { return this.position; }
            set { this.position = value; }
        }
        public string Department {
            get { return this.department; }
            set { this.department = value; }
        }
        public decimal Salary {
            get { return this.salary; }
            set { this.salary = value; }
        }
        public string Email {
            get { return this.email; }
            set { this.email = value; }
        }

        public int Age {
            get { return this.age; }
            set { this.age = value; }
        }
    }
}