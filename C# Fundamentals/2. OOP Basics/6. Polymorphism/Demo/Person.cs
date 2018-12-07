namespace Demo
{
    public class Person : Mammal
    {
        public int Age { get; set; }
        public void Speak(string phrase)
        {
            System.Console.WriteLine(phrase);
        }
        public override void Walk()
        {
            base.Walk();
            System.Console.WriteLine("On two feet");
        }
        public override void Eat()
        {
            if (Age > 18)
            {
                System.Console.WriteLine("Drinking beer!");
            }
            else
            {
                base.Eat();
            }
        }
    }
}