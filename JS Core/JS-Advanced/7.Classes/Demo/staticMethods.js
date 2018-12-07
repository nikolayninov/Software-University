class Point {
  constructor(x, y) {
    this.x = x;
    this.y = y;
  }

  static distance(a, b) {
    let dx = a.x - b.x;
    let dy = a.y - b.y;
    return Math.sqrt(dx * dx + dy * dy);
  }
}

let p1 = new Point(2, 5);
let p2 = new Point(2, 10);
console.log(Point.distance(p1, p2)); // 5
