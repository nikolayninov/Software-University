namespace RawData {
    public class Cargo {
        private decimal weight;
        private string type;

        public Cargo (decimal weight, string type) {
            this.weight = weight;
            this.type = type;
        }

        public decimal Weight {
            get { return this.weight; }
            set { this.weight = value; }
        }

        public string Type {
            get { return this.type; }
            set { this.type = value; }
        }
    }
}