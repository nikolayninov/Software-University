class Circle {
  constructor(radius) {
    this.radius = radius;
  }

  get diameter() {
    return 2 * this.radius
  }

  get area() {
    return Math.PI * this.radius * this.radius;
  }

  set diameter(diameter) {
    this.radius = diameter / 2;
  }

}

let circ = new Circle(5);
console.log(circ.area);
