namespace RawData {
    public class Tire {
        private decimal pressure;
        private long age;

        public Tire (decimal pressure, long age) {
            this.pressure = pressure;
            this.age = age;
        }

        public decimal Pressure {
            get { return this.pressure; }
            set { this.pressure = value; }
        }

        public long Age {
            get { return this.age; }
            set { this.age = value; }
        }
    }
}