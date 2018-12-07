namespace StartUp
{
    public class Tesla : Car, IElectricCar
    {
        private Battery battery;
        private bool isInMotion = false;
        public Battery Battery
        {
            get => battery;
            private set => battery = value;
        }
        public Tesla(string model, string color)
        {
            Model = model;
            Color = color;
            Battery = new Battery()
            {
                Capacity = 2000,
                Voltage = 300
            };
        }
        public override string Stop()
        {
            isInMotion = false;
            return "Tesla stopped!";
        }

        public override string Start()
        {
            isInMotion = true;
            return "Tesla started!";
        }
        public override string ToString()
        {
            return $"My {Color} Tesla {Model} is in {(isInMotion ? "motion" : "garage")}";
        }
    }
}