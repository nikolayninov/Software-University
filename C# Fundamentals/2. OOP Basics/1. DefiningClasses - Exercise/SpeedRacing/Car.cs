namespace SpeedRacing {
    public class Car {
        private string model;
        private decimal fuelAmount;
        private decimal fuelPerKm;
        private decimal distance;

        public Car (string model, decimal fuelAmount, decimal fuelPerKm) {
            this.model = model;
            this.fuelAmount = fuelAmount;
            this.fuelPerKm = fuelPerKm;
            this.distance = 0;
        }

        public string Model {
            get { return this.model; }
            set { this.model = value; }
        }

        public decimal FuelAmount {
            get { return this.fuelAmount; }
            set { this.fuelAmount = value; }
        }
        public decimal FuelPerKm {
            get { return this.fuelPerKm; }
            set { this.fuelPerKm = value; }
        }

        public decimal Distance {
            get { return this.distance; }
            set { this.distance = value; }
        }

        public void Drive (decimal km) {
            if (fuelAmount >= fuelPerKm * km) {
                this.distance += km;
                this.fuelAmount -= fuelPerKm * km;
            } else {
                System.Console.WriteLine ("Insufficient fuel for the drive");
            }
        }
    }
}