namespace RectangleIntersection {
    public class Rectangle {
        private string id;
        private decimal width;
        private decimal height;
        private decimal[] coords;

        public Rectangle (string id, decimal width, decimal height, decimal x, decimal y) {
            this.id = id;
            this.width = width;
            this.height = height;
            this.coords = new decimal[] { x, y + height, x + width, y };
        }

        public string Id {
            get { return this.id; }
            set { this.id = value; }
        }
        public decimal Width {
            get { return this.width; }
            set { this.width = value; }
        }
        public decimal Height {
            get { return this.height; }
            set { this.height = value; }
        }
        public decimal[] Coords {
            get { return this.coords; }
            set { this.coords = value; }
        }

        public bool IntersectsWith (Rectangle check) {
            if (this.coords[0] > check.Coords[2] || check.Coords[0] > this.coords[2] ||
                this.coords[1] < check.Coords[3] || check.Coords[1] < this.coords[3]) {
                return false;
            }
            return true;
        }

    }
}