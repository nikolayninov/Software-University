namespace PointInRectangle {
    public class Rectangle {
        public Point TopLeft { get; set; }
        public Point BottomRight { get; set; }

        public Rectangle() {

        }
        public Rectangle(Point topLeft, Point bottomRight) {
            TopLeft = topLeft;
            BottomRight = bottomRight;
        }

        public bool Contains(Point point) {
            bool isInHorizontal =
                point.X >= TopLeft.X &&
                point.X <= BottomRight.X;
            bool isInVertical =
                point.Y <= TopLeft.Y &&
                point.Y >= BottomRight.Y;

            return isInHorizontal && isInVertical;
        }
    }
}