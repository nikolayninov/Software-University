using System;
using System.Collections.Generic;
using System.Linq;

namespace Google {
    public class Car {
        private string model;
        private long speed;
        public Car(string model, long speed) {
            this.model = model;
            this.speed = speed;
        }
        public string Model {
            get { return this.model; }
            set { this.model = value; }
        }
        public long Speed {
            get { return this.speed; }
            set { this.speed = value; }
        }
        public override string ToString() {
            return $"{this.model} {this.speed}";
        }
    }
}