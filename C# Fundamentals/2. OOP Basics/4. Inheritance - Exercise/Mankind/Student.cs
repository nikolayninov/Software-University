namespace Mankind
{
    using System.Linq;
    using System.Text;
    using System;
    public class Student : Human
    {
        public string facultyNumber;
        public Student(string firstName, string lastName, string facultyNumber) : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }
        public string FacultyNumber
        {
            get { return this.facultyNumber; }
            protected set
            {
                if (value.Length < 5 || value.Length > 10 || !value.All(char.IsLetterOrDigit))
                {
                    throw new ArgumentException("Invalid faculty number!");
                }
                this.facultyNumber = value;
            }
        }
        public override string ToString()
        {
            return $"First Name: {this.firstName}\n" +
                $"Last Name: {this.lastName}\n" +
                $"Faculty number: {this.facultyNumber}\n";
        }

    }
}