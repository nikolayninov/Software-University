namespace Demo
{
    public class Mammal : IAnimal
    {
        public string Kind { get; set; }

        public virtual void Climb()
        {
            System.Console.WriteLine("Climbing");
        }

        public virtual void Walk()
        {
            System.Console.WriteLine("Walking");
        }
        public virtual void Eat()
        {
            System.Console.WriteLine("Drinking milk");
        }
    }
}