namespace Mankind
{
    using System;
    public class Worker : Human
    {
        public decimal weekSalary;
        public decimal workHoursPerDay;
        private decimal totalHours;

        public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay) : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
            this.totalHours = this.workHoursPerDay * 5;
        }
        public decimal WeekSalary
        {
            get { return this.weekSalary; }
            protected set
            {
                if (value <= 10)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                }
                this.weekSalary = value;
            }
        }
        public decimal WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            protected set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }
                this.workHoursPerDay = value;
            }
        }
        public decimal GetSalaryPerHour()
        {
            return this.weekSalary / this.totalHours;
        }
        public override string ToString()
        {
            return $"First Name: {this.firstName}\n" +
                $"Last Name: {this.lastName}\n" +
                $"Week Salary: {this.weekSalary:F2}\n" +
                $"Hours per day: {this.workHoursPerDay:F2}\n" +
                $"Salary per hour: {this.GetSalaryPerHour():F2}\n";
        }
    }
}