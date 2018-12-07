namespace StartUp
{
    using System;
    public abstract class Car : ICar
    {
        public string Model { get; set; }
        public virtual string Color { get; set; }

        public virtual string Start()
        {
            return "Car started";
        }
        public abstract string Stop();
    }
}