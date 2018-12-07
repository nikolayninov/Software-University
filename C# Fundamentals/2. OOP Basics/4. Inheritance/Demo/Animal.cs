namespace Demo
{
        public class Animal
        {
                public int Age { get; set; }
                public string Name { get; set; }
                protected int Weight { get; set; }
                public virtual void Move()
                {
                        // Moves
                }
        }
}