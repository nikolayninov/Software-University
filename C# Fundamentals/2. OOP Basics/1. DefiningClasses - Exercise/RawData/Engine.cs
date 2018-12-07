namespace RawData {
    public class Engine {
        private long speed;
        private long power;

        public Engine (long speed, long power) {
            this.speed = speed;
            this.power = power;
        }

        public long Speed {
            get { return this.speed; }
            set { this.speed = value; }
        }

        public long Power {
            get { return this.power; }
            set { this.power = value; }
        }
    }
}