namespace Person
{
    using System;
    public class Child : Person
    {
        public override int Age
        {
            get { return this.age; }
            set
            {
                if (value > 15)
                {
                    throw new ArgumentException("Child's age must be less than 15!");
                }
                else if (value < 0)
                {
                    throw new ArgumentException("Age must be positive!");
                }
                this.age = value;
            }
        }
        public Child(string name, int age) : base(name, age) { }
    }
}