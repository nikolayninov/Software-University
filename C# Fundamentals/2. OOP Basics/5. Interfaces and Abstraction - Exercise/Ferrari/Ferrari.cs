namespace Ferrari
{
    public class Ferrari : ICar
    {
        public Ferrari(string driver)
        {
            this.Driver = driver;

        }
        public string Model { get; } = "488-Spider";
        public string Driver { get; set; }
        public string PushGasPedal()
        {
            return "Zadu6avam sA!";
        }

        public string UseBrakes()
        {
            return "Brakes!";
        }
        public override string ToString()
        {
            return $"{Model}/{UseBrakes()}/{PushGasPedal()}/{Driver}";
        }
    }
}