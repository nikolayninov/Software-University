using System;

namespace ClassBox {
    public class Box {
        private double length;
        private double width;
        private double height;

        public double Length {
            get { return this.length; }
            private set {
                if (value <= 0)
                    throw new ArgumentException("Length cannot be zero or negative.");
                this.length = value;
            }
        }
        public double Width {
            get { return this.width; }
            private set {
                if (value <= 0)
                    throw new ArgumentException("Width cannot be zero or negative.");
                this.width = value;
            }
        }
        public double Height {
            get { return this.height; }
            private set {
                if (value <= 0)
                    throw new ArgumentException("Height cannot be zero or negative.");
                this.height = value;
            }
        }
        public Box() {
            this.length = 0;
            this.width = 0;
            this.height = 0;
        }
        public Box(double length, double width, double height) {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }
        public double GetVolume() {
            return this.length * this.height * this.width;
        }
        public double GetArea() {
            return 2 * (this.width * this.length + this.length * this.height + this.height * this.width);
        }
        public double GetLateralSurfaceArea() {
            return this.GetArea() - 2 * this.length * this.width;
        }

        public override string ToString() {
            return $"Surface Area - {this.GetArea():F2}\n" +
                $"Lateral Surface Area - {this.GetLateralSurfaceArea():F2}\n" +
                $"Volume - {this.GetVolume():F2}";
        }

    }
}