namespace Demo
{
    public interface IAnimal
    {
        string Kind { get; set; }
        void Walk();
        void Climb();
    }
}